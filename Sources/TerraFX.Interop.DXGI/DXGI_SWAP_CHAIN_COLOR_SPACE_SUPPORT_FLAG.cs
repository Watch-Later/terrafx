// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_4.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG
    {
        NONE = 0,

        PRESENT = 1,

        OVERLAY_PRESENT = 2
    }
}