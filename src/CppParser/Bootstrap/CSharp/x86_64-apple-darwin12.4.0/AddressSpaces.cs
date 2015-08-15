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
        namespace LangAS
        {
            /// <summary>
            /// <para>Defines the set of possible language-specific address
            /// spaces.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// \brief Defines the set of possible language-specific address
            /// spaces.</para>
            /// <para>///</para>
            /// <para>/// This uses a high starting offset so as not to conflict with
            /// any address</para>
            /// <para>/// space used by a target.</para>
            /// </remarks>
            public enum ID : uint
            {
                Offset = 0xffff00,
                opencl_global = 16776960,
                opencl_local = 16776961,
                opencl_constant = 16776962,
                opencl_generic = 16776963,
                cuda_device = 16776964,
                cuda_constant = 16776965,
                cuda_shared = 16776966,
                Last = 16776967,
                Count = 7
            }

            /// <summary>
            /// <para>The type of a lookup table which maps from language-specific
            /// address spaces to target-specific ones.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// The type of a lookup table which maps from
            /// language-specific address spaces</para>
            /// <para>/// to target-specific ones.</para>
            /// </remarks>
        }
    }
}
