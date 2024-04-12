﻿using System.Diagnostics;

namespace EFFramework
{
    /// <summary>
    /// 日志工具集。
    /// </summary>
    public static class EFLogger
    {
        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug(object message)
        {
            EFFrameworkLog.Debug(message);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug(string message)
        {
            EFFrameworkLog.Debug(message);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T">日志参数的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg">日志参数。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T>(string format, T arg)
        {
            EFFrameworkLog.Debug(format, arg);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            EFFrameworkLog.Debug(format, arg1, arg2);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11, T12 arg12)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// 打印调试级别日志，用于记录调试类日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <typeparam name="T16">日志参数 16 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <param name="arg16">日志参数 16。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_DEBUG_LOG 或 ENABLE_DEBUG_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_DEBUG_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            EFFrameworkLog.Debug(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info(object message)
        {
            EFFrameworkLog.Info(message);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info(string message)
        {
            EFFrameworkLog.Info(message);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T">日志参数的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg">日志参数。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T>(string format, T arg)
        {
            EFFrameworkLog.Info(format, arg);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            EFFrameworkLog.Info(format, arg1, arg2);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11, T12 arg12)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// 打印信息级别日志，用于记录程序正常运行日志信息。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <typeparam name="T16">日志参数 16 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <param name="arg16">日志参数 16。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_INFO_LOG、ENABLE_DEBUG_AND_ABOVE_LOG 或 ENABLE_INFO_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_INFO_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            EFFrameworkLog.Info(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning(object message)
        {
            EFFrameworkLog.Warning(message);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning(string message)
        {
            EFFrameworkLog.Warning(message);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T">日志参数的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg">日志参数。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T>(string format, T arg)
        {
            EFFrameworkLog.Warning(format, arg);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            EFFrameworkLog.Warning(format, arg1, arg2);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <typeparam name="T16">日志参数 16 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <param name="arg16">日志参数 16。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_WARNING_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG 或 ENABLE_WARNING_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_WARNING_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        public static void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            EFFrameworkLog.Warning(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error(object message)
        {
            EFFrameworkLog.Error(message);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error(string message)
        {
            EFFrameworkLog.Error(message);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T">日志参数的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg">日志参数。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T>(string format, T arg)
        {
            EFFrameworkLog.Error(format, arg);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            EFFrameworkLog.Error(format, arg1, arg2);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11, T12 arg12)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致应用崩溃或异常时使用。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <typeparam name="T16">日志参数 16 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <param name="arg16">日志参数 16。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_ERROR_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG 或 ENABLE_ERROR_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_ERROR_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            EFFrameworkLog.Error(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal(object message)
        {
            EFFrameworkLog.Fatal(message);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <param name="message">日志内容。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal(string message)
        {
            EFFrameworkLog.Fatal(message);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T">日志参数的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg">日志参数。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T>(string format, T arg)
        {
            EFFrameworkLog.Fatal(format, arg);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            T10 arg10, T11 arg11, T12 arg12)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// 打印严重错误级别日志，建议在发生严重错误，可能导致应用崩溃或异常时使用，此时应尝试重启进程或重建应用框架。
        /// </summary>
        /// <typeparam name="T1">日志参数 1 的类型。</typeparam>
        /// <typeparam name="T2">日志参数 2 的类型。</typeparam>
        /// <typeparam name="T3">日志参数 3 的类型。</typeparam>
        /// <typeparam name="T4">日志参数 4 的类型。</typeparam>
        /// <typeparam name="T5">日志参数 5 的类型。</typeparam>
        /// <typeparam name="T6">日志参数 6 的类型。</typeparam>
        /// <typeparam name="T7">日志参数 7 的类型。</typeparam>
        /// <typeparam name="T8">日志参数 8 的类型。</typeparam>
        /// <typeparam name="T9">日志参数 9 的类型。</typeparam>
        /// <typeparam name="T10">日志参数 10 的类型。</typeparam>
        /// <typeparam name="T11">日志参数 11 的类型。</typeparam>
        /// <typeparam name="T12">日志参数 12 的类型。</typeparam>
        /// <typeparam name="T13">日志参数 13 的类型。</typeparam>
        /// <typeparam name="T14">日志参数 14 的类型。</typeparam>
        /// <typeparam name="T15">日志参数 15 的类型。</typeparam>
        /// <typeparam name="T16">日志参数 16 的类型。</typeparam>
        /// <param name="format">日志格式。</param>
        /// <param name="arg1">日志参数 1。</param>
        /// <param name="arg2">日志参数 2。</param>
        /// <param name="arg3">日志参数 3。</param>
        /// <param name="arg4">日志参数 4。</param>
        /// <param name="arg5">日志参数 5。</param>
        /// <param name="arg6">日志参数 6。</param>
        /// <param name="arg7">日志参数 7。</param>
        /// <param name="arg8">日志参数 8。</param>
        /// <param name="arg9">日志参数 9。</param>
        /// <param name="arg10">日志参数 10。</param>
        /// <param name="arg11">日志参数 11。</param>
        /// <param name="arg12">日志参数 12。</param>
        /// <param name="arg13">日志参数 13。</param>
        /// <param name="arg14">日志参数 14。</param>
        /// <param name="arg15">日志参数 15。</param>
        /// <param name="arg16">日志参数 16。</param>
        /// <remarks>仅在带有 ENABLE_LOG、ENABLE_FATAL_LOG、ENABLE_DEBUG_AND_ABOVE_LOG、ENABLE_INFO_AND_ABOVE_LOG、ENABLE_WARNING_AND_ABOVE_LOG、ENABLE_ERROR_AND_ABOVE_LOG 或 ENABLE_FATAL_AND_ABOVE_LOG 预编译选项时生效。</remarks>
        [Conditional("ENABLE_LOG")]
        [Conditional("ENABLE_FATAL_LOG")]
        [Conditional("ENABLE_DEBUG_AND_ABOVE_LOG")]
        [Conditional("ENABLE_INFO_AND_ABOVE_LOG")]
        [Conditional("ENABLE_WARNING_AND_ABOVE_LOG")]
        [Conditional("ENABLE_ERROR_AND_ABOVE_LOG")]
        [Conditional("ENABLE_FATAL_AND_ABOVE_LOG")]
        public static void Fatal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            EFFrameworkLog.Fatal(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// 断言严重错误级别日志，建议在发生严重错误。
        /// </summary>
        /// <param name="condition">条件。</param>
        [Conditional("ENABLE_LOG")]
        public static void Assert(bool condition)
        {
            if (!condition)
            {
                string message = Utility.Text.Format("{0}\n{1}", "Assert Failed", System.Environment.StackTrace);
                Fatal(message);
            }
        }

        /// <summary>
        /// 断言严重错误级别日志，建议在发生严重错误。
        /// </summary>
        /// <param name="condition">条件。</param>
        /// <param name="retStr">断言输出字符串。</param>
        [Conditional("ENABLE_LOG")]
        public static void Assert(bool condition, string retStr)
        {
            if (!condition)
            {
                string message = Utility.Text.Format("{0}\n{1}", "Assert Failed" + retStr, System.Environment.StackTrace);
                Fatal(message);
            }
        }
    }
}