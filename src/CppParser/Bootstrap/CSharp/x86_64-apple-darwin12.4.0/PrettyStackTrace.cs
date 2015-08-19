//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    public unsafe partial class PrettyStackTrace
    {
        public partial struct Internal
        {
        }
    }

    namespace llvm
    {
        /// <summary>
        /// <para>PrettyStackTraceEntry - This class is used to represent a frame
        /// of the &quot;pretty&quot; stack trace that is dumped when a program
        /// crashes. You can define subclasses of this and declare them on the program
        /// stack: when they are constructed and destructed, they will add their
        /// symbolic frames to a virtual stack trace. This gets dumped out if the
        /// program crashes.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// PrettyStackTraceEntry - This class is used to represent a
        /// frame of the</para>
        /// <para>  /// &quot;pretty&quot; stack trace that is dumped when a
        /// program crashes. You can define</para>
        /// <para>  /// subclasses of this and declare them on the program stack:
        /// when they are</para>
        /// <para>  /// constructed and destructed, they will add their symbolic
        /// frames to a</para>
        /// <para>  /// virtual stack trace.  This gets dumped out if the program
        /// crashes.</para>
        /// </remarks>
        public unsafe abstract partial class PrettyStackTraceEntry : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public partial struct Internal
            {
                [FieldOffset(8)]
                public global::System.IntPtr NextEntry;

                [FieldOffset(0)]
                public global::System.IntPtr vfptr0;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm21PrettyStackTraceEntryC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm21PrettyStackTraceEntryD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm21PrettyStackTraceEntry12getNextEntryEv")]
                internal static extern global::System.IntPtr getNextEntry_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, PrettyStackTraceEntry> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, PrettyStackTraceEntry>();

            private readonly bool __ownsNativeInstance;

            public static PrettyStackTraceEntry __CreateInstance(global::System.IntPtr native)
            {
                return new PrettyStackTraceEntryInternal((PrettyStackTraceEntry.Internal*) native);
            }

            public static PrettyStackTraceEntry __CreateInstance(PrettyStackTraceEntry.Internal native)
            {
                return new PrettyStackTraceEntryInternal(native);
            }

            protected PrettyStackTraceEntry(PrettyStackTraceEntry.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
                if (__Instance != global::System.IntPtr.Zero && !isInternalImpl)
                    SetupVTables(__Instance);
            }

            protected PrettyStackTraceEntry()
            {
                __Instance = Marshal.AllocHGlobal(16);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_1(__Instance);
                SetupVTables(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
            }

            public virtual void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.PrettyStackTraceEntry __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>print - Emit information about this stack frame to OS.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// print - Emit information about this stack frame to OS.</para>
            /// </remarks>
            public abstract void print(llvm.raw_ostream OS);

            /// <summary>
            /// <para>getNextEntry - Return the next entry in the list of
            /// frames.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// getNextEntry - Return the next entry in the list of
            /// frames.</para>
            /// </remarks>
            public llvm.PrettyStackTraceEntry getNextEntry()
            {
                var __ret = Internal.getNextEntry_0(__Instance);
                llvm.PrettyStackTraceEntry __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (llvm.PrettyStackTraceEntry.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (llvm.PrettyStackTraceEntry) llvm.PrettyStackTraceEntry.NativeToManagedMap[__ret];
                else llvm.PrettyStackTraceEntry.NativeToManagedMap[__ret] = __result0 = (llvm.PrettyStackTraceEntry) llvm.PrettyStackTraceEntry.__CreateInstance(__ret);
                return __result0;
            }

            #region Virtual table interop

            // virtual ~PrettyStackTraceEntry()
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _dtor_0Delegate(global::System.IntPtr instance);
            private static _dtor_0Delegate _dtor_0DelegateInstance;

            private static void _dtor_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceEntry) _References[instance].Target;
                __target.DestroyNativeInstance();
            }

            // void print(raw_ostream &OS) const = 0
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _print_0Delegate(global::System.IntPtr instance, global::System.IntPtr OS);
            private static _print_0Delegate _print_0DelegateInstance;

            private static void _print_0DelegateHook(global::System.IntPtr instance, global::System.IntPtr OS)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceEntry) _References[instance].Target;
                llvm.raw_ostream __result0;
                if (OS == IntPtr.Zero) __result0 = null;
                else if (llvm.raw_ostream.NativeToManagedMap.ContainsKey(OS))
                    __result0 = (llvm.raw_ostream) llvm.raw_ostream.NativeToManagedMap[OS];
                else llvm.raw_ostream.NativeToManagedMap[OS] = __result0 = (llvm.raw_ostream) llvm.raw_ostream.__CreateInstance(OS);
                __target.print(__result0);
            }

            private static void*[] _OldVTables;
            private static void*[] _NewVTables;
            private static void*[] _Thunks;
            private static System.Collections.Generic.Dictionary<IntPtr, WeakReference> _References;

            void SetupVTables(global::System.IntPtr instance)
            {
                var native = (Internal*)instance.ToPointer();

                if (_References == null)
                    _References = new System.Collections.Generic.Dictionary<IntPtr, WeakReference>();

                if (_References.ContainsKey(instance))
                    return;

                _References[instance] = new WeakReference(this);

                if (_OldVTables == null)
                {
                    _OldVTables = new void*[1];
                    _OldVTables[0] = native->vfptr0.ToPointer();
                }

                if (_Thunks == null)
                {
                    _Thunks = new void*[2];
                    _dtor_0DelegateInstance += _dtor_0DelegateHook;
                    _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtor_0DelegateInstance).ToPointer();
                    _print_0DelegateInstance += _print_0DelegateHook;
                    _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_print_0DelegateInstance).ToPointer();
                }

                if (_NewVTables == null)
                {
                    _NewVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 8);
                    _NewVTables[0] = vfptr0.ToPointer();
                    *(void**)(vfptr0 + 8) = _Thunks[0];
                    *(void**)(vfptr0 + 16) = _Thunks[1];
                }

                native->vfptr0 = new IntPtr(_NewVTables[0]);
            }

            #endregion
        }

        /// <summary>
        /// <para>PrettyStackTraceString - This object prints a specified string
        /// (which should not contain newlines) to the stream as the stack trace when a
        /// crash occurs.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// PrettyStackTraceString - This object prints a specified
        /// string (which</para>
        /// <para>  /// should not contain newlines) to the stream as the stack
        /// trace when a crash</para>
        /// <para>  /// occurs.</para>
        /// </remarks>
        public unsafe partial class PrettyStackTraceString : llvm.PrettyStackTraceEntry, IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public new partial struct Internal
            {
                [FieldOffset(8)]
                public global::System.IntPtr NextEntry;

                [FieldOffset(16)]
                public global::System.IntPtr Str;

                [FieldOffset(0)]
                public global::System.IntPtr vfptr0;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm22PrettyStackTraceStringC2EPKc")]
                internal static extern void ctor_0(global::System.IntPtr instance, global::System.IntPtr str);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm22PrettyStackTraceStringC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm22PrettyStackTraceStringD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm22PrettyStackTraceString5printERNS_11raw_ostreamE")]
                internal static extern void print_0(global::System.IntPtr instance, global::System.IntPtr OS);
            }

            private readonly bool __ownsNativeInstance;

            public static PrettyStackTraceString __CreateInstance(global::System.IntPtr native)
            {
                return new PrettyStackTraceString((PrettyStackTraceString.Internal*) native);
            }

            public static PrettyStackTraceString __CreateInstance(PrettyStackTraceString.Internal native)
            {
                return new PrettyStackTraceString(native);
            }

            private static PrettyStackTraceString.Internal* __CopyValue(PrettyStackTraceString.Internal native)
            {
                var ret = (PrettyStackTraceString.Internal*) Marshal.AllocHGlobal(24);
                *ret = native;
                return ret;
            }

            private PrettyStackTraceString(PrettyStackTraceString.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected PrettyStackTraceString(PrettyStackTraceString.Internal* native, bool isInternalImpl = false)
                : base((llvm.PrettyStackTraceEntry.Internal*) native)
            {
            }

            public PrettyStackTraceString(string str)
                : this((Internal*) null)
            {
                __Instance = Marshal.AllocHGlobal(24);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg0 = Marshal.StringToHGlobalAnsi(str);
                Internal.ctor_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
                SetupVTables(__Instance);
            }

            protected override void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
                base.Dispose(disposing);
            }

            public override void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.PrettyStackTraceEntry __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public override void print(llvm.raw_ostream OS)
            {
                var arg0 = ReferenceEquals(OS, null) ? global::System.IntPtr.Zero : OS.__Instance;
                Internal.print_0(__Instance, arg0);
            }

            #region Virtual table interop

            // PrettyStackTraceString
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _dtor_0Delegate(global::System.IntPtr instance);
            private static _dtor_0Delegate _dtor_0DelegateInstance;

            private static void _dtor_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceString) _References[instance].Target;
                __target.DestroyNativeInstance();
            }

            // void print(raw_ostream &OS) const override
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _print_0Delegate(global::System.IntPtr instance, global::System.IntPtr OS);
            private static _print_0Delegate _print_0DelegateInstance;

            private static void _print_0DelegateHook(global::System.IntPtr instance, global::System.IntPtr OS)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceString) _References[instance].Target;
                llvm.raw_ostream __result0;
                if (OS == IntPtr.Zero) __result0 = null;
                else if (llvm.raw_ostream.NativeToManagedMap.ContainsKey(OS))
                    __result0 = (llvm.raw_ostream) llvm.raw_ostream.NativeToManagedMap[OS];
                else llvm.raw_ostream.NativeToManagedMap[OS] = __result0 = (llvm.raw_ostream) llvm.raw_ostream.__CreateInstance(OS);
                __target.print(__result0);
            }

            private static void*[] _OldVTables;
            private static void*[] _NewVTables;
            private static void*[] _Thunks;
            private static System.Collections.Generic.Dictionary<IntPtr, WeakReference> _References;

            void SetupVTables(global::System.IntPtr instance)
            {
                var native = (Internal*)instance.ToPointer();

                if (_References == null)
                    _References = new System.Collections.Generic.Dictionary<IntPtr, WeakReference>();

                if (_References.ContainsKey(instance))
                    return;

                _References[instance] = new WeakReference(this);

                if (_OldVTables == null)
                {
                    _OldVTables = new void*[1];
                    _OldVTables[0] = native->vfptr0.ToPointer();
                }

                if (_Thunks == null)
                {
                    _Thunks = new void*[2];
                    _dtor_0DelegateInstance += _dtor_0DelegateHook;
                    _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtor_0DelegateInstance).ToPointer();
                    _print_0DelegateInstance += _print_0DelegateHook;
                    _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_print_0DelegateInstance).ToPointer();
                }

                if (_NewVTables == null)
                {
                    _NewVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 8);
                    _NewVTables[0] = vfptr0.ToPointer();
                    *(void**)(vfptr0 + 8) = _Thunks[0];
                    *(void**)(vfptr0 + 16) = _Thunks[1];
                }

                native->vfptr0 = new IntPtr(_NewVTables[0]);
            }

            #endregion
        }

        /// <summary>
        /// <para>PrettyStackTraceProgram - This object prints a specified program
        /// arguments to the stream as the stack trace when a crash occurs.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// PrettyStackTraceProgram - This object prints a specified
        /// program arguments</para>
        /// <para>  /// to the stream as the stack trace when a crash
        /// occurs.</para>
        /// </remarks>
        public unsafe partial class PrettyStackTraceProgram : llvm.PrettyStackTraceEntry, IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public new partial struct Internal
            {
                [FieldOffset(8)]
                public global::System.IntPtr NextEntry;

                [FieldOffset(16)]
                public int ArgC;

                [FieldOffset(24)]
                public sbyte** ArgV;

                [FieldOffset(0)]
                public global::System.IntPtr vfptr0;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm23PrettyStackTraceProgramC2EiPKPKc")]
                internal static extern void ctor_0(global::System.IntPtr instance, int argc, sbyte** argv);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm23PrettyStackTraceProgramC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm23PrettyStackTraceProgramD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm23PrettyStackTraceProgram5printERNS_11raw_ostreamE")]
                internal static extern void print_0(global::System.IntPtr instance, global::System.IntPtr OS);
            }

            private readonly bool __ownsNativeInstance;

            public static PrettyStackTraceProgram __CreateInstance(global::System.IntPtr native)
            {
                return new PrettyStackTraceProgram((PrettyStackTraceProgram.Internal*) native);
            }

            public static PrettyStackTraceProgram __CreateInstance(PrettyStackTraceProgram.Internal native)
            {
                return new PrettyStackTraceProgram(native);
            }

            private static PrettyStackTraceProgram.Internal* __CopyValue(PrettyStackTraceProgram.Internal native)
            {
                var ret = (PrettyStackTraceProgram.Internal*) Marshal.AllocHGlobal(32);
                *ret = native;
                return ret;
            }

            private PrettyStackTraceProgram(PrettyStackTraceProgram.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected PrettyStackTraceProgram(PrettyStackTraceProgram.Internal* native, bool isInternalImpl = false)
                : base((llvm.PrettyStackTraceEntry.Internal*) native)
            {
            }

            public PrettyStackTraceProgram(int argc, sbyte** argv)
                : this((Internal*) null)
            {
                __Instance = Marshal.AllocHGlobal(32);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg1 = argv;
                Internal.ctor_0(__Instance, argc, arg1);
                SetupVTables(__Instance);
            }

            protected override void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
                base.Dispose(disposing);
            }

            public override void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.PrettyStackTraceEntry __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public override void print(llvm.raw_ostream OS)
            {
                var arg0 = ReferenceEquals(OS, null) ? global::System.IntPtr.Zero : OS.__Instance;
                Internal.print_0(__Instance, arg0);
            }

            #region Virtual table interop

            // PrettyStackTraceProgram
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _dtor_0Delegate(global::System.IntPtr instance);
            private static _dtor_0Delegate _dtor_0DelegateInstance;

            private static void _dtor_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceProgram) _References[instance].Target;
                __target.DestroyNativeInstance();
            }

            // void print(raw_ostream &OS) const override
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _print_0Delegate(global::System.IntPtr instance, global::System.IntPtr OS);
            private static _print_0Delegate _print_0DelegateInstance;

            private static void _print_0DelegateHook(global::System.IntPtr instance, global::System.IntPtr OS)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var __target = (PrettyStackTraceProgram) _References[instance].Target;
                llvm.raw_ostream __result0;
                if (OS == IntPtr.Zero) __result0 = null;
                else if (llvm.raw_ostream.NativeToManagedMap.ContainsKey(OS))
                    __result0 = (llvm.raw_ostream) llvm.raw_ostream.NativeToManagedMap[OS];
                else llvm.raw_ostream.NativeToManagedMap[OS] = __result0 = (llvm.raw_ostream) llvm.raw_ostream.__CreateInstance(OS);
                __target.print(__result0);
            }

            private static void*[] _OldVTables;
            private static void*[] _NewVTables;
            private static void*[] _Thunks;
            private static System.Collections.Generic.Dictionary<IntPtr, WeakReference> _References;

            void SetupVTables(global::System.IntPtr instance)
            {
                var native = (Internal*)instance.ToPointer();

                if (_References == null)
                    _References = new System.Collections.Generic.Dictionary<IntPtr, WeakReference>();

                if (_References.ContainsKey(instance))
                    return;

                _References[instance] = new WeakReference(this);

                if (_OldVTables == null)
                {
                    _OldVTables = new void*[1];
                    _OldVTables[0] = native->vfptr0.ToPointer();
                }

                if (_Thunks == null)
                {
                    _Thunks = new void*[2];
                    _dtor_0DelegateInstance += _dtor_0DelegateHook;
                    _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtor_0DelegateInstance).ToPointer();
                    _print_0DelegateInstance += _print_0DelegateHook;
                    _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_print_0DelegateInstance).ToPointer();
                }

                if (_NewVTables == null)
                {
                    _NewVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 8);
                    _NewVTables[0] = vfptr0.ToPointer();
                    *(void**)(vfptr0 + 8) = _Thunks[0];
                    *(void**)(vfptr0 + 16) = _Thunks[1];
                }

                native->vfptr0 = new IntPtr(_NewVTables[0]);
            }

            #endregion
        }

        internal unsafe partial class PrettyStackTraceEntryInternal : llvm.PrettyStackTraceEntry, IDisposable
        {
            private readonly bool __ownsNativeInstance;

            private static PrettyStackTraceEntry.Internal* __CopyValue(PrettyStackTraceEntry.Internal native)
            {
                var ret = (PrettyStackTraceEntry.Internal*) Marshal.AllocHGlobal(16);
                *ret = native;
                return ret;
            }

            internal PrettyStackTraceEntryInternal(PrettyStackTraceEntry.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            internal PrettyStackTraceEntryInternal(PrettyStackTraceEntry.Internal* native, bool isInternalImpl = false)
                : base((llvm.PrettyStackTraceEntry.Internal*) native, true)
            {
            }

            protected override void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
                base.Dispose(disposing);
            }

            public override void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.PrettyStackTraceEntry __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>print - Emit information about this stack frame to OS.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// print - Emit information about this stack frame to OS.</para>
            /// </remarks>
            public override void print(llvm.raw_ostream OS)
            {
                void* slot = *(void**) (((PrettyStackTraceEntry.Internal*) __Instance)->vfptr0 + 2 * 8);
                var ___print_0Delegate = (_print_0Delegate) Marshal.GetDelegateForFunctionPointer(new IntPtr(slot), typeof(_print_0Delegate));
                var arg0 = ReferenceEquals(OS, null) ? global::System.IntPtr.Zero : OS.__Instance;
                ___print_0Delegate(__Instance, arg0);
            }
        }

        public unsafe partial class PrettyStackTrace
        {
            public partial struct Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm22EnablePrettyStackTraceEv")]
                internal static extern void EnablePrettyStackTrace_0();
            }

            public static void EnablePrettyStackTrace()
            {
                Internal.EnablePrettyStackTrace_0();
            }
        }
    }
}