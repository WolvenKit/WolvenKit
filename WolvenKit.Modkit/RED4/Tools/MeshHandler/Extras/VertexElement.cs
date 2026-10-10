using System;
using System.Collections.Generic;
using System.IO;
using SharpGLTF.Memory;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
using Vector4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

internal enum ElementType
{
    Unknown,
    Todo,
    Main,
    Garment,
    VehicleDamage
}

internal sealed class VertexElement
{
    private readonly GpuWrapApiVertexPackingPackingElement _element;

    private readonly MemoryStream _stream = new();
    private readonly BinaryWriter _writer;

    public readonly List<Vector4> Vertices = [];

    public ElementType ElementType { get; private set; } = ElementType.Unknown;
    public string AttributeKey { get; private set; } = null!;

    public AttributeFormat DstFormat { get; private set; }

    public byte DataSize { get; private set; }

    public VertexElement(GpuWrapApiVertexPackingPackingElement element, EMaterialVertexFactory vertexFactory)
    {
        _element = element;
        _writer = new BinaryWriter(_stream);

        GetInfo(vertexFactory);
    }

    private void GetInfo(EMaterialVertexFactory vertexFactory)
    {
        switch ((GpuWrapApiVertexPackingePackingUsage)_element.Usage)
        {
            case GpuWrapApiVertexPackingePackingUsage.PS_Position:
                ElementType = ElementType.Main;
                AttributeKey = "POSITION";

                DstFormat = new(DimensionType.VEC3, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_Normal:
                ElementType = ElementType.Main;
                AttributeKey = "NORMAL";

                DstFormat = new(DimensionType.VEC3, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_Tangent:
                ElementType = ElementType.Main;
                AttributeKey = "TANGENT";

                DstFormat = new(DimensionType.VEC4, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_TexCoord:
                ElementType = ElementType.Main;
                AttributeKey = $"TEXCOORD_{_element.UsageIndex}";

                DstFormat = new(DimensionType.VEC2, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_Color:
                ElementType = ElementType.Main;
                AttributeKey = $"COLOR_{_element.UsageIndex}";

                DstFormat = new(DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, true);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_VehicleDmgNormal:
                ElementType = ElementType.VehicleDamage;
                AttributeKey = "NORMAL";

                DstFormat = new(DimensionType.VEC3, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_VehicleDmgPosition:
                ElementType = ElementType.VehicleDamage;
                AttributeKey = "POSITION";

                DstFormat = new(DimensionType.VEC3, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices:
                ElementType = ElementType.Main;
                AttributeKey = $"JOINTS_{_element.UsageIndex}";

                DstFormat = new(DimensionType.VEC4, EncodingType.UNSIGNED_BYTE, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights:
                ElementType = ElementType.Main;
                AttributeKey = $"WEIGHTS_{_element.UsageIndex}";

                DstFormat = new(DimensionType.VEC4, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_DestructionIndices:
                ElementType = ElementType.Todo;
                AttributeKey = $"???";

                DstFormat = new(DimensionType.VEC2, EncodingType.UNSIGNED_SHORT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_MultilayerPaint:
                ElementType = ElementType.Todo;
                AttributeKey = $"???";

                DstFormat = new(DimensionType.SCALAR, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_ExtraData:
                if (vertexFactory is
                    EMaterialVertexFactory.MVF_GarmentMeshSkinned or
                    EMaterialVertexFactory.MVF_GarmentMeshExtSkinned or
                    EMaterialVertexFactory.MVF_GarmentMeshSkinnedLightBlockers or
                    EMaterialVertexFactory.MVF_GarmentMeshExtSkinnedLightBlockers)
                {
                    ElementType = ElementType.Garment;
                    AttributeKey = "POSITION";

                    DstFormat = new(DimensionType.VEC3, EncodingType.FLOAT, false);
                }
                else if (vertexFactory == EMaterialVertexFactory.MVF_MeshSpeedTree)
                {
                    ElementType = ElementType.Todo;
                    AttributeKey = "???";

                    // has index 0, 1, 2
                    switch (_element.UsageIndex)
                    {
                        case 0:
                            // X seems to be byte
                            // DstFormat = new(DimensionType.SCALAR, EncodingType.BYTE, false);
                            DstFormat = new(DimensionType.VEC4, EncodingType.FLOAT, false);
                            break;
                        case 1:
                        case 2:
                            DstFormat = new(DimensionType.VEC4, EncodingType.FLOAT, false);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    throw new NotSupportedException();
                }
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity:
                ElementType = ElementType.Main;
                AttributeKey = "_LIGHTBLOCKERINTENSITY";

                DstFormat = new(DimensionType.SCALAR, EncodingType.FLOAT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_BoneIndex:
                ElementType = ElementType.Todo;
                AttributeKey = $"???";

                DstFormat = new(DimensionType.SCALAR, EncodingType.UNSIGNED_INT, false);
                break;
            case GpuWrapApiVertexPackingePackingUsage.PS_Invalid:
            case GpuWrapApiVertexPackingePackingUsage.PS_SysPosition:
            case GpuWrapApiVertexPackingePackingUsage.PS_Binormal:
            case GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform:
            case GpuWrapApiVertexPackingePackingUsage.PS_InstanceLODParams:
            case GpuWrapApiVertexPackingePackingUsage.PS_InstanceSkinningData:
            case GpuWrapApiVertexPackingePackingUsage.PS_PatchSize:
            case GpuWrapApiVertexPackingePackingUsage.PS_PatchBias:
            case GpuWrapApiVertexPackingePackingUsage.PS_PositionDelta:
            case GpuWrapApiVertexPackingePackingUsage.PS_Padding:
            case GpuWrapApiVertexPackingePackingUsage.PS_PatchOffset:
            case GpuWrapApiVertexPackingePackingUsage.PS_Max:
            default:
                throw new ArgumentOutOfRangeException(nameof(_element.Usage), _element.Usage, null);
        }

        switch ((GpuWrapApiVertexPackingePackingType)_element.Type)
        {
            case GpuWrapApiVertexPackingePackingType.PT_Short4N:
                DataSize = 8;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_2:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Dec4:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Color:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float4:
                DataSize = 16;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4N:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UShort2:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float1:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_4:
                DataSize = 8;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UInt1:
                DataSize = 4;
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Invalid:
            case GpuWrapApiVertexPackingePackingType.PT_Float2:
            case GpuWrapApiVertexPackingePackingType.PT_Float3:
            case GpuWrapApiVertexPackingePackingType.PT_UShort1:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4N:
            case GpuWrapApiVertexPackingePackingType.PT_Short1:
            case GpuWrapApiVertexPackingePackingType.PT_Short2:
            case GpuWrapApiVertexPackingePackingType.PT_Short4:
            case GpuWrapApiVertexPackingePackingType.PT_UInt2:
            case GpuWrapApiVertexPackingePackingType.PT_UInt3:
            case GpuWrapApiVertexPackingePackingType.PT_UInt4:
            case GpuWrapApiVertexPackingePackingType.PT_Int1:
            case GpuWrapApiVertexPackingePackingType.PT_Int2:
            case GpuWrapApiVertexPackingePackingType.PT_Int3:
            case GpuWrapApiVertexPackingePackingType.PT_Int4:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1F:
            case GpuWrapApiVertexPackingePackingType.PT_Byte4N:
            case GpuWrapApiVertexPackingePackingType.PT_Index16:
            case GpuWrapApiVertexPackingePackingType.PT_Index32:
            case GpuWrapApiVertexPackingePackingType.PT_Max:
            default:
                throw new ArgumentOutOfRangeException(nameof(_element.Type), _element.Type, null);
        }
    }

    public void Read(VertexAttributeReader reader)
    {
        switch ((GpuWrapApiVertexPackingePackingType)_element.Type)
        {
            case GpuWrapApiVertexPackingePackingType.PT_Short4N:
                Vertices.Add(reader.ReadShortN4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_2:
                Vertices.Add(reader.ReadHalf2());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Dec4:
                Vertices.Add(reader.ReadWKitDec4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Color:
                Vertices.Add(reader.ReadColor());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float4:
                Vertices.Add(reader.ReadFloat4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4:
                Vertices.Add(reader.ReadUByte4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4N:
                Vertices.Add(reader.ReadUByteN4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UShort2:
                Vertices.Add(reader.ReadUShort2());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float1:
                Vertices.Add(reader.ReadFloat());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_4:
                Vertices.Add(reader.ReadHalf4());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UInt1:
                Vertices.Add(reader.ReadUInt());
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Invalid:
            case GpuWrapApiVertexPackingePackingType.PT_Float2:
            case GpuWrapApiVertexPackingePackingType.PT_Float3:
            case GpuWrapApiVertexPackingePackingType.PT_UShort1:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4N:
            case GpuWrapApiVertexPackingePackingType.PT_Short1:
            case GpuWrapApiVertexPackingePackingType.PT_Short2:
            case GpuWrapApiVertexPackingePackingType.PT_Short4:
            case GpuWrapApiVertexPackingePackingType.PT_UInt2:
            case GpuWrapApiVertexPackingePackingType.PT_UInt3:
            case GpuWrapApiVertexPackingePackingType.PT_UInt4:
            case GpuWrapApiVertexPackingePackingType.PT_Int1:
            case GpuWrapApiVertexPackingePackingType.PT_Int2:
            case GpuWrapApiVertexPackingePackingType.PT_Int3:
            case GpuWrapApiVertexPackingePackingType.PT_Int4:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1F:
            case GpuWrapApiVertexPackingePackingType.PT_Byte4N:
            case GpuWrapApiVertexPackingePackingType.PT_Index16:
            case GpuWrapApiVertexPackingePackingType.PT_Index32:
            case GpuWrapApiVertexPackingePackingType.PT_Max:
            default:
                throw new ArgumentOutOfRangeException(nameof(_element.Type), _element.Type, null);
        }
    }

    public void Write(WolvenKit.RED4.Types.Vector4 quantizationScale, WolvenKit.RED4.Types.Vector4 quantizationOffset)
    {
        switch ((GpuWrapApiVertexPackingePackingType)_element.Type)
        {
            case GpuWrapApiVertexPackingePackingType.PT_Short4N:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        var v = vertex;

                        if (AttributeKey == "POSITION")
                        {
                            v = DirectXMeshHelper.MultiplyAdd(v, quantizationScale, quantizationOffset);
                        }

                        v = v.YUp();

                        if (DstFormat.Dimensions == DimensionType.VEC3)
                        {
                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_2:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC2)
                        {
                            _writer.Write(vertex.X);
                            _writer.Write(vertex.Y);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Dec4:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        var v = vertex.YUp();

                        if (DstFormat.Dimensions == DimensionType.VEC3)
                        {
                            var tmp = new System.Numerics.Vector3(v.X, v.Y, v.Z);
                            if (!tmp.IsNormalized())
                            {
                                tmp.IsNormalized();
                            }

                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                        }
                        else if (DstFormat.Dimensions == DimensionType.VEC4)
                        {
                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                            _writer.Write(v.W);

                            if (!vertex.IsValidTangent())
                            {
                                vertex.IsValidTangent();
                            }
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Color:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.UNSIGNED_SHORT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC4)
                        {
                            _writer.Write((ushort)vertex.X);
                            _writer.Write((ushort)vertex.Y);
                            _writer.Write((ushort)vertex.Z);
                            _writer.Write((ushort)vertex.W);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float4:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC3)
                        {
                            var v = vertex / short.MaxValue;

                            // Debug
                            if (ElementType == ElementType.VehicleDamage && AttributeKey == "POSITION")
                            {
                                v = v * 100f;
                            }

                            v = v.YUp();

                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.UNSIGNED_BYTE)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC4)
                        {
                            _writer.Write((byte)vertex.X);
                            _writer.Write((byte)vertex.Y);
                            _writer.Write((byte)vertex.Z);
                            _writer.Write((byte)vertex.W);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UByte4N:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC4)
                        {
                            _writer.Write(vertex.X);
                            _writer.Write(vertex.Y);
                            _writer.Write(vertex.Z);
                            _writer.Write(vertex.W);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UShort2:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.UNSIGNED_SHORT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC2)
                        {
                            _writer.Write((ushort)vertex.X);
                            _writer.Write((ushort)vertex.Y);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float1:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        if (DstFormat.Dimensions == DimensionType.SCALAR)
                        {
                            _writer.Write(vertex.X);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Float16_4:
                foreach (var vertex in Vertices)
                {
                    var v = vertex.YUp();

                    if (DstFormat.Encoding == EncodingType.FLOAT)
                    {
                        if (DstFormat.Dimensions == DimensionType.VEC3)
                        {
                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                        }
                        else if (DstFormat.Dimensions == DimensionType.VEC4)
                        {
                            _writer.Write(v.X);
                            _writer.Write(v.Y);
                            _writer.Write(v.Z);
                            _writer.Write(v.W);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_UInt1:
                foreach (var vertex in Vertices)
                {
                    if (DstFormat.Encoding == EncodingType.UNSIGNED_INT)
                    {
                        if (DstFormat.Dimensions == DimensionType.SCALAR)
                        {
                            _writer.Write((uint)vertex.X);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                break;
            case GpuWrapApiVertexPackingePackingType.PT_Invalid:
            case GpuWrapApiVertexPackingePackingType.PT_Float2:
            case GpuWrapApiVertexPackingePackingType.PT_Float3:
            case GpuWrapApiVertexPackingePackingType.PT_UShort1:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4:
            case GpuWrapApiVertexPackingePackingType.PT_UShort4N:
            case GpuWrapApiVertexPackingePackingType.PT_Short1:
            case GpuWrapApiVertexPackingePackingType.PT_Short2:
            case GpuWrapApiVertexPackingePackingType.PT_Short4:
            case GpuWrapApiVertexPackingePackingType.PT_UInt2:
            case GpuWrapApiVertexPackingePackingType.PT_UInt3:
            case GpuWrapApiVertexPackingePackingType.PT_UInt4:
            case GpuWrapApiVertexPackingePackingType.PT_Int1:
            case GpuWrapApiVertexPackingePackingType.PT_Int2:
            case GpuWrapApiVertexPackingePackingType.PT_Int3:
            case GpuWrapApiVertexPackingePackingType.PT_Int4:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1:
            case GpuWrapApiVertexPackingePackingType.PT_UByte1F:
            case GpuWrapApiVertexPackingePackingType.PT_Byte4N:
            case GpuWrapApiVertexPackingePackingType.PT_Index16:
            case GpuWrapApiVertexPackingePackingType.PT_Index32:
            case GpuWrapApiVertexPackingePackingType.PT_Max:
            default:
                throw new ArgumentOutOfRangeException(nameof(_element.Type), _element.Type, null);
        }
    }

    public byte[] GetArray() => _stream.ToArray();
}
