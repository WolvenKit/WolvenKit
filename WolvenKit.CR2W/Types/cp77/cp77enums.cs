using System;
using System.Collections.Generic;
using System.Text;

namespace WolvenKit.CR2W.Types
{
    public static partial class Enums
    {
        public enum EMeshChunkFlags
        {
            MCF_RenderInScene,
            MCF_RenderInShadows
        }

        public enum ECookingPlatform
        {
            PLATFORM_PC
        }

        public enum GpuWrapApieIndexBufferChunkType
        {
            IBCT_IndexUShort
        }

        public enum GpuWrapApiVertexPackingePackingType
        {
            PT_Invalid,
            PT_Float1,
            PT_Float2,
            PT_Float3,
            PT_Float4,
            PT_Float16_2,
            PT_Float16_4,
            PT_UShort1,
            PT_UShort2,
            PT_UShort4,
            PT_UShort4N,
            PT_Short1,
            PT_Short2,
            PT_Short4,
            PT_Short4N,
            PT_UInt1,
            PT_UInt2,
            PT_UInt3,
            PT_UInt4,
            PT_Int1,
            PT_Int2,
            PT_Int3,
            PT_Int4,
            PT_Color,
            PT_UByte1,
            PT_UByte1F,
            PT_UByte4,
            PT_UByte4N,
            PT_Byte4N,
            PT_Dec4,
            PT_Index16,
            PT_Index32,
            PT_MAx,
        }

        public enum GpuWrapApiVertexPackingePackingUsage
        {
            PS_Position,
            PS_SkinIndices,
            PS_SkinWeights,
            PS_TexCoord,
            PS_Normal,
            PS_Tangent,
            PS_Color,
            PS_InstanceTransform,
            PS_InstanceSkinningData,
            PS_Invalid,
            PS_ExtraData
        }


    }
}
