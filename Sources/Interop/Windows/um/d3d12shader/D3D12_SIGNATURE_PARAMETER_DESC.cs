// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public /* blittable */ struct D3D12_SIGNATURE_PARAMETER_DESC
    {
        #region Fields
        public LPCSTR SemanticName;

        public UINT SemanticIndex;

        public UINT Register;

        public D3D_NAME SystemValueType;

        public D3D_REGISTER_COMPONENT_TYPE ComponentType;

        public BYTE Mask;

        public BYTE ReadWriteMask;

        public UINT Stream;

        public D3D_MIN_PRECISION MinPrecision;
        #endregion
    }
}