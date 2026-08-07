using System;
using System.Collections.Generic;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
using Vector2 = System.Numerics.Vector2;
using Vector3 = System.Numerics.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

internal class AttributeInfo
{
    public GpuWrapApiVertexPackingPackingElement ElementInfo { get; set; } = null!;
    public IList<object> DataArray { get; set; } = null!;
    public byte TargetSize { get; set; }

    public void WriteElement(VertexAttributeWriter writer, int index, rendRenderMeshBlob rendRenderMeshBlob)
    {
        switch ((GpuWrapApiVertexPackingePackingType)ElementInfo.Type)
        {
            case GpuWrapApiVertexPackingePackingType.PT_Invalid:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Float1:
            {
                if (DataArray[index] is float scalar)
                {
                    writer.Write(scalar);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_Float2:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Float3:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Float4:
            {
                if (DataArray[index] is Vector3 vector3)
                {
                    writer.WriteFloat4(vector3);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_Float16_2:
            {
                if (DataArray[index] is Vector2 vector2)
                {
                    writer.WriteFloat16_2(vector2);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_Float16_4:
            {
                if (DataArray[index] is Vector3 vector3)
                {
                    writer.WriteFloat16_4(vector3);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_UShort1:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UShort2:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UShort4:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UShort4N:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Short1:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Short2:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Short4:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Short4N:
            {
                if (DataArray[index] is Vector3 vector3)
                {
                    writer.WriteShort4N(vector3);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_UInt1:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UInt2:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UInt3:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UInt4:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Int1:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Int2:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Int3:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Int4:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Color:
            {
                if (DataArray[index] is Vector3 vector3)
                {
                    writer.WriteColor(vector3);
                    return;
                }

                if (DataArray[index] is Vector4 vector4)
                {
                    writer.WriteColor(vector4);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_UByte1:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UByte1F:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_UByte4:
            {
                if (DataArray[index] is Vector4 vector4)
                {
                    writer.WriteUByte4(vector4);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_UByte4N:
            {
                if (DataArray[index] is Vector4 vector4)
                {
                    writer.WriteUByte4N(vector4);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_Byte4N:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Dec4:
            {
                if (DataArray[index] is Vector3 vector3)
                {
                    writer.WriteWKitDec4(vector3);
                    return;
                }

                if (DataArray[index] is Vector4 vector4)
                {
                    writer.WriteWKitDec4(vector4);
                    return;
                }
                throw new Exception();
            }
            case GpuWrapApiVertexPackingePackingType.PT_Index16:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Index32:
                throw new Exception();
            case GpuWrapApiVertexPackingePackingType.PT_Max:
                throw new Exception();
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
