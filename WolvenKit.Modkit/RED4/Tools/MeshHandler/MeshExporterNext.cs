using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SharpDX.Win32;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Tools.Common;
using WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshExporterNext
{
    private const ValidationMode s_validationMode = ValidationMode.Skip;

    private MeshFileWrapper _fileWrapper;
    private MeshExportArgs _args;

    private ModelRoot _modelRoot = ModelRoot.CreateModel();
    private Material _defaultMaterial;

    private MeshExporterNext(MeshFileWrapper fileWrapper, MeshExportArgs args)
    {
        _fileWrapper = fileWrapper;
        _args = args;

        _defaultMaterial = _modelRoot
            .CreateMaterial("Default")
            .WithDefault()
            .WithDoubleSide(true);

        // ExporterVersion just for Debug for now
        // Without => Old exporter
        // 1 => New Exporter, old format
        // 2 => New exporter, new format
        // ...
        if (_args.Format == MeshExperimental2Format.New)
        {
            ExtensionsFactory.RegisterExtension<ModelRoot, VariantsRootExtension>("KHR_materials_variants", root => new VariantsRootExtension(root));
            ExtensionsFactory.RegisterExtension<MeshPrimitive, VariantsPrimitiveExtension>("KHR_materials_variants", root => new VariantsPrimitiveExtension(root));

            _modelRoot.Extras = JsonSerializer.SerializeToNode(new GltfExtras { ExporterVersion = 2 }, Gltf.SerializationOptions());
        }
        else
        {
            _modelRoot.Extras = JsonSerializer.SerializeToNode(new GltfExtras { ExporterVersion = 1 }, Gltf.SerializationOptions());
        }
    }

    public ModelRoot? ToGLtf()
    {
        _modelRoot.UseScene(0).Name = "Scene";
        _modelRoot.DefaultScene = _modelRoot.UseScene(0);

        if (_args.withMaterials)
        {
            switch (_args.Format)
            {
                case MeshExperimental2Format.Legacy:
                    StoreMaterialsLegacy();
                    break;

                case MeshExperimental2Format.New:
                    StoreMaterials();
                    break;
            }
        }

        if (_fileWrapper.CMesh.Appearances.Count > 1)
        {
            switch (_args.Format)
            {
                case MeshExperimental2Format.Legacy:
                    StoreAppearancesLegacy();
                    break;

                case MeshExperimental2Format.New:
                    StoreAppearances();
                    break;
            }
        }

        if (_fileWrapper.CMesh.BoneNames.Count > 1)
        {
            switch (_args.Format)
            {
                case MeshExperimental2Format.Legacy:
                    StoreBonesLegacy();
                    break;

                case MeshExperimental2Format.New:
                    StoreBones();
                    break;
            }
        }

        if (_fileWrapper.CMesh.Parameters.Count > 1)
        {
            StoreParameters();
        }

        ExtractMeshLegacy();

        _modelRoot.MergeBuffers();

        return _modelRoot;
    }

    private void StoreParameters()
    {
        // TODO: Export parameters
    }

    private void ExtractMeshLegacy()
    {
        using var ms = new MemoryStream(_fileWrapper.RendBlob.RenderBuffer.Buffer.GetBytes());
        using var bufferReader = new VertexAttributeReader(ms);

        for (var i = 0; i < _fileWrapper.RendBlob.Header.RenderChunkInfos.Count; i++)
        {
            var renderChunkInfo = _fileWrapper.RendBlob.Header.RenderChunkInfos[i];

            if (_args.LodFilter && renderChunkInfo.LodMask != 1)
            {
                continue;
            }

            var meshName = $"submesh_{i:D2}_LOD_{renderChunkInfo.LodMask}";

            var node = _modelRoot.UseScene(0).CreateNode(meshName);
            node.Mesh = _modelRoot.CreateMesh(meshName);

            var primitive = node.Mesh.CreatePrimitive();

            if (_materials != null && _variants != null)
            {
                primitive.Material = _materials[_variants[0].Materials[i]];

                if (_variants.Count > 1)
                {
                    var variantList = primitive.UseExtension<VariantsPrimitiveExtension>();

                    var tmpDict = new Dictionary<int, VariantsPrimitiveEntry>();
                    for (var j = 0; j < _variants.Count; j++)
                    {
                        var material = _materials[_variants[j].Materials[i]];

                        if (!tmpDict.ContainsKey(material.LogicalIndex))
                        {
                            var variant = new VariantsPrimitiveEntry { Material = material.LogicalIndex };

                            variantList.Mappings.Add(variant);
                            tmpDict.Add(material.LogicalIndex, variant);
                        }
                        tmpDict[material.LogicalIndex].Variants.Add(j);
                    }
                }
            }
            else
            {
                primitive.Material = _defaultMaterial;
            }

            var morphTargets = new List<string>();

            using var ms1 = new MemoryStream();
            using var bw1 = new BinaryWriter(ms1);

            var dict = new Dictionary<int, List<VertexElement>>();

            var hasWeights = false;
            foreach (var vertexLayoutElement in renderChunkInfo.ChunkVertices.VertexLayout.Elements)
            {
                if (vertexLayoutElement.Usage == GpuWrapApiVertexPackingePackingUsage.PS_Invalid)
                {
                    continue;
                }

                if (vertexLayoutElement.StreamIndex > 4)
                {
                    continue;
                }

                if (!dict.TryGetValue(vertexLayoutElement.StreamIndex, out var lst))
                {
                    lst = new List<VertexElement>();
                    dict.Add(vertexLayoutElement.StreamIndex, lst);
                }

                lst.Add(new VertexElement(vertexLayoutElement, (EMaterialVertexFactory)(byte)renderChunkInfo.VertexFactory));

                if (lst.FirstOrDefault(x => x.AttributeKey == "WEIGHTS_0") != null)
                {
                    hasWeights = true;
                }
            }

            if (_skin != null && hasWeights)
            {
                node.Skin = _skin;
            }

            foreach (var (index, elementInfos) in dict)
            {
                var offset = renderChunkInfo.ChunkVertices.ByteOffsets[index];

                var sizes = new List<uint>();
                byte totalSize = 0;
                foreach (var elementInfo in elementInfos)
                {
                    sizes.Add(elementInfo.DataSize);
                    totalSize += elementInfo.DataSize;
                }

                if (renderChunkInfo.ChunkVertices.VertexLayout.SlotStrides[index] != totalSize)
                {
                    throw new Exception();
                }

                var padding = (-bufferReader.BaseStream.Position) & 15;
                if (padding > 0)
                {
                    bufferReader.BaseStream.Position += padding;
                }

                for (var j = 0; j < renderChunkInfo.NumVertices; j++)
                {
                    if (bufferReader.BaseStream.Position != offset + (totalSize * j))
                    {
                        throw new Exception();
                    }

                    foreach (var elementInfo in elementInfos)
                    {
                        elementInfo.Read(bufferReader);
                    }
                }

                TransformData(elementInfos);

                var garmentDict = new Dictionary<string, Accessor>();
                var vehicleDict = new Dictionary<string, Accessor>();

                foreach (var elementInfo in elementInfos)
                {
                    elementInfo.Write(_fileWrapper.RendBlob.Header.QuantizationScale, _fileWrapper.RendBlob.Header.QuantizationOffset);
                    var buffer = elementInfo.GetArray();

                    var acc = _modelRoot.CreateAccessor();
                    var buff = _modelRoot.UseBufferView(buffer, 0, buffer.Length, 0, BufferMode.ARRAY_BUFFER);
                    acc.SetVertexData(buff, 0, renderChunkInfo.NumVertices, elementInfo.DstFormat.Dimensions, elementInfo.DstFormat.Encoding, elementInfo.DstFormat.Normalized);

                    switch (elementInfo.ElementType)
                    {
                        case ElementType.Todo:
                            break;
                        case ElementType.Main:
                            primitive.SetVertexAccessor(elementInfo.AttributeKey, acc);
                            break;
                        case ElementType.VehicleDamage:
                            vehicleDict.Add(elementInfo.AttributeKey, acc);
                            break;
                        case ElementType.Garment:
                            garmentDict.Add(elementInfo.AttributeKey, acc);
                            break;
                        case ElementType.Unknown:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                if (garmentDict.Count > 0)
                {
                    var morphTargetIdx = morphTargets.IndexOf("GarmentSupport");
                    if (morphTargetIdx == -1)
                    {
                        morphTargets.Add("GarmentSupport");
                        morphTargetIdx = morphTargets.Count - 1;
                    }

                    primitive.SetMorphTargetAccessors(morphTargetIdx, garmentDict);
                }

                if (vehicleDict.Count > 0)
                {
                    var morphTargetIdx = morphTargets.IndexOf("VehicleDamageSupport");
                    if (morphTargetIdx == -1)
                    {
                        morphTargets.Add("VehicleDamageSupport");
                        morphTargetIdx = morphTargets.Count - 1;
                    }

                    primitive.SetMorphTargetAccessors(morphTargetIdx, vehicleDict);
                }
            }

            var oldPos = bufferReader.BaseStream.Position;
            bufferReader.BaseStream.Position = _fileWrapper.RendBlob.Header.IndexBufferOffset + renderChunkInfo.ChunkIndices.TeOffset;
            for (var j = 0; j < renderChunkInfo.NumIndices; j += 3)
            {
                switch ((GpuWrapApieIndexBufferChunkType)renderChunkInfo.ChunkIndices.Pe)
                {
                    case GpuWrapApieIndexBufferChunkType.IBCT_IndexUShort:
                        var t1 = bufferReader.ReadUInt16();
                        var t2 = bufferReader.ReadUInt16();
                        var t3 = bufferReader.ReadUInt16();

                        bw1.Write(t3);
                        bw1.Write(t2);
                        bw1.Write(t1);
                        break;
                    case GpuWrapApieIndexBufferChunkType.IBCT_IndexUInt:
                    case GpuWrapApieIndexBufferChunkType.IBCT_Max:
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            bufferReader.BaseStream.Position = oldPos;

            var buffer1 = ms1.ToArray();

            var acc1 = _modelRoot.CreateAccessor();
            var buff1 = _modelRoot.UseBufferView(buffer1, 0, buffer1.Length, 0, BufferMode.ELEMENT_ARRAY_BUFFER);
            acc1.SetIndexData(buff1, 0, (int)(uint)renderChunkInfo.NumIndices, IndexEncodingType.UNSIGNED_SHORT);
            primitive.SetIndexAccessor(acc1);

            var meshExtras = new MeshExtras();

            if (_args.Format == MeshExperimental2Format.Legacy)
            {
                meshExtras.MaterialNames = GetMaterialNames(i);
            }

            if (morphTargets.Count > 0)
            {
                meshExtras.TargetNames = morphTargets.ToArray();
            }

            node.Mesh.Extras = JsonSerializer.SerializeToNode(meshExtras, Gltf.SerializationOptions());
        }
    }

    private string[] GetMaterialNames(int index)
    {
        if (_fileWrapper.CMesh.Appearances.Count == 0)
        {
            throw new Exception();
        }

        var result = new string[_fileWrapper.CMesh.Appearances.Count];
        for (var i = 0; i < _fileWrapper.CMesh.Appearances.Count; i++)
        {
            if (_fileWrapper.CMesh.Appearances[i].Chunk is not { } appearance)
            {
                throw new Exception();
            }

            result[i] = appearance.ChunkMaterials[index].GetResolvedText()!;
        }

        return result;
    }

    private void TransformData(List<VertexElement> elementInfos)
    {
#pragma warning disable CS0162 // Unreachable code detected

        var normals = elementInfos.FirstOrDefault(x => x.AttributeKey == "NORMAL");
        if (normals != null)
        {
            for (var i = 0; i < normals.Vertices.Count; i++)
            {
                var v = normals.Vertices[i];
                normals.Vertices[i] = new System.Numerics.Vector4(v.X / 511f, v.Y / 511f, v.Z / 511f, -1f);
            }
        }

        var tangents = elementInfos.FirstOrDefault(x => x.AttributeKey == "TANGENT");
        if (tangents != null)
        {
            for (int i = 0; i < tangents.Vertices.Count; i++)
            {
                var v = tangents.Vertices[i];

                v = new System.Numerics.Vector4(v.X / 511f, v.Y / 511f, v.Z / 511f, v.W);
                switch (v.W)
                {
                    case 1:
                        v.W = -1f;
                        break;

                    case 2:
                        v.W = 1f;
                        break;

                    default:
                        throw new NotSupportedException();
                }

                if (!v.IsValidTangent())
                {
                    v = v.SanitizeTangent();
                }

                tangents.Vertices[i] = v;
            }
        }

        // Scan archive files for TEXCOORD_1 with values other then 0
        var texCoords0 = elementInfos.FirstOrDefault(x => x.AttributeKey == "TEXCOORD_0");
        if (texCoords0 != null)
        {
            for (var i = 0; i < texCoords0.Vertices.Count; i++)
            {
                var v = texCoords0.Vertices[i];

                v = v with { Y = (v.Y * -1) + 1 };

                texCoords0.Vertices[i] = v;
            }
        }

        if (s_validationMode != ValidationMode.Skip)
        {
            var weights0 = elementInfos.FirstOrDefault(x => x.AttributeKey == "WEIGHTS_0");
            var weights1 = elementInfos.FirstOrDefault(x => x.AttributeKey == "WEIGHTS_1");

            if (weights0 != null && weights1 != null)
            {
                for (var j = 0; j < weights0.Vertices.Count; j++)
                {
                    var vertex0 = weights0.Vertices[j];
                    var vertex1 = weights1.Vertices[j];

                    var sum = vertex0.X + vertex0.Y + vertex0.Z + vertex0.W + vertex1.X + vertex1.Y + vertex1.Z + vertex1.W;
                    if (sum != 1F)
                    {
                        weights0.Vertices[j] = vertex0 / sum;
                        weights1.Vertices[j] = vertex1 / sum;
                    }
                }
            }
            else if (weights0 != null)
            {
                for (var j = 0; j < weights0.Vertices.Count; j++)
                {
                    var vertex0 = weights0.Vertices[j];

                    var sum = vertex0.X + vertex0.Y + vertex0.Z + vertex0.W;
                    if (sum != 1F)
                    {
                        weights0.Vertices[j] = vertex0 / sum;
                    }
                }
            }
        }
#pragma warning restore CS0162 // Unreachable code detected
    }

    public static bool ToGltf(CR2WFile file, FileInfo outfile, MeshExportArgs args)
    {
        var wrapper = MeshFileWrapper.Create(file);
        if (wrapper == null)
        {
            throw new ArgumentException("File is not a valid mesh file", nameof(file));
        }

        var exporter = new MeshExporterNext(wrapper, args);
        var model = exporter.ToGLtf();

        if (model == null)
        {
            return false;
        }

        //var modelOld = MeshTools.ExportMesh2(file, args);

        model.Save(GLTFHelper.PrepareFilePath(outfile.FullName, args.isGLBinary), new WriteSettings(s_validationMode));

        return true;
    }
}
