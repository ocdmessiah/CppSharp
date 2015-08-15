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
        /// <para>StringMapEntry - This is used to represent one value that is
        /// inserted into a StringMap. It contains the Value itself and the key: the
        /// string length and data.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// StringMapEntry - This is used to represent one value that is
        /// inserted into</para>
        /// <para>/// a StringMap.  It contains the Value itself and the key: the
        /// string length</para>
        /// <para>/// and data.</para>
        /// </remarks>
        public unsafe partial class StringMapEntry
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public new partial struct Internal
            {
                [FieldOffset(0)]
                public uint StrLen;
            }
        }

        /// <summary>
        /// <para>StringMap - This is an unconventional map that is specialized for
        /// handling keys that are &quot;strings&quot;, which are basically ranges of
        /// bytes. This does some funky memory allocation and hashing things to make it
        /// extremely efficient, storing the string data *after* the value in the
        /// map.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// StringMap - This is an unconventional map that is specialized
        /// for handling</para>
        /// <para>/// keys that are &quot;strings&quot;, which are basically ranges
        /// of bytes. This does some</para>
        /// <para>/// funky memory allocation and hashing things to make it
        /// extremely efficient,</para>
        /// <para>/// storing the string data *after* the value in the map.</para>
        /// </remarks>
        public unsafe partial class StringMap
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public new partial struct Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr TheTable;

                [FieldOffset(8)]
                public uint NumBuckets;

                [FieldOffset(12)]
                public uint NumItems;

                [FieldOffset(16)]
                public uint NumTombstones;

                [FieldOffset(20)]
                public uint ItemSize;
            }
        }

        /// <summary>
        /// <para>StringMapEntryBase - Shared base class of StringMapEntry
        /// instances.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// StringMapEntryBase - Shared base class of StringMapEntry
        /// instances.</para>
        /// </remarks>
        public unsafe partial class StringMapEntryBase : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public uint StrLen;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm18StringMapEntryBaseC2Ej")]
                internal static extern void ctor_0(global::System.IntPtr instance, uint Len);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm18StringMapEntryBaseC2ERKS0_")]
                internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm18StringMapEntryBase12getKeyLengthEv")]
                internal static extern uint getKeyLength_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, StringMapEntryBase> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, StringMapEntryBase>();

            private readonly bool __ownsNativeInstance;

            public static StringMapEntryBase __CreateInstance(global::System.IntPtr native)
            {
                return new StringMapEntryBase((StringMapEntryBase.Internal*) native);
            }

            public static StringMapEntryBase __CreateInstance(StringMapEntryBase.Internal native)
            {
                return new StringMapEntryBase(native);
            }

            private static StringMapEntryBase.Internal* __CopyValue(StringMapEntryBase.Internal native)
            {
                var ret = (StringMapEntryBase.Internal*) Marshal.AllocHGlobal(4);
                *ret = native;
                return ret;
            }

            private StringMapEntryBase(StringMapEntryBase.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected StringMapEntryBase(StringMapEntryBase.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public StringMapEntryBase(uint Len)
            {
                __Instance = Marshal.AllocHGlobal(4);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance, Len);
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
                llvm.StringMapEntryBase __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public uint getKeyLength()
            {
                var __ret = Internal.getKeyLength_0(__Instance);
                return __ret;
            }
        }

        /// <summary>
        /// <para>StringMapImpl - This is the base class of StringMap that is
        /// shared among all of its instantiations.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// StringMapImpl - This is the base class of StringMap that is
        /// shared among</para>
        /// <para>/// all of its instantiations.</para>
        /// </remarks>
        public unsafe partial class StringMapImpl : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr TheTable;

                [FieldOffset(8)]
                public uint NumBuckets;

                [FieldOffset(12)]
                public uint NumItems;

                [FieldOffset(16)]
                public uint NumTombstones;

                [FieldOffset(20)]
                public uint ItemSize;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImplC2Ej")]
                internal static extern void ctor_0(global::System.IntPtr instance, uint itemSize);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImplC2Ejj")]
                internal static extern void ctor_2(global::System.IntPtr instance, uint InitSize, uint ItemSize);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImplC2ERKS0_")]
                internal static extern void cctor_3(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl11RehashTableEj")]
                internal static extern uint RehashTable_0(global::System.IntPtr instance, uint BucketNo);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl15LookupBucketForENS_9StringRefE")]
                internal static extern uint LookupBucketFor_0(global::System.IntPtr instance, llvm.StringRef.Internal Key);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm13StringMapImpl7FindKeyENS_9StringRefE")]
                internal static extern int FindKey_0(global::System.IntPtr instance, llvm.StringRef.Internal Key);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl9RemoveKeyEPNS_18StringMapEntryBaseE")]
                internal static extern void RemoveKey_0(global::System.IntPtr instance, global::System.IntPtr V);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl9RemoveKeyENS_9StringRefE")]
                internal static extern global::System.IntPtr RemoveKey_1(global::System.IntPtr instance, llvm.StringRef.Internal Key);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl15getTombstoneValEv")]
                internal static extern global::System.IntPtr getTombstoneVal_0();

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm13StringMapImpl13getNumBucketsEv")]
                internal static extern uint getNumBuckets_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm13StringMapImpl11getNumItemsEv")]
                internal static extern uint getNumItems_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm13StringMapImpl5emptyEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool empty_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm13StringMapImpl4sizeEv")]
                internal static extern uint size_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm13StringMapImpl4swapERS0_")]
                internal static extern void swap_0(global::System.IntPtr instance, global::System.IntPtr Other);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, StringMapImpl> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, StringMapImpl>();

            private readonly bool __ownsNativeInstance;

            public static StringMapImpl __CreateInstance(global::System.IntPtr native)
            {
                return new StringMapImpl((StringMapImpl.Internal*) native);
            }

            public static StringMapImpl __CreateInstance(StringMapImpl.Internal native)
            {
                return new StringMapImpl(native);
            }

            private static StringMapImpl.Internal* __CopyValue(StringMapImpl.Internal native)
            {
                var ret = (StringMapImpl.Internal*) Marshal.AllocHGlobal(24);
                *ret = native;
                return ret;
            }

            private StringMapImpl(StringMapImpl.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected StringMapImpl(StringMapImpl.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            protected StringMapImpl(uint itemSize)
            {
                __Instance = Marshal.AllocHGlobal(24);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance, itemSize);
            }

            protected StringMapImpl(uint InitSize, uint ItemSize)
            {
                __Instance = Marshal.AllocHGlobal(24);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_2(__Instance, InitSize, ItemSize);
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
                llvm.StringMapImpl __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            protected uint RehashTable(uint BucketNo)
            {
                var __ret = Internal.RehashTable_0(__Instance, BucketNo);
                return __ret;
            }

            /// <summary>
            /// <para>LookupBucketFor - Look up the bucket that the specified string
            /// should end up in. If it already exists as a key in the map, the Item
            /// pointer for the specified bucket will be non-null. Otherwise, it will be
            /// null. In either case, the FullHashValue field of the bucket will be set to
            /// the hash value of the string.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// LookupBucketFor - Look up the bucket that the specified
            /// string should end</para>
            /// <para>  /// up in.  If it already exists as a key in the map, the Item
            /// pointer for the</para>
            /// <para>  /// specified bucket will be non-null.  Otherwise, it will be
            /// null.  In either</para>
            /// <para>  /// case, the FullHashValue field of the bucket will be set to
            /// the hash value</para>
            /// <para>  /// of the string.</para>
            /// </remarks>
            protected uint LookupBucketFor(llvm.StringRef Key)
            {
                var arg0 = ReferenceEquals(Key, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Key.__Instance);
                var __ret = Internal.LookupBucketFor_0(__Instance, arg0);
                return __ret;
            }

            /// <summary>
            /// <para>FindKey - Look up the bucket that contains the specified key. If
            /// it exists in the map, return the bucket number of the key. Otherwise return
            /// -1. This does not modify the map.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// FindKey - Look up the bucket that contains the specified key.
            /// If it exists</para>
            /// <para>  /// in the map, return the bucket number of the key.  Otherwise
            /// return -1.</para>
            /// <para>  /// This does not modify the map.</para>
            /// </remarks>
            protected int FindKey(llvm.StringRef Key)
            {
                var arg0 = ReferenceEquals(Key, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Key.__Instance);
                var __ret = Internal.FindKey_0(__Instance, arg0);
                return __ret;
            }

            /// <summary>
            /// <para>RemoveKey - Remove the specified StringMapEntry from the table,
            /// but do not delete it. This aborts if the value isn't in the table.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// RemoveKey - Remove the specified StringMapEntry from the
            /// table, but do not</para>
            /// <para>  /// delete it.  This aborts if the value isn't in the
            /// table.</para>
            /// </remarks>
            protected void RemoveKey(llvm.StringMapEntryBase V)
            {
                var arg0 = ReferenceEquals(V, null) ? global::System.IntPtr.Zero : V.__Instance;
                Internal.RemoveKey_0(__Instance, arg0);
            }

            /// <summary>
            /// <para>RemoveKey - Remove the StringMapEntry for the specified key from
            /// the table, returning it. If the key is not in the table, this returns
            /// null.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// RemoveKey - Remove the StringMapEntry for the specified key
            /// from the</para>
            /// <para>  /// table, returning it.  If the key is not in the table, this
            /// returns null.</para>
            /// </remarks>
            protected llvm.StringMapEntryBase RemoveKey(llvm.StringRef Key)
            {
                var arg0 = ReferenceEquals(Key, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Key.__Instance);
                var __ret = Internal.RemoveKey_1(__Instance, arg0);
                llvm.StringMapEntryBase __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (llvm.StringMapEntryBase.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (llvm.StringMapEntryBase) llvm.StringMapEntryBase.NativeToManagedMap[__ret];
                else __result0 = llvm.StringMapEntryBase.__CreateInstance(__ret);
                return __result0;
            }

            public uint getNumBuckets()
            {
                var __ret = Internal.getNumBuckets_0(__Instance);
                return __ret;
            }

            public uint getNumItems()
            {
                var __ret = Internal.getNumItems_0(__Instance);
                return __ret;
            }

            public bool empty()
            {
                var __ret = Internal.empty_0(__Instance);
                return __ret;
            }

            public uint size()
            {
                var __ret = Internal.size_0(__Instance);
                return __ret;
            }

            public void swap(llvm.StringMapImpl Other)
            {
                var arg0 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                Internal.swap_0(__Instance, arg0);
            }

            public static llvm.StringMapEntryBase getTombstoneVal()
            {
                var __ret = Internal.getTombstoneVal_0();
                llvm.StringMapEntryBase __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (llvm.StringMapEntryBase.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (llvm.StringMapEntryBase) llvm.StringMapEntryBase.NativeToManagedMap[__ret];
                else __result0 = llvm.StringMapEntryBase.__CreateInstance(__ret);
                return __result0;
            }

            protected llvm.StringMapEntryBase TheTable
            {
                get
                {
                    llvm.StringMapEntryBase __result0;
                    if (((Internal*) __Instance)->TheTable == IntPtr.Zero) __result0 = null;
                    else if (llvm.StringMapEntryBase.NativeToManagedMap.ContainsKey(((Internal*) __Instance)->TheTable))
                        __result0 = (llvm.StringMapEntryBase) llvm.StringMapEntryBase.NativeToManagedMap[((Internal*) __Instance)->TheTable];
                    else __result0 = llvm.StringMapEntryBase.__CreateInstance(((Internal*) __Instance)->TheTable);
                    return __result0;
                }

                set
                {
                    ((Internal*) __Instance)->TheTable = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
                }
            }

            protected uint NumBuckets
            {
                get
                {
                    return ((Internal*) __Instance)->NumBuckets;
                }

                set
                {
                    ((Internal*) __Instance)->NumBuckets = value;
                }
            }

            protected uint NumItems
            {
                get
                {
                    return ((Internal*) __Instance)->NumItems;
                }

                set
                {
                    ((Internal*) __Instance)->NumItems = value;
                }
            }

            protected uint NumTombstones
            {
                get
                {
                    return ((Internal*) __Instance)->NumTombstones;
                }

                set
                {
                    ((Internal*) __Instance)->NumTombstones = value;
                }
            }

            protected uint ItemSize
            {
                get
                {
                    return ((Internal*) __Instance)->ItemSize;
                }

                set
                {
                    ((Internal*) __Instance)->ItemSize = value;
                }
            }
        }
    }
}
