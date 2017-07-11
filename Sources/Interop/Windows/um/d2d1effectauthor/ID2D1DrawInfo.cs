// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Interop.D2D1_PIXEL_OPTIONS;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass using pixel and vertex shaders.</summary>
    [Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
    unsafe public /* blittable */ struct ID2D1DrawInfo
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        /// <summary>Set the constant buffer for this transform's pixel shader.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetPixelShaderConstantBuffer(
            [In] ID2D1DrawInfo* This,
            [In] /* readonly */ BYTE *buffer,
            [In]UINT32 bufferCount
        );

        /// <summary>Sets the resource texture corresponding to the given shader texture index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetResourceTexture(
            [In] ID2D1DrawInfo* This,
            [In] UINT32 textureIndex,
            [In] ID2D1ResourceTexture* resourceTexture
        );

        /// <summary>Set the constant buffer for this transform's vertex shader.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetVertexShaderConstantBuffer(
            [In] ID2D1DrawInfo* This,
            [In] /* readonly */ BYTE *buffer,
            [In] UINT32 bufferCount
        );

        /// <summary>Set the shader instructions for this transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetPixelShader(
            [In] ID2D1DrawInfo* This,
            [In] REFGUID shaderId,
            [In] D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE
        );

        /// <summary>Set custom vertices for the associated transform.  A blend mode if foreground-over will be used if blendDescription is NULL.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetVertexProcessing(
            [In] ID2D1DrawInfo* This,
            [In, Optional] ID2D1VertexBuffer* vertexBuffer,
            [In] D2D1_VERTEX_OPTIONS vertexOptions,
            [In] /* readonly */ D2D1_BLEND_DESCRIPTION* blendDescription = null,
            [In] /* readonly */ D2D1_VERTEX_RANGE* vertexRange = null,
            [In] /* readonly */ GUID* vertexShader = null
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID2D1RenderInfo.Vtbl BaseVtbl;

            public SetPixelShaderConstantBuffer SetPixelShaderConstantBuffer;

            public SetResourceTexture SetResourceTexture;

            public SetVertexShaderConstantBuffer SetVertexShaderConstantBuffer;

            public SetPixelShader SetPixelShader;

            public SetVertexProcessing SetVertexProcessing;
            #endregion
        }
        #endregion
    }
}