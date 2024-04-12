﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace EFFramework
{
    /// <summary>
    /// 应用配置辅助器基类。
    /// </summary>
    public abstract class SettingHelperBase : MonoBehaviour, ISettingHelper
    {
        /// <summary>
        /// 获取应用配置项数量。
        /// </summary>
        public abstract int Count
        {
            get;
        }

        /// <summary>
        /// 加载应用配置。
        /// </summary>
        /// <returns>是否加载应用配置成功。</returns>
        public abstract bool Load();

        /// <summary>
        /// 保存应用配置。
        /// </summary>
        /// <returns>是否保存应用配置成功。</returns>
        public abstract bool Save();

        /// <summary>
        /// 获取所有应用配置项的名称。
        /// </summary>
        /// <returns>所有应用配置项的名称。</returns>
        public abstract string[] GetAllSettingNames();

        /// <summary>
        /// 获取所有应用配置项的名称。
        /// </summary>
        /// <param name="results">所有应用配置项的名称。</param>
        public abstract void GetAllSettingNames(List<string> results);

        /// <summary>
        /// 检查是否存在指定应用配置项。
        /// </summary>
        /// <param name="settingName">要检查应用配置项的名称。</param>
        /// <returns>指定的应用配置项是否存在。</returns>
        public abstract bool HasSetting(string settingName);

        /// <summary>
        /// 移除指定应用配置项。
        /// </summary>
        /// <param name="settingName">要移除应用配置项的名称。</param>
        /// <returns>是否移除指定应用配置项成功。</returns>
        public abstract bool RemoveSetting(string settingName);

        /// <summary>
        /// 清空所有应用配置项。
        /// </summary>
        public abstract void RemoveAllSettings();

        /// <summary>
        /// 从指定应用配置项中读取布尔值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的布尔值。</returns>
        public abstract bool GetBool(string settingName);

        /// <summary>
        /// 从指定应用配置项中读取布尔值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultValue">当指定的应用配置项不存在时，返回此默认值。</param>
        /// <returns>读取的布尔值。</returns>
        public abstract bool GetBool(string settingName, bool defaultValue);

        /// <summary>
        /// 向指定应用配置项写入布尔值。
        /// </summary>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="value">要写入的布尔值。</param>
        public abstract void SetBool(string settingName, bool value);

        /// <summary>
        /// 从指定应用配置项中读取整数值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的整数值。</returns>
        public abstract int GetInt(string settingName);

        /// <summary>
        /// 从指定应用配置项中读取整数值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultValue">当指定的应用配置项不存在时，返回此默认值。</param>
        /// <returns>读取的整数值。</returns>
        public abstract int GetInt(string settingName, int defaultValue);

        /// <summary>
        /// 向指定应用配置项写入整数值。
        /// </summary>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="value">要写入的整数值。</param>
        public abstract void SetInt(string settingName, int value);

        /// <summary>
        /// 从指定应用配置项中读取浮点数值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的浮点数值。</returns>
        public abstract float GetFloat(string settingName);

        /// <summary>
        /// 从指定应用配置项中读取浮点数值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultValue">当指定的应用配置项不存在时，返回此默认值。</param>
        /// <returns>读取的浮点数值。</returns>
        public abstract float GetFloat(string settingName, float defaultValue);

        /// <summary>
        /// 向指定应用配置项写入浮点数值。
        /// </summary>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="value">要写入的浮点数值。</param>
        public abstract void SetFloat(string settingName, float value);

        /// <summary>
        /// 从指定应用配置项中读取字符串值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的字符串值。</returns>
        public abstract string GetString(string settingName);

        /// <summary>
        /// 从指定应用配置项中读取字符串值。
        /// </summary>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultValue">当指定的应用配置项不存在时，返回此默认值。</param>
        /// <returns>读取的字符串值。</returns>
        public abstract string GetString(string settingName, string defaultValue);

        /// <summary>
        /// 向指定应用配置项写入字符串值。
        /// </summary>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="value">要写入的字符串值。</param>
        public abstract void SetString(string settingName, string value);

        /// <summary>
        /// 从指定应用配置项中读取对象。
        /// </summary>
        /// <typeparam name="T">要读取对象的类型。</typeparam>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的对象。</returns>
        public abstract T GetObject<T>(string settingName);

        /// <summary>
        /// 从指定应用配置项中读取对象。
        /// </summary>
        /// <param name="objectType">要读取对象的类型。</param>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <returns>读取的对象。</returns>
        public abstract object GetObject(Type objectType, string settingName);

        /// <summary>
        /// 从指定应用配置项中读取对象。
        /// </summary>
        /// <typeparam name="T">要读取对象的类型。</typeparam>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultObj">当指定的应用配置项不存在时，返回此默认对象。</param>
        /// <returns>读取的对象。</returns>
        public abstract T GetObject<T>(string settingName, T defaultObj);

        /// <summary>
        /// 从指定应用配置项中读取对象。
        /// </summary>
        /// <param name="objectType">要读取对象的类型。</param>
        /// <param name="settingName">要获取应用配置项的名称。</param>
        /// <param name="defaultObj">当指定的应用配置项不存在时，返回此默认对象。</param>
        /// <returns>读取的对象。</returns>
        public abstract object GetObject(Type objectType, string settingName, object defaultObj);

        /// <summary>
        /// 向指定应用配置项写入对象。
        /// </summary>
        /// <typeparam name="T">要写入对象的类型。</typeparam>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="obj">要写入的对象。</param>
        public abstract void SetObject<T>(string settingName, T obj);

        /// <summary>
        /// 向指定应用配置项写入对象。
        /// </summary>
        /// <param name="settingName">要写入应用配置项的名称。</param>
        /// <param name="obj">要写入的对象。</param>
        public abstract void SetObject(string settingName, object obj);
    }
}
