#region Class Documentation
/************************************************************************************************************
Class Name:     EventInterfaceGenerate.cs
Type:           Editor, Generator, Util, Static
Definition:
                用法，在目录"Assets/GameScripts/HotFix/AppLogic/Event/Interface/"下分组照示例声明Interface 模块待抛出事件的接口。编译后自动生成接口实现抛出的脚本。
Example:
                
                旧版抛出事件方式：  GameEvent.Send(RuntimeId.ToRuntimeId("OnMainPlayerCurrencyChange"),CurrencyType.Gold,oldVal,newVal);
                 
                新版抛出事件方式 ： GameEvent.Get<IActorLogicEvent>().OnMainPlayerCurrencyChange(CurrencyType.Gold,oldVal,newVal); 
                
************************************************************************************************************/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EFFramework;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class EventInterfaceGenerate
{
    public static string NameSpace = @"AppLogic";
    
        
    public const string EventInterfacePath = "Assets/GameScripts/HotFix/AppLogic/Event/Interface/";

    public static bool BOpenAutoGenerate = false;
    
    static EventInterfaceGenerate()
    {
        BOpenAutoGenerate = EditorPrefs.GetBool("EventInterfaceGenerate.BOpenAutoGenerate", true);
        if (BOpenAutoGenerate)
        {
            Generate();
        }
    }

    [MenuItem("EFFramework/EventInterface/OpenAutoGenerate", false, 300)]
    public static void OpenAutoGenerate()
    {
        EditorPrefs.SetBool("EventInterfaceGenerate.BOpenAutoGenerate", true);
        Debug.Log("OpenAutoGenerate");
    }

    [MenuItem("EFFramework/EventInterface/CloseAutoGenerate", false, 301)]
    public static void CloseAutoGenerate()
    {
        EditorPrefs.SetBool("EventInterfaceGenerate.BOpenAutoGenerate", false);
        Debug.Log("CloseAutoGenerate");
    }
    
    [MenuItem("EFFramework/EventInterface/Generate EventInterface", false, 302)]
    public static void Generate()
    {
        if (EventInterfaceGenerateTag.HadGenerate)
        {
            return;
        }

        EventInterfaceGenerateTag.HadGenerate = true;

        // 加载程序集
        Assembly assembly = typeof(MainApp).Assembly;

        // 获取程序集中的所有类型
        Type[] types = assembly.GetTypes();

        // 遍历每个类型
        foreach (Type type in types)
        {
            // 检查类型是否是接口
            if (!type.IsInterface)
            {
                continue;
            }

            var attribute = type.GetCustomAttributes(typeof(EventInterfaceAttribute), false).FirstOrDefault();

            if (attribute != null)
            {
                EventInterfaceAttribute eventInterfaceAttribute = attribute as EventInterfaceAttribute;

                GenAutoBindCode(type, eventInterfaceAttribute);
            }
        }

        AssetDatabase.Refresh();
        Debug.Log("Generate EventInterface Complete");
        // EditorUtility.DisplayDialog("提示", "代码生成完毕", "OK");

        EditorCoroutineUtility.StartCoroutine(EventInterfaceGenerateTag.Reset(), null);
    }

    /// <summary>
    /// 生成自动绑定代码
    /// </summary>
    private static void GenAutoBindCode(Type interfaceType, EventInterfaceAttribute eventInterfaceAttribute)
    {
        string interfaceName = interfaceType.Name;
        string className = $"{interfaceName}_Gen";
        string codePath = $"{Application.dataPath}/GameScripts/HotFix/AppLogic/Event/Gen/{eventInterfaceAttribute.EventGroup}";

        if (!Directory.Exists(codePath))
        {
            Directory.CreateDirectory(codePath);
        }

        using (StreamWriter sw = new StreamWriter($"{codePath}/{className}.cs"))
        {
            sw.WriteLine(
                $"//------------------------------------------------------------------------------\n//\t<auto-generated>\n//\t\tThis code was generated by autoBindTool.\n//\t\tChanges to this file may cause incorrect behavior and will be lost if\n//\t\tthe code is regenerated.\n//\t</auto-generated>\n//------------------------------------------------------------------------------");
            sw.WriteLine("using UnityEngine;");
            sw.WriteLine("using UnityEngine.UI;");
            sw.WriteLine("using EFFramework;");
            sw.WriteLine("");

            if (!string.IsNullOrEmpty(NameSpace))
            {
                //命名空间
                sw.WriteLine("namespace " + NameSpace);
                sw.WriteLine("{");
            }

            #region EventId生成

            sw.WriteLine($"\tpublic partial class {interfaceName}_Event");
            sw.WriteLine("\t{");
            
            // 获取接口中的所有方法
            MethodInfo[] methods = interfaceType.GetMethods();

            HashSet<string> hadGenerate = new HashSet<string>();
            
            //组件字段
            foreach (MethodInfo method in methods)
            {
                if (hadGenerate.Contains(method.Name))
                {
                    continue;
                }
                sw.WriteLine($"\t\tpublic static readonly int {method.Name} = RuntimeId.ToRuntimeId(\"{interfaceName}_Event.{method.Name}\");");
                hadGenerate.Add(method.Name);
            }

            sw.WriteLine("\t}");
            sw.WriteLine("");

            #endregion


            //类名
            sw.WriteLine($"\t[EventInterfaceImp(EEventGroup.{eventInterfaceAttribute.EventGroup})]");
            sw.WriteLine($"\tpublic partial class {className} : {interfaceName}");
            sw.WriteLine("\t{");

            sw.WriteLine("\t\tprivate EventDispatcher _dispatcher;");
            sw.WriteLine($"\t\tpublic {className}(EventDispatcher dispatcher)");
            sw.WriteLine("\t\t{");
            sw.WriteLine($"\t\t\t_dispatcher = dispatcher;");
            sw.WriteLine("\t\t}");
            sw.WriteLine("");

            //组件字段
            foreach (MethodInfo methodInfo in methods)
            {
                ParameterInfo[] parameterInfos = methodInfo.GetParameters(); //得到指定方法的参数列表  
                if (parameterInfos.Length <= 0)
                {
                    sw.WriteLine(
                        $"        public void {methodInfo.Name}()\n        {{\n            _dispatcher.Send({interfaceName}_Event.{methodInfo.Name});\n        }}");
                }
                else
                {
                    string paramStr = "";
                    string paramStr2 = "";
                    for (int i = 0; i < parameterInfos.Length; i++)
                    {
                        var parameterInfo = parameterInfos[i];
                        Type type = parameterInfo.ParameterType;
                        string paramName = parameterInfo.Name;
                        if (i == parameterInfos.Length - 1)
                        {
                            paramStr += $"{type.FullName} {paramName}";
                            paramStr2 += $"{paramName}";
                        }
                        else
                        {
                            paramStr += $"{type.FullName} {paramName},";
                            paramStr2 += $"{paramName},";
                        }
                    }

                    sw.WriteLine(
                        $"        public void {methodInfo.Name}({paramStr})\n        {{\n            _dispatcher.Send({interfaceName}_Event.{methodInfo.Name},{paramStr2});\n        }}");
                }

                sw.WriteLine("");
            }

            sw.WriteLine("\t}");

            if (!string.IsNullOrEmpty(NameSpace))
            {
                sw.WriteLine("}");
            }
        }
    }
}

public static class EventInterfaceGenerateTag
{
    public static bool HadGenerate = false;
    
    public static IEnumerator Reset()
    {
        yield return new WaitForSeconds(10f);
        HadGenerate = false;
    }
}