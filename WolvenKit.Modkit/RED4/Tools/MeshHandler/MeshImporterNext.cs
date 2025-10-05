using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Model.Database;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Archive.Shaders;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
using Vector2 = System.Numerics.Vector2;
using Vector3 = System.Numerics.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshImporterNext
{
    private const ValidationMode s_validationMode = ValidationMode.Skip;

    private readonly ModelRoot _modelRoot;
    private readonly GltfImportArgs _args;

    private readonly MeshFileWrapper _fileWrapper;
    private readonly MeshFileWrapper? _oldFileWrapper;

    private int _exporterVersion;

    private MeshImporterNext(string filePath, GltfImportArgs args, CR2WFile? oldFile = null)
    {
        _modelRoot = ModelRoot.Load(filePath, new ReadSettings { Validation = s_validationMode });
        _args = args;

        _fileWrapper = MeshFileWrapper.Create();
        if (oldFile != null)
        {
            _oldFileWrapper = MeshFileWrapper.Create(oldFile);
        }

        var extras = GetExtras<GltfExtras>(_modelRoot.Extras);
        if (extras != null)
        {
            _exporterVersion = extras.ExporterVersion;
        }

        if (_exporterVersion >= 2)
        {
            ExtensionsFactory.RegisterExtension<ModelRoot, VariantsRootExtension>("KHR_materials_variants", root => new VariantsRootExtension(root));
            ExtensionsFactory.RegisterExtension<MeshPrimitive, VariantsPrimitiveExtension>("KHR_materials_variants", root => new VariantsPrimitiveExtension(root));
        }
    }

    public CR2WFile ToMesh()
    {
        using var ms = new MemoryStream();
        using var vd = new VertexAttributeWriter(ms);

        var min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        var max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

        foreach (var mesh in _modelRoot.LogicalMeshes)
        {
            foreach (var primitive in mesh.Primitives)
            {
                var positions = primitive.GetVertexAccessor("POSITION").AsVector3Array();

                foreach (var position in positions)
                {
                    min.X = MathF.Min(min.X, position.X);
                    min.Y = MathF.Min(min.Y, -position.Z);
                    min.Z = MathF.Min(min.Z, position.Y);

                    max.X = MathF.Max(max.X, position.X);
                    max.Y = MathF.Max(max.Y, -position.Z);
                    max.Z = MathF.Max(max.Z, position.Y);
                }
            }
        }

        _fileWrapper.CMesh.BoundingBox = new Box
        {
            Min = new WolvenKit.RED4.Types.Vector4
            {
                X = min.X,
                Y = min.Y,
                Z = min.Z,
                W = 1F
            },
            Max = new WolvenKit.RED4.Types.Vector4
            {
                X = max.X,
                Y = max.Y,
                Z = max.Z,
                W = 1F
            }
        };

        _fileWrapper.Header.QuantizationOffset = new WolvenKit.RED4.Types.Vector4
        {
            X = (max.X + min.X) / 2,
            Y = (max.Y + min.Y) / 2,
            Z = (max.Z + min.Z) / 2,
            W = 1F
        };

        _fileWrapper.Header.QuantizationScale = new WolvenKit.RED4.Types.Vector4
        {
            X = (max.X - min.X) / 2,
            Y = (max.Y - min.Y) / 2,
            Z = (max.Z - min.Z) / 2,
            W = 0
        };

        _fileWrapper.Header.QuantizationOffset = new WolvenKit.RED4.Types.Vector4
        {
            X = 0F, Y = 0.0574589372F, Z = 0.770890653F, W = 1F
        };

        _fileWrapper.Header.QuantizationScale = new WolvenKit.RED4.Types.Vector4
        {
            X = 0.487749279F,
            Y = 0.215588123F,
            Z = 0.762491286F,
            W = 0F
        };

        var usedLods = new List<byte>();

        if (_exporterVersion < 2)
        {
            LoadAppearancesLegacy();
            LoadBonesLegacy();
        }
        else
        {
            LoadAppearances();
            LoadBones();
        }

        foreach (var logicalNode in _modelRoot.LogicalNodes)
        {
            if (logicalNode.IsSkinSkeleton)
            {
                continue;
            }

            if (logicalNode.IsSkinJoint)
            {
                continue;
            }

            if (logicalNode.Mesh != null)
            {
                var name = logicalNode.Mesh.Name;
                if (_args.OverrideMeshNameWithNodeName && name != logicalNode.Name)
                {
                    name = logicalNode.Name;
                }

                if (name.Length != 16)
                {
                    throw new Exception("Name does not match expected format!");
                }

                var subMesh = int.Parse(name.Substring(8, 2));
                var lod = byte.Parse(name.Substring(15, 1));

                if (!usedLods.Contains(lod))
                {
                    _fileWrapper.Header.RenderLODs.Add(3 * usedLods.Count);
                    _fileWrapper.CMesh.LodLevelInfo.Add(3 * usedLods.Count);

                    usedLods.Add(lod);
                }

                if (logicalNode.Mesh.Primitives.Count != 1)
                {
                    throw new Exception();
                }

                var rendChunk = AddMesh(logicalNode.Mesh.Primitives[0], vd);
                rendChunk.LodMask = lod;

                _fileWrapper.Header.Topology.Add(new rendTopologyData());
            }
        }

        _fileWrapper.Header.VertexBufferSize = (CUInt32)vd.BaseStream.Position;

        var padding = (-_fileWrapper.Header.VertexBufferSize) & 1023;
        if (padding > 0)
        {
            vd.Write(new byte[padding]);
        }

        _fileWrapper.Header.IndexBufferOffset = (CUInt32)vd.BaseStream.Position;

        var index = 0;
        foreach (var mesh in _modelRoot.LogicalMeshes)
        {
            var indices = mesh.Primitives[0].GetIndices();

            var renderChunkInfo = _fileWrapper.Header.RenderChunkInfos[index];

            renderChunkInfo.ChunkIndices.Pe = GpuWrapApieIndexBufferChunkType.IBCT_IndexUShort;
            renderChunkInfo.ChunkIndices.TeOffset = (CUInt32)(vd.BaseStream.Position - _fileWrapper.Header.IndexBufferOffset);

            renderChunkInfo.NumIndices = (uint)indices.Count;

            for (var j = 0; j < indices.Count; j += 3)
            {
                vd.Write((ushort)indices[j + 2]);
                vd.Write((ushort)indices[j + 1]);
                vd.Write((ushort)indices[j + 0]);
            }

            index++;
        }

        _fileWrapper.Header.IndexBufferSize = (CUInt32)vd.BaseStream.Position - _fileWrapper.Header.IndexBufferOffset;
        _fileWrapper.Header.DataProcessing = 1;
        _fileWrapper.Header.Version = 20;

        _fileWrapper.RendBlob.RenderBuffer = new DataBuffer(ms.ToArray());

        return _fileWrapper.GetFile();
    }

    private rendChunk AddMesh(MeshPrimitive primitive, VertexAttributeWriter vertexAttributeWriter)
    {
        var renderChunkInfo = new rendChunk
        {
            RenderMask = EMeshChunkFlags.MCF_RenderInScene | EMeshChunkFlags.MCF_RenderInShadows,
        };

        var vertexCount = primitive.VertexAccessors["POSITION"].Count;
        if (vertexCount >= ushort.MaxValue)
        {
            throw new Exception();
        }
        renderChunkInfo.NumVertices = (CUInt16)vertexCount;

        var morphTargets = new Dictionary<string, IReadOnlyDictionary<string, Accessor>>();
        var extras = GetExtras<MeshExtras>(primitive.LogicalParent.Extras);
        for (var i = 0; i < primitive.MorphTargetsCount; i++)
        {
            var name = extras?.TargetNames != null ? extras.TargetNames[i] : $"target_{i}";
            morphTargets.Add(name, primitive.GetMorphTargetAccessors(i));
        }

        var layoutData = GetLayoutData(primitive.VertexAccessors, morphTargets);

        renderChunkInfo.ChunkVertices.VertexLayout.Elements = new CStatic<GpuWrapApiVertexPackingPackingElement>(32);
        renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides = new CStatic<CUInt8>(8);
        for (var j = 0; j < 8; j++)
        {
            renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides.Add(0);
        }

        foreach (var attributeInfo in layoutData)
        {
            renderChunkInfo.ChunkVertices.VertexLayout.Elements.Add(attributeInfo.ElementInfo);
            renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides[attributeInfo.ElementInfo.StreamIndex] += attributeInfo.TargetSize;
            renderChunkInfo.ChunkVertices.VertexLayout.Hash = 0;
        }

        var slotMask = 0;
        for (var j = 0; j < renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides.Count; j++)
        {
            if (renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides[j] > 0)
            {
                slotMask |= (1 << j);
            }
        }
        renderChunkInfo.ChunkVertices.VertexLayout.SlotMask = (uint)slotMask;
        renderChunkInfo.ChunkVertices.ByteOffsets = new CStatic<CUInt32>(5);

        for (var i = 0; i < 5; i++)
        {
            var padding = (-vertexAttributeWriter.BaseStream.Position) & 15;
            if (padding > 0)
            {
                vertexAttributeWriter.Write(new byte[padding]);
            }

            var elements = layoutData.Where(x => x.ElementInfo.StreamIndex == i).ToList();
            if (elements.Count == 0)
            {
                renderChunkInfo.ChunkVertices.ByteOffsets.Add(0);
                continue;
            }

            renderChunkInfo.ChunkVertices.ByteOffsets.Add((CUInt32)vertexAttributeWriter.BaseStream.Position);

            for (var j = 0; j < renderChunkInfo.NumVertices; j++)
            {
                foreach (var attributeInfo in elements)
                {
                    if (attributeInfo.ElementInfo.StreamType == GpuWrapApiVertexPackingEStreamType.ST_Invalid)
                    {
                        break;
                    }

                    attributeInfo.WriteElement(vertexAttributeWriter, j, _fileWrapper.RendBlob);
                }
            }
        }

        #region VertexFactory

        var tmpElements = renderChunkInfo.ChunkVertices.VertexLayout.Elements
            .Where(x => x.StreamType == GpuWrapApiVertexPackingEStreamType.ST_PerVertex)
            .ToList();

        renderChunkInfo.VertexFactory = (byte)GetVertexFactory(tmpElements);

        #endregion VertexFactory

        _fileWrapper.Header.RenderChunkInfos.Add(renderChunkInfo);

        if (extras?.TargetNames != null && extras.TargetNames.Contains("GarmentSupport"))
        {
            var garmentSupport = (meshMeshParamGarmentSupport?)_fileWrapper.CMesh.Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamGarmentSupport)?.Chunk;
            if (garmentSupport == null)
            {
                garmentSupport = new meshMeshParamGarmentSupport
                {
                    CustomMorph = true
                };
                _fileWrapper.CMesh.Parameters.Add(garmentSupport);
            }
            garmentSupport.ChunkCapVertices.Add(new CArray<CUInt32>());

            var garment = (garmentMeshParamGarment?)_fileWrapper.CMesh.Parameters.FirstOrDefault(x => x.Chunk is garmentMeshParamGarment)?.Chunk;
            if (garment == null)
            {
                garment = new garmentMeshParamGarment();
                _fileWrapper.CMesh.Parameters.Add(garment);
            }

            var garmentChunkData = new garmentMeshParamGarmentChunkData
            {
                NumVertices = (uint)vertexCount,
                LodMask = 1,
                IsTwoSided = false
            };

            var vertexBuffer = new MemoryStream();
            var vertexWriter = new BinaryWriter(vertexBuffer);

            foreach (var vec3 in primitive.VertexAccessors["POSITION"].AsVector3Array())
            {
                vertexWriter.Write(vec3.X);
                vertexWriter.Write(-vec3.Z);
                vertexWriter.Write(vec3.Y);
            }
            garmentChunkData.Vertices = new DataBuffer(vertexBuffer.ToArray());


            var indicesBuffer = new MemoryStream();
            var indicesWriter = new BinaryWriter(indicesBuffer);

            var indices = primitive.GetIndices();
            for (var j = 0; j < indices.Count; j += 3)
            {
                indicesWriter.Write((ushort)indices[j + 2]);
                indicesWriter.Write((ushort)indices[j + 1]);
                indicesWriter.Write((ushort)indices[j + 0]);
            }
            garmentChunkData.Indices = new DataBuffer(indicesBuffer.ToArray());


            var morphBuffer = new MemoryStream();
            var morphWriter = new BinaryWriter(morphBuffer);

            foreach (var vec3 in morphTargets["GarmentSupport"]["POSITION"].AsVector3Array())
            {
                morphWriter.Write(vec3.X);
                morphWriter.Write(-vec3.Z);
                morphWriter.Write(vec3.Y);
            }
            garmentChunkData.MorphOffsets = new DataBuffer(morphBuffer.ToArray());


            var flagsBuffer = new MemoryStream();
            var flagsWriter = new BinaryWriter(flagsBuffer);

            for (var i = 0; i < vertexCount; i++)
            {
                flagsWriter.Write((int)0);
            }
            garmentChunkData.GarmentFlags = new DataBuffer(flagsBuffer.ToArray());


            var uvBuffer = new MemoryStream();
            var uvWriter = new BinaryWriter(uvBuffer);

            foreach (var vec3 in primitive.VertexAccessors["TEXCOORD_0"].AsVector2Array())
            {
                uvWriter.Write(vec3.X);
                uvWriter.Write(vec3.Y);
            }
            garmentChunkData.Uv = new DataBuffer(uvBuffer.ToArray());

            garment.Chunks.Add(garmentChunkData);
        }

        return renderChunkInfo;
    }

    private List<AttributeInfo> GetLayoutData(IReadOnlyDictionary<string, Accessor> vertexAccessors, Dictionary<string, IReadOnlyDictionary<string, Accessor>> morphTargets)
    {
        var list = new List<AttributeInfo>();

        byte streamIndex = 0;
        var hasSkin = false;
        var groupUsed = false;

        if (vertexAccessors.ContainsKey("POSITION"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Short4N,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_Position,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = new List<object>(),
                TargetSize = 8
            });

            foreach (var vector in vertexAccessors["POSITION"].AsVector3Array())
            {
                var x = (vector.X - _fileWrapper.Header.QuantizationOffset.X) / _fileWrapper.Header.QuantizationScale.X;
                var y = (-vector.Z - _fileWrapper.Header.QuantizationOffset.Y) / _fileWrapper.Header.QuantizationScale.Y;
                var z = (vector.Y - _fileWrapper.Header.QuantizationOffset.Z) / _fileWrapper.Header.QuantizationScale.Z;

                list[^1].DataArray.Add(new Vector3(x, y, z));
            }

            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("BoneIndex"))
        {
            hasSkin = true;
            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("JOINTS_0"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_UByte4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["JOINTS_0"].AsVector4Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            hasSkin = true;
            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("JOINTS_1"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_UByte4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices,
                    UsageIndex = 1,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["JOINTS_1"].AsVector4Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            hasSkin = true;
            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("WEIGHTS_0"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_UByte4N,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["WEIGHTS_0"].AsVector4Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            hasSkin = true;
            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("WEIGHTS_1"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_UByte4N,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights,
                    UsageIndex = 1,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["WEIGHTS_1"].AsVector4Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            hasSkin = true;
            groupUsed = true;
        }

        if (groupUsed)
        {
            streamIndex++;
            groupUsed = false;
        }

        if (vertexAccessors.ContainsKey("TEXCOORD_0"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Float16_2,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_TexCoord,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = new List<object>(),
                TargetSize = 4
            });

            foreach (var vector in vertexAccessors["TEXCOORD_0"].AsVector2Array())
            {
                var x = vector.X;
                var y = (vector.Y * -1) + 1;

                list[^1].DataArray.Add(new Vector2(x, y));
            }

            groupUsed = true;
        }

        if (groupUsed)
        {
            streamIndex++;
            groupUsed = false;
        }

        if (vertexAccessors.ContainsKey("NORMAL"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Dec4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_Normal,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = new List<object>(),
                TargetSize = 4
            });

            foreach (var vector in vertexAccessors["NORMAL"].AsVector3Array())
            {
                var v = new Vector3(vector.X, -vector.Z, vector.Y);
                v = Vector3.Multiply(v, new Vector3(511.0F, 511.0F, 511.0F));

                list[^1].DataArray.Add(v);
            }

            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("TANGENT"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Dec4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_Tangent,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = new List<object>(),
                TargetSize = 4
            });

            foreach (var vector in vertexAccessors["TANGENT"].AsVector4Array())
            {
                var v = new Vector4(vector.X, -vector.Z, vector.Y, vector.W);
                v = Vector4.Multiply(v, new Vector4(511.0F, 511.0F, 511.0F, 1.0F));

                list[^1].DataArray.Add(v);
            }

            groupUsed = true;
        }

        if (groupUsed)
        {
            streamIndex++;
            groupUsed = false;
        }

        if (vertexAccessors.ContainsKey("COLOR_0"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Color,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_Color,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["COLOR_0"].AsVector4Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("TEXCOORD_1"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Float16_2,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_TexCoord,
                    UsageIndex = 1,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["TEXCOORD_1"].AsVector2Array().Cast<object>().ToList(),
                TargetSize = 4
            });

            groupUsed = true;
        }

        if (groupUsed)
        {
            streamIndex++;
            groupUsed = false;
        }

        // TODO
        if (vertexAccessors.ContainsKey("DestructionIndices"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("MultilayerPaint"))
        {
            groupUsed = true;
        }

        if (morphTargets.ContainsKey("GarmentSupport"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Float16_4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_ExtraData,
                    UsageIndex = 0,
                    StreamIndex = 0,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = new List<object>(),
                TargetSize = 8
            });

            foreach (var vector in morphTargets["GarmentSupport"]["POSITION"].AsVector3Array())
            {
                list[^1].DataArray.Add(new Vector3(vector.X, -vector.Z, vector.Y));
            }

            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("ExtraData_0"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("ExtraData_1"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("ExtraData_2"))
        {
            groupUsed = true;
        }

        if (groupUsed)
        {
            groupUsed = false;
        }

        list.Add(new AttributeInfo
        {
            ElementInfo = new GpuWrapApiVertexPackingPackingElement
            {
                Type = GpuWrapApiVertexPackingePackingType.PT_Float4,
                Usage = GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform,
                UsageIndex = 0,
                StreamIndex = 7,
                StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerInstance
            },
            TargetSize = 16
        });

        list.Add(new AttributeInfo
        {
            ElementInfo = new GpuWrapApiVertexPackingPackingElement
            {
                Type = GpuWrapApiVertexPackingePackingType.PT_Float4,
                Usage = GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform,
                UsageIndex = 1,
                StreamIndex = 7,
                StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerInstance
            },
            TargetSize = 16
        });

        list.Add(new AttributeInfo
        {
            ElementInfo = new GpuWrapApiVertexPackingPackingElement
            {
                Type = GpuWrapApiVertexPackingePackingType.PT_Float4,
                Usage = GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform,
                UsageIndex = 2,
                StreamIndex = 7,
                StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerInstance
            },
            TargetSize = 16
        });

        if (hasSkin)
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_UInt4,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_InstanceSkinningData,
                    UsageIndex = 0,
                    StreamIndex = 7,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerInstance
                },
                TargetSize = 16
            });
        }

        if (groupUsed)
        {
            groupUsed = false;
        }

        // TODO
        if (vertexAccessors.ContainsKey("VehicleDmgNormal_0"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("VehicleDmgNormal_1"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("VehicleDmgPosition_0"))
        {
            groupUsed = true;
        }

        // TODO
        if (vertexAccessors.ContainsKey("VehicleDmgPosition_1"))
        {
            groupUsed = true;
        }

        if (vertexAccessors.ContainsKey("_LIGHTBLOCKERINTENSITY"))
        {
            list.Add(new AttributeInfo
            {
                ElementInfo = new GpuWrapApiVertexPackingPackingElement
                {
                    Type = GpuWrapApiVertexPackingePackingType.PT_Float1,
                    Usage = GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity,
                    UsageIndex = 0,
                    StreamIndex = streamIndex,
                    StreamType = GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                },
                DataArray = vertexAccessors["_LIGHTBLOCKERINTENSITY"].AsScalarArray().Cast<object>().ToList(),
                TargetSize = 4
            });

            groupUsed = true;
        }

        list.Add(new AttributeInfo
        {
            ElementInfo = new GpuWrapApiVertexPackingPackingElement
            {
                Type = GpuWrapApiVertexPackingePackingType.PT_Invalid,
                Usage = GpuWrapApiVertexPackingePackingUsage.PS_Invalid,
                UsageIndex = 0,
                StreamType = GpuWrapApiVertexPackingEStreamType.ST_Invalid
            }
        });

        return list;
    }

    private EMaterialVertexFactory GetVertexFactory(List<GpuWrapApiVertexPackingPackingElement> elements)
    {
        // TODO: MVF_MeshProcedural, MVF_MeshProxy, MVF_MeshWindowProxy

        if (elements.Count == 1 && elements[0].Usage == GpuWrapApiVertexPackingePackingUsage.PS_Position)
        {
            return EMaterialVertexFactory.MVF_Terrain;
        }

        var isSkinnedSingleBone = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_BoneIndex);
        if (isSkinnedSingleBone)
        {
            return EMaterialVertexFactory.MVF_MeshSkinnedSingleBone;
        }

        var isSpeedTree = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_ExtraData && x.UsageIndex == 2);
        if (isSpeedTree)
        {
            return EMaterialVertexFactory.MVF_MeshSpeedTree;
        }

        var isSkinned = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices);
        var isDestruction = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_DestructionIndices);
        if (isDestruction)
        {
            if (isSkinned)
            {
                return EMaterialVertexFactory.MVF_MeshDestructibleSkinned;
            }
            else
            {
                return EMaterialVertexFactory.MVF_MeshDestructible;
            }
        }

        var isVehicle = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_VehicleDmgPosition);
        var isSkinnedExt = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices && x.UsageIndex == 1);
        var isGarment = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_ExtraData && x.Type == GpuWrapApiVertexPackingePackingType.PT_Float16_4);
        var isLightBlocker = elements.Any(x => x.Usage == GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity);

        if (isVehicle)
        {
            if (isSkinned)
            {
                return EMaterialVertexFactory.MVF_MeshSkinnedVehicle;
            }

            return EMaterialVertexFactory.MVF_MeshStaticVehicle;
        }
        else
        {
            if (isLightBlocker)
            {
                if (isGarment)
                {
                    if (isSkinnedExt)
                    {
                        return EMaterialVertexFactory.MVF_GarmentMeshExtSkinnedLightBlockers;
                    }

                    if (isSkinned)
                    {
                        return EMaterialVertexFactory.MVF_GarmentMeshSkinnedLightBlockers;
                    }
                }
                else
                {
                    if (isSkinnedExt)
                    {
                        return EMaterialVertexFactory.MVF_MeshExtSkinnedLightBlockers;
                    }

                    if (isSkinned)
                    {
                        return EMaterialVertexFactory.MVF_MeshSkinnedLightBlockers;
                    }
                }
            }
            else
            {
                if (isGarment)
                {
                    if (isSkinnedExt)
                    {
                        return EMaterialVertexFactory.MVF_GarmentMeshExtSkinned;
                    }

                    if (isSkinned)
                    {
                        return EMaterialVertexFactory.MVF_GarmentMeshSkinned;
                    }
                }
                else
                {
                    if (isSkinnedExt)
                    {
                        return EMaterialVertexFactory.MVF_MeshExtSkinned;
                    }

                    if (isSkinned)
                    {
                        return EMaterialVertexFactory.MVF_MeshSkinned;
                    }
                }
            }
        }

        return EMaterialVertexFactory.MVF_MeshStatic;
    }

    private T? GetExtras<T>(JsonNode extras)
    {
        try
        {
            return extras.Deserialize<T>();
        }
        catch (Exception)
        {
            return default;
        }
    }

    public static bool ToMesh(FileInfo inGltfFile, Stream inMeshStream, GltfImportArgs args)
    {
        var orgFile = Read(inMeshStream);

        var importer = new MeshImporterNext(inGltfFile.FullName, args, orgFile);
        var newFile = importer.ToMesh();

        Write(inMeshStream, newFile);

        return true;
    }

    private static CR2WFile? Read(Stream stream)
    {
        try
        {
            stream.Seek(0, SeekOrigin.Begin);
            using var reader = new CR2WReader(stream, Encoding.Default, true);
            reader.ParsingError += args => true;

            if (reader.ReadFile(out var file) == EFileReadErrorCodes.NoError)
            {
                return file;
            }
        }
        catch (Exception)
        {
            // ignore
        }

        return null;
    }

    private static void Write(Stream stream, CR2WFile file)
    {
        if (!stream.CanWrite)
        {
            throw new Exception();
        }

        stream.Seek(0, SeekOrigin.Begin);
        using var writer = new CR2WWriter(stream);
        writer.WriteFile(file);
    }
}
