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
        /// <summary>
        /// <para>This owns the files read by a parser, handles include stacks, and
        /// handles diagnostic wrangling.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// This owns the files read by a parser, handles include
        /// stacks,</para>
        /// <para>/// and handles diagnostic wrangling.</para>
        /// </remarks>
        public unsafe partial class SourceMgr : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 72)]
            public partial struct Internal
            {
                [FieldOffset(48)]
                public global::System.IntPtr LineNoCache;

                [FieldOffset(56)]
                public global::System.IntPtr DiagHandler;

                [FieldOffset(64)]
                public global::System.IntPtr DiagContext;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm9SourceMgrC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm9SourceMgrD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm9SourceMgr14setDiagHandlerEPFvRKNS_12SMDiagnosticEPvES4_")]
                internal static extern void setDiagHandler_0(global::System.IntPtr instance, global::System.IntPtr DH, global::System.IntPtr Ctx);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr14getDiagHandlerEv")]
                internal static extern global::System.IntPtr getDiagHandler_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr14getDiagContextEv")]
                internal static extern global::System.IntPtr getDiagContext_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr15getMemoryBufferEj")]
                internal static extern global::System.IntPtr getMemoryBuffer_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr13getNumBuffersEv")]
                internal static extern uint getNumBuffers_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr13getMainFileIDEv")]
                internal static extern uint getMainFileID_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr19getParentIncludeLocEj")]
                internal static extern llvm.SMLoc.Internal getParentIncludeLoc_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr23FindBufferContainingLocENS_5SMLocE")]
                internal static extern uint FindBufferContainingLoc_0(global::System.IntPtr instance, llvm.SMLoc.Internal Loc);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr14FindLineNumberENS_5SMLocEj")]
                internal static extern uint FindLineNumber_0(global::System.IntPtr instance, llvm.SMLoc.Internal Loc, uint BufferID);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr12PrintMessageERNS_11raw_ostreamERKNS_12SMDiagnosticEb")]
                internal static extern void PrintMessage_2(global::System.IntPtr instance, global::System.IntPtr OS, global::System.IntPtr Diagnostic, bool ShowColors);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm9SourceMgr17PrintIncludeStackENS_5SMLocERNS_11raw_ostreamE")]
                internal static extern void PrintIncludeStack_0(global::System.IntPtr instance, llvm.SMLoc.Internal IncludeLoc, global::System.IntPtr OS);
            }

            public enum DiagKind : uint
            {
                DK_Error = 0,
                DK_Warning = 1,
                DK_Note = 2
            }

            /// <summary>
            /// <para>Clients that want to handle their own diagnostics in a custom
            /// way can register a function pointer+context as a diagnostic handler. It
            /// gets called each time PrintMessage is invoked.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Clients that want to handle their own diagnostics in a
            /// custom way can</para>
            /// <para>  /// register a function pointer+context as a diagnostic
            /// handler.</para>
            /// <para>  /// It gets called each time PrintMessage is
            /// invoked.</para>
            /// </remarks>
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            public unsafe delegate void DiagHandlerTy(global::System.IntPtr _0, global::System.IntPtr Context);

            internal unsafe partial class SrcBuffer
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct Internal
                {
                    [FieldOffset(8)]
                    public llvm.SMLoc.Internal IncludeLoc;
                }
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SourceMgr> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SourceMgr>();

            private readonly bool __ownsNativeInstance;

            public static SourceMgr __CreateInstance(global::System.IntPtr native)
            {
                return new SourceMgr((SourceMgr.Internal*) native);
            }

            public static SourceMgr __CreateInstance(SourceMgr.Internal native)
            {
                return new SourceMgr(native);
            }

            private static SourceMgr.Internal* __CopyValue(SourceMgr.Internal native)
            {
                var ret = (SourceMgr.Internal*) Marshal.AllocHGlobal(72);
                *ret = native;
                return ret;
            }

            private SourceMgr(SourceMgr.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SourceMgr(SourceMgr.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public SourceMgr()
            {
                __Instance = Marshal.AllocHGlobal(72);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_1(__Instance);
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
                llvm.SourceMgr __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>Specify a diagnostic handler to be invoked every time
            /// PrintMessage is called. Ctx is passed into the handler when it is
            /// invoked.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Specify a diagnostic handler to be invoked every time
            /// PrintMessage is</para>
            /// <para>  /// called. \p Ctx is passed into the handler when it is
            /// invoked.</para>
            /// </remarks>
            public void setDiagHandler(llvm.SourceMgr.DiagHandlerTy DH, global::System.IntPtr Ctx)
            {
                var arg0 = DH == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(DH);
                var arg1 = Ctx;
                Internal.setDiagHandler_0(__Instance, arg0, arg1);
            }

            public llvm.SourceMgr.DiagHandlerTy getDiagHandler()
            {
                var __ret = Internal.getDiagHandler_0(__Instance);
                var __ptr0 = __ret;
                return (llvm.SourceMgr.DiagHandlerTy)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(llvm.SourceMgr.DiagHandlerTy));
            }

            public global::System.IntPtr getDiagContext()
            {
                var __ret = Internal.getDiagContext_0(__Instance);
                return __ret;
            }

            public llvm.MemoryBuffer getMemoryBuffer(uint i)
            {
                var __ret = Internal.getMemoryBuffer_0(__Instance, i);
                llvm.MemoryBuffer __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (llvm.MemoryBuffer.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (llvm.MemoryBuffer) llvm.MemoryBuffer.NativeToManagedMap[__ret];
                else llvm.MemoryBuffer.NativeToManagedMap[__ret] = __result0 = (llvm.MemoryBuffer) llvm.MemoryBuffer.__CreateInstance(__ret);
                return __result0;
            }

            public uint getNumBuffers()
            {
                var __ret = Internal.getNumBuffers_0(__Instance);
                return __ret;
            }

            public uint getMainFileID()
            {
                var __ret = Internal.getMainFileID_0(__Instance);
                return __ret;
            }

            public llvm.SMLoc getParentIncludeLoc(uint i)
            {
                var __ret = Internal.getParentIncludeLoc_0(__Instance, i);
                return llvm.SMLoc.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>Return the ID of the buffer containing the specified
            /// location.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Return the ID of the buffer containing the specified
            /// location.</para>
            /// <para>  ///</para>
            /// <para>  /// 0 is returned if the buffer is not found.</para>
            /// </remarks>
            public uint FindBufferContainingLoc(llvm.SMLoc Loc)
            {
                var arg0 = ReferenceEquals(Loc, null) ? new llvm.SMLoc.Internal() : *(llvm.SMLoc.Internal*) (Loc.__Instance);
                var __ret = Internal.FindBufferContainingLoc_0(__Instance, arg0);
                return __ret;
            }

            /// <summary>
            /// <para>Find the line number for the specified location in the specified
            /// file. This is not a fast method.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Find the line number for the specified location in the
            /// specified file.</para>
            /// <para>  /// This is not a fast method.</para>
            /// </remarks>
            public uint FindLineNumber(llvm.SMLoc Loc, uint BufferID)
            {
                var arg0 = ReferenceEquals(Loc, null) ? new llvm.SMLoc.Internal() : *(llvm.SMLoc.Internal*) (Loc.__Instance);
                var __ret = Internal.FindLineNumber_0(__Instance, arg0, BufferID);
                return __ret;
            }

            /// <summary>
            /// <para>Emits a manually-constructed diagnostic to the given output
            /// stream.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Emits a manually-constructed diagnostic to the given output
            /// stream.</para>
            /// <para>  ///</para>
            /// <para>  /// \param ShowColors Display colored messages if output is a
            /// terminal and</para>
            /// <para>  /// the default error handler is used.</para>
            /// </remarks>
            public void PrintMessage(llvm.raw_ostream OS, llvm.SMDiagnostic Diagnostic, bool ShowColors)
            {
                var arg0 = ReferenceEquals(OS, null) ? global::System.IntPtr.Zero : OS.__Instance;
                var arg1 = ReferenceEquals(Diagnostic, null) ? global::System.IntPtr.Zero : Diagnostic.__Instance;
                Internal.PrintMessage_2(__Instance, arg0, arg1, ShowColors);
            }

            /// <summary>
            /// <para>Prints the names of included files and the line of the file they
            /// were included from. A diagnostic handler can use this before printing its
            /// custom formatted message.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Prints the names of included files and the line of the file
            /// they were</para>
            /// <para>  /// included from. A diagnostic handler can use this before
            /// printing its</para>
            /// <para>  /// custom formatted message.</para>
            /// <para>  ///</para>
            /// <para>  /// \param IncludeLoc The location of the include.</para>
            /// <para>  /// \param OS the raw_ostream to print on.</para>
            /// </remarks>
            public void PrintIncludeStack(llvm.SMLoc IncludeLoc, llvm.raw_ostream OS)
            {
                var arg0 = ReferenceEquals(IncludeLoc, null) ? new llvm.SMLoc.Internal() : *(llvm.SMLoc.Internal*) (IncludeLoc.__Instance);
                var arg1 = ReferenceEquals(OS, null) ? global::System.IntPtr.Zero : OS.__Instance;
                Internal.PrintIncludeStack_0(__Instance, arg0, arg1);
            }
        }

        /// <summary>
        /// <para>Represents a single fixit, a replacement of one range of text
        /// with another.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// Represents a single fixit, a replacement of one range of text
        /// with another.</para>
        /// </remarks>
        public unsafe partial class SMFixIt : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 40)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public llvm.SMRange.Internal Range;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm7SMFixItC2ENS_5SMLocERKNS_5TwineE")]
                internal static extern void ctor_0(global::System.IntPtr instance, llvm.SMLoc.Internal Loc, global::System.IntPtr Insertion);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm7SMFixItC2ENS_7SMRangeERKNS_5TwineE")]
                internal static extern void ctor_1(global::System.IntPtr instance, llvm.SMRange.Internal R, global::System.IntPtr Replacement);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm7SMFixItC2ERKS0_")]
                internal static extern void cctor_3(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm7SMFixItD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm7SMFixIt7getTextEv")]
                internal static extern llvm.StringRef.Internal getText_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm7SMFixIt8getRangeEv")]
                internal static extern llvm.SMRange.Internal getRange_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm7SMFixItltERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorLess_0(global::System.IntPtr instance, global::System.IntPtr Other);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SMFixIt> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SMFixIt>();

            private readonly bool __ownsNativeInstance;

            public static SMFixIt __CreateInstance(global::System.IntPtr native)
            {
                return new SMFixIt((SMFixIt.Internal*) native);
            }

            public static SMFixIt __CreateInstance(SMFixIt.Internal native)
            {
                return new SMFixIt(native);
            }

            private static SMFixIt.Internal* __CopyValue(SMFixIt.Internal native)
            {
                var ret = (SMFixIt.Internal*) Marshal.AllocHGlobal(40);
                *ret = native;
                return ret;
            }

            private SMFixIt(SMFixIt.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SMFixIt(SMFixIt.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public SMFixIt(llvm.SMLoc Loc, llvm.Twine Insertion)
            {
                __Instance = Marshal.AllocHGlobal(40);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg0 = ReferenceEquals(Loc, null) ? new llvm.SMLoc.Internal() : *(llvm.SMLoc.Internal*) (Loc.__Instance);
                var arg1 = ReferenceEquals(Insertion, null) ? global::System.IntPtr.Zero : Insertion.__Instance;
                Internal.ctor_0(__Instance, arg0, arg1);
            }

            public SMFixIt(llvm.SMRange R, llvm.Twine Replacement)
            {
                __Instance = Marshal.AllocHGlobal(40);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg0 = ReferenceEquals(R, null) ? new llvm.SMRange.Internal() : *(llvm.SMRange.Internal*) (R.__Instance);
                var arg1 = ReferenceEquals(Replacement, null) ? global::System.IntPtr.Zero : Replacement.__Instance;
                Internal.ctor_1(__Instance, arg0, arg1);
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
                llvm.SMFixIt __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public llvm.StringRef getText()
            {
                var __ret = Internal.getText_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public llvm.SMRange getRange()
            {
                var __ret = Internal.getRange_0(__Instance);
                return llvm.SMRange.__CreateInstance(__ret);
            }

            public static bool operator >(llvm.SMFixIt __op, llvm.SMFixIt Other)
            {
                return !(__op < Other);
            }

            public static bool operator <(llvm.SMFixIt __op, llvm.SMFixIt Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorLess_0(arg0, arg1);
                return __ret;
            }
        }

        /// <summary>
        /// <para>Instances of this class encapsulate one diagnostic report,
        /// allowing printing to a raw_ostream as a caret diagnostic.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// Instances of this class encapsulate one diagnostic report,
        /// allowing</para>
        /// <para>/// printing to a raw_ostream as a caret diagnostic.</para>
        /// </remarks>
        public unsafe partial class SMDiagnostic : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 312)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr SM;

                [FieldOffset(8)]
                public llvm.SMLoc.Internal Loc;

                [FieldOffset(40)]
                public int LineNo;

                [FieldOffset(44)]
                public int ColumnNo;

                [FieldOffset(48)]
                public llvm.SourceMgr.DiagKind Kind;

                [FieldOffset(128)]
                internal llvm.SmallVector.Internal FixIts;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12SMDiagnosticC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12SMDiagnosticC2ENS_9StringRefENS_9SourceMgr8DiagKindES1_")]
                internal static extern void ctor_1(global::System.IntPtr instance, llvm.StringRef.Internal filename, llvm.SourceMgr.DiagKind Knd, llvm.StringRef.Internal Msg);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12SMDiagnosticC2ERKS0_")]
                internal static extern void cctor_4(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12SMDiagnosticD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic12getSourceMgrEv")]
                internal static extern global::System.IntPtr getSourceMgr_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic6getLocEv")]
                internal static extern llvm.SMLoc.Internal getLoc_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic11getFilenameEv")]
                internal static extern llvm.StringRef.Internal getFilename_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic9getLineNoEv")]
                internal static extern int getLineNo_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic11getColumnNoEv")]
                internal static extern int getColumnNo_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic7getKindEv")]
                internal static extern llvm.SourceMgr.DiagKind getKind_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic10getMessageEv")]
                internal static extern llvm.StringRef.Internal getMessage_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic15getLineContentsEv")]
                internal static extern llvm.StringRef.Internal getLineContents_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12SMDiagnostic8addFixItERKNS_7SMFixItE")]
                internal static extern void addFixIt_0(global::System.IntPtr instance, global::System.IntPtr Hint);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12SMDiagnostic5printEPKcRNS_11raw_ostreamEb")]
                internal static extern void print_0(global::System.IntPtr instance, global::System.IntPtr ProgName, global::System.IntPtr S, bool ShowColors);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SMDiagnostic> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SMDiagnostic>();

            private readonly bool __ownsNativeInstance;

            public static SMDiagnostic __CreateInstance(global::System.IntPtr native)
            {
                return new SMDiagnostic((SMDiagnostic.Internal*) native);
            }

            public static SMDiagnostic __CreateInstance(SMDiagnostic.Internal native)
            {
                return new SMDiagnostic(native);
            }

            private static SMDiagnostic.Internal* __CopyValue(SMDiagnostic.Internal native)
            {
                var ret = (SMDiagnostic.Internal*) Marshal.AllocHGlobal(312);
                *ret = native;
                return ret;
            }

            private SMDiagnostic(SMDiagnostic.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SMDiagnostic(SMDiagnostic.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public SMDiagnostic()
            {
                __Instance = Marshal.AllocHGlobal(312);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance);
            }

            public SMDiagnostic(llvm.StringRef filename, llvm.SourceMgr.DiagKind Knd, llvm.StringRef Msg)
            {
                __Instance = Marshal.AllocHGlobal(312);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg0 = ReferenceEquals(filename, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (filename.__Instance);
                var arg1 = Knd;
                var arg2 = ReferenceEquals(Msg, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Msg.__Instance);
                Internal.ctor_1(__Instance, arg0, arg1, arg2);
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
                llvm.SMDiagnostic __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public llvm.SourceMgr getSourceMgr()
            {
                var __ret = Internal.getSourceMgr_0(__Instance);
                llvm.SourceMgr __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (llvm.SourceMgr.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (llvm.SourceMgr) llvm.SourceMgr.NativeToManagedMap[__ret];
                else __result0 = llvm.SourceMgr.__CreateInstance(__ret);
                return __result0;
            }

            public llvm.SMLoc getLoc()
            {
                var __ret = Internal.getLoc_0(__Instance);
                return llvm.SMLoc.__CreateInstance(__ret);
            }

            public llvm.StringRef getFilename()
            {
                var __ret = Internal.getFilename_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public int getLineNo()
            {
                var __ret = Internal.getLineNo_0(__Instance);
                return __ret;
            }

            public int getColumnNo()
            {
                var __ret = Internal.getColumnNo_0(__Instance);
                return __ret;
            }

            public llvm.SourceMgr.DiagKind getKind()
            {
                var __ret = Internal.getKind_0(__Instance);
                return __ret;
            }

            public llvm.StringRef getMessage()
            {
                var __ret = Internal.getMessage_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public llvm.StringRef getLineContents()
            {
                var __ret = Internal.getLineContents_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public void addFixIt(llvm.SMFixIt Hint)
            {
                var arg0 = ReferenceEquals(Hint, null) ? global::System.IntPtr.Zero : Hint.__Instance;
                Internal.addFixIt_0(__Instance, arg0);
            }

            public void print(string ProgName, llvm.raw_ostream S, bool ShowColors)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(ProgName);
                var arg1 = ReferenceEquals(S, null) ? global::System.IntPtr.Zero : S.__Instance;
                Internal.print_0(__Instance, arg0, arg1, ShowColors);
                Marshal.FreeHGlobal(arg0);
            }
        }
    }
}
