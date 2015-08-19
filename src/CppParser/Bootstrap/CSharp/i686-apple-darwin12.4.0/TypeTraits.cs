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
        /// <para>Names for traits that operate specifically on types.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief Names for traits that operate specifically on
        /// types.</para>
        /// </remarks>
        public enum TypeTrait : uint
        {
            UTT_HasNothrowAssign = 0,
            UTT_HasNothrowMoveAssign = 1,
            UTT_HasNothrowCopy = 2,
            UTT_HasNothrowConstructor = 3,
            UTT_HasTrivialAssign = 4,
            UTT_HasTrivialMoveAssign = 5,
            UTT_HasTrivialCopy = 6,
            UTT_HasTrivialDefaultConstructor = 7,
            UTT_HasTrivialMoveConstructor = 8,
            UTT_HasTrivialDestructor = 9,
            UTT_HasVirtualDestructor = 10,
            UTT_IsAbstract = 11,
            UTT_IsArithmetic = 12,
            UTT_IsArray = 13,
            UTT_IsClass = 14,
            UTT_IsCompleteType = 15,
            UTT_IsCompound = 16,
            UTT_IsConst = 17,
            UTT_IsDestructible = 18,
            UTT_IsEmpty = 19,
            UTT_IsEnum = 20,
            UTT_IsFinal = 21,
            UTT_IsFloatingPoint = 22,
            UTT_IsFunction = 23,
            UTT_IsFundamental = 24,
            UTT_IsIntegral = 25,
            UTT_IsInterfaceClass = 26,
            UTT_IsLiteral = 27,
            UTT_IsLvalueReference = 28,
            UTT_IsMemberFunctionPointer = 29,
            UTT_IsMemberObjectPointer = 30,
            UTT_IsMemberPointer = 31,
            UTT_IsNothrowDestructible = 32,
            UTT_IsObject = 33,
            UTT_IsPOD = 34,
            UTT_IsPointer = 35,
            UTT_IsPolymorphic = 36,
            UTT_IsReference = 37,
            UTT_IsRvalueReference = 38,
            UTT_IsScalar = 39,
            UTT_IsSealed = 40,
            UTT_IsSigned = 41,
            UTT_IsStandardLayout = 42,
            UTT_IsTrivial = 43,
            UTT_IsTriviallyCopyable = 44,
            UTT_IsUnion = 45,
            UTT_IsUnsigned = 46,
            UTT_IsVoid = 47,
            UTT_IsVolatile = 48,
            UTT_Last = 48,
            BTT_IsBaseOf = 49,
            BTT_IsConvertible = 50,
            BTT_IsConvertibleTo = 51,
            BTT_IsSame = 52,
            BTT_TypeCompatible = 53,
            BTT_IsNothrowAssignable = 54,
            BTT_IsTriviallyAssignable = 55,
            BTT_Last = 55,
            TT_IsConstructible = 56,
            TT_IsNothrowConstructible = 57,
            TT_IsTriviallyConstructible = 58
        }

        /// <summary>
        /// <para>Names for the array type traits.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief Names for the array type traits.</para>
        /// </remarks>
        public enum ArrayTypeTrait : uint
        {
            ATT_ArrayRank = 0,
            ATT_ArrayExtent = 1
        }

        /// <summary>
        /// <para>Names for the &quot;expression or type&quot; traits.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief Names for the &quot;expression or type&quot;
        /// traits.</para>
        /// </remarks>
        public enum UnaryExprOrTypeTrait : uint
        {
            UETT_SizeOf = 0,
            UETT_AlignOf = 1,
            UETT_VecStep = 2
        }
    }
}