//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace clang
    {
        public enum SanitizerKind
        {
            Address = 0,
            Memory = 1,
            Thread = 2,
            Leak = 3,
            Alignment = 4,
            ArrayBounds = 5,
            Bool = 6,
            Enum = 7,
            FloatCastOverflow = 8,
            FloatDivideByZero = 9,
            Function = 10,
            IntegerDivideByZero = 11,
            NonnullAttribute = 12,
            Null = 13,
            ObjectSize = 14,
            Return = 15,
            ReturnsNonnullAttribute = 16,
            Shift = 17,
            SignedIntegerOverflow = 18,
            Unreachable = 19,
            VLABound = 20,
            Vptr = 21,
            UnsignedIntegerOverflow = 22,
            DataFlow = 23,
            CFIVptr = 24,
            LocalBounds = 25,
            Unknown = 26
        }

        public unsafe partial class SanitizerSet : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public uint Kinds;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang12SanitizerSetC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang12SanitizerSetC2ERKS0_")]
                internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang12SanitizerSet3hasENS_13SanitizerKindE")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool has_0(global::System.IntPtr instance, clang.SanitizerKind K);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang12SanitizerSet3setENS_13SanitizerKindEb")]
                internal static extern void set_0(global::System.IntPtr instance, clang.SanitizerKind K, bool Value);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang12SanitizerSet5clearEv")]
                internal static extern void clear_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang12SanitizerSet5emptyEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool empty_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SanitizerSet> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SanitizerSet>();

            private readonly bool __ownsNativeInstance;

            public static SanitizerSet __CreateInstance(global::System.IntPtr native)
            {
                return new SanitizerSet((SanitizerSet.Internal*) native);
            }

            public static SanitizerSet __CreateInstance(SanitizerSet.Internal native)
            {
                return new SanitizerSet(native);
            }

            private static SanitizerSet.Internal* __CopyValue(SanitizerSet.Internal native)
            {
                var ret = (SanitizerSet.Internal*) Marshal.AllocHGlobal(4);
                *ret = native;
                return ret;
            }

            private SanitizerSet(SanitizerSet.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SanitizerSet(SanitizerSet.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public SanitizerSet()
            {
                __Instance = Marshal.AllocHGlobal(4);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance);
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
                clang.SanitizerSet __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>Check if a certain sanitizer is enabled.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// \brief Check if a certain sanitizer is enabled.</para>
            /// </remarks>
            public bool has(clang.SanitizerKind K)
            {
                var arg0 = K;
                var __ret = Internal.has_0(__Instance, arg0);
                return __ret;
            }

            /// <summary>
            /// <para>Enable or disable a certain sanitizer.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// \brief Enable or disable a certain sanitizer.</para>
            /// </remarks>
            public void set(clang.SanitizerKind K, bool Value)
            {
                var arg0 = K;
                Internal.set_0(__Instance, arg0, Value);
            }

            /// <summary>
            /// <para>Disable all sanitizers.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// \brief Disable all sanitizers.</para>
            /// </remarks>
            public void clear()
            {
                Internal.clear_0(__Instance);
            }

            /// <summary>
            /// <para>Returns true if at least one sanitizer is enabled.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// \brief Returns true if at least one sanitizer is
            /// enabled.</para>
            /// </remarks>
            public bool empty()
            {
                var __ret = Internal.empty_0(__Instance);
                return __ret;
            }
        }
    }
}