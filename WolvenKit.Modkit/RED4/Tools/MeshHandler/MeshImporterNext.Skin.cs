using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshImporterNext
{
    private void LoadBonesLegacy()
    {
        if (_oldFileWrapper == null)
        {
            throw new Exception();
        }

        foreach (var bonaName in _oldFileWrapper.CMesh.BoneNames)
        {
            _fileWrapper.CMesh.BoneNames.Add(bonaName);
        }

        foreach (var rigMatrix in _oldFileWrapper.CMesh.BoneRigMatrices)
        {
            _fileWrapper.CMesh.BoneRigMatrices.Add(rigMatrix);
        }

        foreach (var vertexEpsilon in _oldFileWrapper.CMesh.BoneVertexEpsilons)
        {
            _fileWrapper.CMesh.BoneVertexEpsilons.Add(vertexEpsilon);
        }

        foreach (var lodBoneMask in _oldFileWrapper.CMesh.LodBoneMask)
        {
            _fileWrapper.CMesh.LodBoneMask.Add(lodBoneMask);
        }

        foreach (var bonePosition in _oldFileWrapper.Header.BonePositions)
        {
            _fileWrapper.Header.BonePositions.Add(bonePosition);
        }
    }

    private void LoadBones(Dictionary<byte, HashSet<int>> lodInfo)
    {
        var boneNodes = _modelRoot.LogicalNodes.Where(x => x.IsSkinJoint).ToList();

        var bonesLod = new int[boneNodes.Count];
        var lodId = 0;
        foreach (var lod in lodInfo.Keys.OrderBy(x => x))
        {
            foreach (var boneIndex in lodInfo[lod])
            {
                bonesLod[boneIndex] |= 1 << lodId;
            }

            lodId++;
        }

        for (var i = 0; i < boneNodes.Count; i++)
        {
            var logicalNode = boneNodes[i];

            var boneRig = ZUp(RotY(logicalNode.WorldMatrix));
            Matrix4x4.Invert(boneRig, out var inverseBoneRig);

            _fileWrapper.CMesh.BoneNames.Add(logicalNode.Name);
            _fileWrapper.CMesh.BoneRigMatrices.Add(inverseBoneRig);

            _fileWrapper.Header.BonePositions.Add(new WolvenKit.RED4.Types.Vector4
            {
                X = logicalNode.LocalTransform.Translation.X,
                Y = -logicalNode.LocalTransform.Translation.Z,
                Z = logicalNode.LocalTransform.Translation.Y,
                W = 1F
            });

            var extras = GetExtras<BoneExtras>(logicalNode.Extras);
            if (extras != null)
            {
                _fileWrapper.CMesh.BoneVertexEpsilons.Add(extras.Epsilon);
            }
            else
            {
                // TODO
                _fileWrapper.CMesh.BoneVertexEpsilons.Add(0F);
            }

            _fileWrapper.CMesh.LodBoneMask.Add((CUInt8)bonesLod[i]);
        }

        Matrix4x4 RotY(Matrix4x4 src)
        {
            var axisBaseChange = new Matrix4x4(
                0.0F, 0.0F, -1.0F, 0.0F,
                0.0F, 1.0F, 0.0F, 0.0F,
                1.0F, 0.0F, 0.0F, 0.0F,
                0.0F, 0.0F, 0.0F, 1.0F);

            return Matrix4x4.Multiply(axisBaseChange, src);
        }

        Matrix4x4 ZUp(Matrix4x4 src)
        {
            return src with
            {
                M12 = -src.M13,
                M13 = src.M12,

                M22 = -src.M23,
                M23 = src.M22,

                M32 = -src.M33,
                M33 = src.M32,

                M42 = -src.M43,
                M43 = src.M42,
                M44 = 1
            };
        }
    }
}
