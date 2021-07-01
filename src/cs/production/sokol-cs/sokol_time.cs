
//-------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the following tool:
//        https://github.com/lithiumtoast/c2cs
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ReSharper disable All
//-------------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using C2CS;

#nullable enable
#pragma warning disable 1591

public static unsafe partial class sokol_time
{
    private const string LibraryName = "sokol";
    private static IntPtr _libraryHandle;

    static sokol_time()
    {
        TryLoadApi();
    }

    public static bool TryLoadApi(string? libraryName = LibraryName)
    {
        UnloadApi();
        _libraryHandle = Runtime.LibraryLoad(libraryName!);
        if (_libraryHandle == IntPtr.Zero) return false;
        _LoadVirtualTable();
        return true;
    }

    public static void UnloadApi()
    {
        if (_libraryHandle == IntPtr.Zero) return;
        _UnloadVirtualTable();
        Runtime.LibraryUnload(_libraryHandle);
    }

    // Function @ sokol_time.h:135:28
    public static double stm_ns(ulong ticks)
    {
        return _virtualTable.stm_ns(ticks);
    }

    // Function @ sokol_time.h:134:28
    public static double stm_us(ulong ticks)
    {
        return _virtualTable.stm_us(ticks);
    }

    // Function @ sokol_time.h:133:28
    public static double stm_ms(ulong ticks)
    {
        return _virtualTable.stm_ms(ticks);
    }

    // Function @ sokol_time.h:132:28
    public static double stm_sec(ulong ticks)
    {
        return _virtualTable.stm_sec(ticks);
    }

    // Function @ sokol_time.h:131:30
    public static ulong stm_round_to_common_refresh_rate(ulong frame_ticks)
    {
        return _virtualTable.stm_round_to_common_refresh_rate(frame_ticks);
    }

    // Function @ sokol_time.h:130:30
    public static ulong stm_laptime(ulong* last_time)
    {
        return _virtualTable.stm_laptime(last_time);
    }

    // Function @ sokol_time.h:129:30
    public static ulong stm_since(ulong start_ticks)
    {
        return _virtualTable.stm_since(start_ticks);
    }

    // Function @ sokol_time.h:128:30
    public static ulong stm_diff(ulong new_ticks, ulong old_ticks)
    {
        return _virtualTable.stm_diff(new_ticks, old_ticks);
    }

    // Function @ sokol_time.h:127:30
    public static ulong stm_now()
    {
        return _virtualTable.stm_now();
    }

    // Function @ sokol_time.h:126:26
    public static void stm_setup()
    {
        _virtualTable.stm_setup();
    }

    private static void _LoadVirtualTable()
    {
        #region "Functions"

        _virtualTable.stm_ns = (delegate* unmanaged[Cdecl]<ulong, double>)Runtime.LibraryGetExport(_libraryHandle, "stm_ns");
        _virtualTable.stm_us = (delegate* unmanaged[Cdecl]<ulong, double>)Runtime.LibraryGetExport(_libraryHandle, "stm_us");
        _virtualTable.stm_ms = (delegate* unmanaged[Cdecl]<ulong, double>)Runtime.LibraryGetExport(_libraryHandle, "stm_ms");
        _virtualTable.stm_sec = (delegate* unmanaged[Cdecl]<ulong, double>)Runtime.LibraryGetExport(_libraryHandle, "stm_sec");
        _virtualTable.stm_round_to_common_refresh_rate = (delegate* unmanaged[Cdecl]<ulong, ulong>)Runtime.LibraryGetExport(_libraryHandle, "stm_round_to_common_refresh_rate");
        _virtualTable.stm_laptime = (delegate* unmanaged[Cdecl]<ulong*, ulong>)Runtime.LibraryGetExport(_libraryHandle, "stm_laptime");
        _virtualTable.stm_since = (delegate* unmanaged[Cdecl]<ulong, ulong>)Runtime.LibraryGetExport(_libraryHandle, "stm_since");
        _virtualTable.stm_diff = (delegate* unmanaged[Cdecl]<ulong, ulong, ulong>)Runtime.LibraryGetExport(_libraryHandle, "stm_diff");
        _virtualTable.stm_now = (delegate* unmanaged[Cdecl]<ulong>)Runtime.LibraryGetExport(_libraryHandle, "stm_now");
        _virtualTable.stm_setup = (delegate* unmanaged[Cdecl]<void>)Runtime.LibraryGetExport(_libraryHandle, "stm_setup");

        #endregion

        #region "Variables"



        #endregion
    }

    private static void _UnloadVirtualTable()
    {
        #region "Functions"

        _virtualTable.stm_ns = (delegate* unmanaged[Cdecl]<ulong, double>)IntPtr.Zero;
        _virtualTable.stm_us = (delegate* unmanaged[Cdecl]<ulong, double>)IntPtr.Zero;
        _virtualTable.stm_ms = (delegate* unmanaged[Cdecl]<ulong, double>)IntPtr.Zero;
        _virtualTable.stm_sec = (delegate* unmanaged[Cdecl]<ulong, double>)IntPtr.Zero;
        _virtualTable.stm_round_to_common_refresh_rate = (delegate* unmanaged[Cdecl]<ulong, ulong>)IntPtr.Zero;
        _virtualTable.stm_laptime = (delegate* unmanaged[Cdecl]<ulong*, ulong>)IntPtr.Zero;
        _virtualTable.stm_since = (delegate* unmanaged[Cdecl]<ulong, ulong>)IntPtr.Zero;
        _virtualTable.stm_diff = (delegate* unmanaged[Cdecl]<ulong, ulong, ulong>)IntPtr.Zero;
        _virtualTable.stm_now = (delegate* unmanaged[Cdecl]<ulong>)IntPtr.Zero;
        _virtualTable.stm_setup = (delegate* unmanaged[Cdecl]<void>)IntPtr.Zero;

        #endregion

        #region "Variables"



        #endregion
    }

    // The virtual table represents a list of pointers to functions or variables which are resolved in a late manner.
    //	This allows for flexibility in swapping implementations at runtime.
    //	You can think of it in traditional OOP terms in C# as the locations of the virtual methods and/or properties of an object.
    public struct _VirtualTable
    {
        #region "Function Pointers"
        // These pointers hold the locations in the native library where functions are located at runtime.
        // See: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers

        public delegate* unmanaged[Cdecl]<ulong, double> stm_ns;
        public delegate* unmanaged[Cdecl]<ulong, double> stm_us;
        public delegate* unmanaged[Cdecl]<ulong, double> stm_ms;
        public delegate* unmanaged[Cdecl]<ulong, double> stm_sec;
        public delegate* unmanaged[Cdecl]<ulong, ulong> stm_round_to_common_refresh_rate;
        public delegate* unmanaged[Cdecl]<ulong*, ulong> stm_laptime;
        public delegate* unmanaged[Cdecl]<ulong, ulong> stm_since;
        public delegate* unmanaged[Cdecl]<ulong, ulong, ulong> stm_diff;
        public delegate* unmanaged[Cdecl]<ulong> stm_now;
        public delegate* unmanaged[Cdecl]<void> stm_setup;

        #endregion

        #region "Variables"
        // These pointers hold the locations in the native library where global variables are located at runtime.
        //	The value pointed by these pointers are updated by reading/writing memory.



        #endregion
    }

    private static _VirtualTable _virtualTable;
}
