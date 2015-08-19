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
        /// <summary>
        /// <para>CharUnits - This is an opaque type for sizes expressed in
        /// character units. Instances of this type represent a quantity as a multiple
        /// of the size of the standard C type, char, on the target architecture. As an
        /// opaque type, CharUnits protects you from accidentally combining operations
        /// on quantities in bit units and character units.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// CharUnits - This is an opaque type for sizes expressed in
        /// character units.</para>
        /// <para>  /// Instances of this type represent a quantity as a multiple
        /// of the size</para>
        /// <para>  /// of the standard C type, char, on the target architecture.
        /// As an opaque</para>
        /// <para>  /// type, CharUnits protects you from accidentally combining
        /// operations on</para>
        /// <para>  /// quantities in bit units and character units.</para>
        /// <para>  ///</para>
        /// <para>  /// In both C and C++, an object of type 'char', 'signed char',
        /// or 'unsigned</para>
        /// <para>  /// char' occupies exactly one byte, so 'character unit' and
        /// 'byte' refer to</para>
        /// <para>  /// the same quantity of storage. However, we use the term
        /// 'character unit'</para>
        /// <para>  /// rather than 'byte' to avoid an implication that a character
        /// unit is</para>
        /// <para>  /// exactly 8 bits.</para>
        /// <para>  ///</para>
        /// <para>  /// For portability, never assume that a target character is 8
        /// bits wide. Use</para>
        /// <para>  /// CharUnit values wherever you calculate sizes, offsets, or
        /// alignments</para>
        /// <para>  /// in character units.</para>
        /// </remarks>
        public unsafe partial class CharUnits : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public long Quantity;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnitsC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnitsC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnits4ZeroEv")]
                internal static extern clang.CharUnits.Internal Zero_0();

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnits3OneEv")]
                internal static extern clang.CharUnits.Internal One_0();

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnits12fromQuantityEx")]
                internal static extern clang.CharUnits.Internal fromQuantity_0(long Quantity);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnitsppEv")]
                internal static extern global::System.IntPtr OperatorPlusPlus_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnitsmmEv")]
                internal static extern global::System.IntPtr OperatorMinusMinus_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitseqERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsneERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsltERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorLess_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsleERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorLessEqual_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsgtERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorGreater_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsgeERKS0_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool OperatorGreaterEqual_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits6isZeroEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isZero_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits5isOneEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isOne_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits10isPositiveEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isPositive_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits10isNegativeEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isNegative_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits12isPowerOfTwoEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isPowerOfTwo_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsmlEx")]
                internal static extern clang.CharUnits.Internal OperatorStar_0(global::System.IntPtr instance, long N);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsdvEx")]
                internal static extern clang.CharUnits.Internal OperatorSlash_0(global::System.IntPtr instance, long N);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsdvERKS0_")]
                internal static extern long OperatorSlash_1(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsrmEx")]
                internal static extern clang.CharUnits.Internal OperatorPercent_0(global::System.IntPtr instance, long N);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsrmERKS0_")]
                internal static extern long OperatorPercent_1(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsplERKS0_")]
                internal static extern clang.CharUnits.Internal OperatorPlus_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsmiERKS0_")]
                internal static extern clang.CharUnits.Internal OperatorMinus_0(global::System.IntPtr instance, global::System.IntPtr Other);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnitsngEv")]
                internal static extern clang.CharUnits.Internal OperatorMinus_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits11getQuantityEv")]
                internal static extern long getQuantity_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang9CharUnits18RoundUpToAlignmentERKS0_")]
                internal static extern clang.CharUnits.Internal RoundUpToAlignment_0(global::System.IntPtr instance, global::System.IntPtr Align);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang9CharUnits17alignmentAtOffsetES0_")]
                internal static extern clang.CharUnits.Internal alignmentAtOffset_0(global::System.IntPtr instance, clang.CharUnits.Internal offset);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZmlxRKN5clang9CharUnitsE")]
                internal static extern clang.CharUnits.Internal OperatorStar_1(long Scale, global::System.IntPtr CU);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CharUnits> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CharUnits>();

            private readonly bool __ownsNativeInstance;

            public static CharUnits __CreateInstance(global::System.IntPtr native)
            {
                return new CharUnits((CharUnits.Internal*) native);
            }

            public static CharUnits __CreateInstance(CharUnits.Internal native)
            {
                return new CharUnits(native);
            }

            private static CharUnits.Internal* __CopyValue(CharUnits.Internal native)
            {
                var ret = (CharUnits.Internal*) Marshal.AllocHGlobal(8);
                *ret = native;
                return ret;
            }

            private CharUnits(CharUnits.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected CharUnits(CharUnits.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            /// <summary>
            /// <para>CharUnits - A default constructor.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// CharUnits - A default constructor.</para>
            /// </remarks>
            public CharUnits()
            {
                __Instance = Marshal.AllocHGlobal(8);
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
                clang.CharUnits __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public static clang.CharUnits operator ++(clang.CharUnits __op)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var __ret = Internal.OperatorPlusPlus_0(arg0);
                clang.CharUnits __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (clang.CharUnits.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (clang.CharUnits) clang.CharUnits.NativeToManagedMap[__ret];
                else __result0 = clang.CharUnits.__CreateInstance(__ret);
                return __result0;
            }

            public static clang.CharUnits operator --(clang.CharUnits __op)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var __ret = Internal.OperatorMinusMinus_0(arg0);
                clang.CharUnits __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (clang.CharUnits.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (clang.CharUnits) clang.CharUnits.NativeToManagedMap[__ret];
                else __result0 = clang.CharUnits.__CreateInstance(__ret);
                return __result0;
            }

            public static bool operator ==(clang.CharUnits __op, clang.CharUnits Other)
            {
                bool __opNull = ReferenceEquals(__op, null);
                bool OtherNull = ReferenceEquals(Other, null);
                if (__opNull || OtherNull)
                    return __opNull && OtherNull;
                var arg0 = __op.__Instance;
                var arg1 = Other.__Instance;
                var __ret = Internal.OperatorEqualEqual_0(arg0, arg1);
                return __ret;
            }

            public override bool Equals(object obj)
            {
                return this == obj as CharUnits;
            }

            public static bool operator !=(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorExclaimEqual_0(arg0, arg1);
                return __ret;
            }

            public static bool operator <(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorLess_0(arg0, arg1);
                return __ret;
            }

            public static bool operator <=(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorLessEqual_0(arg0, arg1);
                return __ret;
            }

            public static bool operator >(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorGreater_0(arg0, arg1);
                return __ret;
            }

            public static bool operator >=(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorGreaterEqual_0(arg0, arg1);
                return __ret;
            }

            /// <summary>
            /// <para>isZero - Test whether the quantity equals zero.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// isZero - Test whether the quantity equals zero.</para>
            /// </remarks>
            public bool isZero()
            {
                var __ret = Internal.isZero_0(__Instance);
                return __ret;
            }

            /// <summary>
            /// <para>isOne - Test whether the quantity equals one.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// isOne - Test whether the quantity equals one.</para>
            /// </remarks>
            public bool isOne()
            {
                var __ret = Internal.isOne_0(__Instance);
                return __ret;
            }

            /// <summary>
            /// <para>isPositive - Test whether the quantity is greater than
            /// zero.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// isPositive - Test whether the quantity is greater than
            /// zero.</para>
            /// </remarks>
            public bool isPositive()
            {
                var __ret = Internal.isPositive_0(__Instance);
                return __ret;
            }

            /// <summary>
            /// <para>isNegative - Test whether the quantity is less than zero.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// isNegative - Test whether the quantity is less than
            /// zero.</para>
            /// </remarks>
            public bool isNegative()
            {
                var __ret = Internal.isNegative_0(__Instance);
                return __ret;
            }

            /// <summary>
            /// <para>isPowerOfTwo - Test whether the quantity is a power of two. Zero
            /// is not a power of two.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// isPowerOfTwo - Test whether the quantity is a power of
            /// two.</para>
            /// <para>      /// Zero is not a power of two.</para>
            /// </remarks>
            public bool isPowerOfTwo()
            {
                var __ret = Internal.isPowerOfTwo_0(__Instance);
                return __ret;
            }

            public static clang.CharUnits operator *(clang.CharUnits __op, long N)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = N;
                var __ret = Internal.OperatorStar_0(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static clang.CharUnits operator /(clang.CharUnits __op, long N)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = N;
                var __ret = Internal.OperatorSlash_0(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static long operator /(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorSlash_1(arg0, arg1);
                return __ret;
            }

            public static clang.CharUnits operator +(clang.CharUnits __op, long N)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = N;
                var __ret = Internal.OperatorPercent_0(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static long operator +(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorPercent_1(arg0, arg1);
                return __ret;
            }

            public static clang.CharUnits operator +(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorPlus_0(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static clang.CharUnits operator -(clang.CharUnits __op, clang.CharUnits Other)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var arg1 = ReferenceEquals(Other, null) ? global::System.IntPtr.Zero : Other.__Instance;
                var __ret = Internal.OperatorMinus_0(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static clang.CharUnits operator -(clang.CharUnits __op)
            {
                var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
                var __ret = Internal.OperatorMinus_1(arg0);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>getQuantity - Get the raw integer representation of this
            /// quantity.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// getQuantity - Get the raw integer representation of this
            /// quantity.</para>
            /// </remarks>
            public long getQuantity()
            {
                var __ret = Internal.getQuantity_0(__Instance);
                return __ret;
            }

            /// <summary>
            /// <para>RoundUpToAlignment - Returns the next integer (mod 2**64) that is
            /// greater than or equal to this quantity and is a multiple of Align. Align
            /// must be non-zero.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// RoundUpToAlignment - Returns the next integer (mod 2**64)
            /// that is</para>
            /// <para>      /// greater than or equal to this quantity and is a
            /// multiple of \p Align.</para>
            /// <para>      /// Align must be non-zero.</para>
            /// </remarks>
            public clang.CharUnits RoundUpToAlignment(clang.CharUnits Align)
            {
                var arg0 = ReferenceEquals(Align, null) ? global::System.IntPtr.Zero : Align.__Instance;
                var __ret = Internal.RoundUpToAlignment_0(__Instance, arg0);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>Given that this is a non-zero alignment value, what is the
            /// alignment at the given offset?</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Given that this is a non-zero alignment value, what is
            /// the</para>
            /// <para>      /// alignment at the given offset?</para>
            /// </remarks>
            public clang.CharUnits alignmentAtOffset(clang.CharUnits offset)
            {
                var arg0 = ReferenceEquals(offset, null) ? new clang.CharUnits.Internal() : *(clang.CharUnits.Internal*) (offset.__Instance);
                var __ret = Internal.alignmentAtOffset_0(__Instance, arg0);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>Zero - Construct a CharUnits quantity of zero.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Zero - Construct a CharUnits quantity of zero.</para>
            /// </remarks>
            public static clang.CharUnits Zero()
            {
                var __ret = Internal.Zero_0();
                return clang.CharUnits.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>One - Construct a CharUnits quantity of one.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// One - Construct a CharUnits quantity of one.</para>
            /// </remarks>
            public static clang.CharUnits One()
            {
                var __ret = Internal.One_0();
                return clang.CharUnits.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>fromQuantity - Construct a CharUnits quantity from a raw integer
            /// type.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// fromQuantity - Construct a CharUnits quantity from a raw
            /// integer type.</para>
            /// </remarks>
            public static clang.CharUnits fromQuantity(long Quantity)
            {
                var arg0 = Quantity;
                var __ret = Internal.fromQuantity_0(arg0);
                return clang.CharUnits.__CreateInstance(__ret);
            }

            public static clang.CharUnits operator *(long Scale, clang.CharUnits CU)
            {
                var arg0 = Scale;
                var arg1 = ReferenceEquals(CU, null) ? global::System.IntPtr.Zero : CU.__Instance;
                var __ret = Internal.OperatorStar_1(arg0, arg1);
                return clang.CharUnits.__CreateInstance(__ret);
            }
        }
    }

    namespace llvm
    {
    }
}