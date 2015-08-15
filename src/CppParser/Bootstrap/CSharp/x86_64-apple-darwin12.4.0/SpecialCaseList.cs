//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace llvm
    {
        public unsafe partial class SpecialCaseList : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 72)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                internal llvm.StringMap.Internal Entries;

                [FieldOffset(32)]
                internal llvm.StringMap.Internal Regexps;

                [FieldOffset(64)]
                public bool IsCompiled;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm15SpecialCaseListD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15SpecialCaseList9inSectionENS_9StringRefES1_S1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool inSection_0(global::System.IntPtr instance, llvm.StringRef.Internal Section, llvm.StringRef.Internal Query, llvm.StringRef.Internal Category);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SpecialCaseList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SpecialCaseList>();

            private readonly bool __ownsNativeInstance;

            public static SpecialCaseList __CreateInstance(global::System.IntPtr native)
            {
                return new SpecialCaseList((SpecialCaseList.Internal*) native);
            }

            public static SpecialCaseList __CreateInstance(SpecialCaseList.Internal native)
            {
                return new SpecialCaseList(native);
            }

            private static SpecialCaseList.Internal* __CopyValue(SpecialCaseList.Internal native)
            {
                var ret = (SpecialCaseList.Internal*) Marshal.AllocHGlobal(72);
                *ret = native;
                return ret;
            }

            private SpecialCaseList(SpecialCaseList.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SpecialCaseList(SpecialCaseList.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
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
                llvm.SpecialCaseList __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>Returns true, if special case list contains a line and satisfies
            /// a wildcard expression &lt;E&gt;.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Returns true, if special case list contains a line</para>
            /// <para>  /// \code</para>
            /// <para>  ///   @Section:&lt;E&gt;=@Category</para>
            /// <para>  /// \endcode</para>
            /// <para>  /// and @Query satisfies a wildcard expression
            /// &lt;E&gt;.</para>
            /// </remarks>
            public bool inSection(llvm.StringRef Section, llvm.StringRef Query, llvm.StringRef Category)
            {
                var arg0 = ReferenceEquals(Section, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Section.__Instance);
                var arg1 = ReferenceEquals(Query, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Query.__Instance);
                var arg2 = ReferenceEquals(Category, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Category.__Instance);
                var __ret = Internal.inSection_0(__Instance, arg0, arg1, arg2);
                return __ret;
            }
        }
    }
}
