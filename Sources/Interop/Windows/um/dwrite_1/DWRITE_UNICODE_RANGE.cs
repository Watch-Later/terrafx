// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Range of Unicode codepoints.</summary>
    public /* blittable */ struct DWRITE_UNICODE_RANGE
    {
        #region Fields
        /// <summary>The first codepoint in the Unicode range.</summary>>
        public UINT32 first;

        /// <summary>The last codepoint in the Unicode range.</summary>>
        public UINT32 last;
        #endregion
    }
}