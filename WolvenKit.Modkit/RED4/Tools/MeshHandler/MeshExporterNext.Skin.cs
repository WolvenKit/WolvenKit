using System;
using System.Numerics;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshExporterNext
{
    private Skin? _skin;

    private void ValidateBones()
    {
        if (_fileWrapper.Header.BonePositions.Count != _fileWrapper.CMesh.BoneNames.Count)
        {
            throw new InvalidOperationException("Bone position count does not match bone name count.");
        }

        if (_fileWrapper.Header.BonePositions.Count != _fileWrapper.CMesh.BoneRigMatrices.Count)
        {
            throw new InvalidOperationException("Bone position count does not match bone rig matrices count.");
        }

        if (_fileWrapper.Header.BonePositions.Count != _fileWrapper.CMesh.BoneVertexEpsilons.Count)
        {
            throw new InvalidOperationException("Bone position count does not match bone vertex epsilons count.");
        }

        if (_fileWrapper.Header.BonePositions.Count != _fileWrapper.CMesh.LodBoneMask.Count)
        {
            throw new InvalidOperationException("Bone position count does not match lod bone mask count.");
        }
    }

    private void StoreBonesLegacy()
    {
        ValidateBones();

        var positionCount = _fileWrapper.Header.BonePositions.Count;

        var nodes = new Node[positionCount];

        var armature = _modelRoot.UseScene(0).CreateNode("Armature");
        for (var i = 0; i < positionCount; i++)
        {
            var position = _fileWrapper.RendBlob.Header.BonePositions[i]!;
            var name = _fileWrapper.CMesh.BoneNames[i].GetResolvedText()!;

            nodes[i] = armature.CreateNode(name)
                .WithLocalScale(System.Numerics.Vector3.One)
                .WithLocalRotation(System.Numerics.Quaternion.Identity)
                .WithLocalTranslation(new System.Numerics.Vector3(position.X, position.Z, -position.Y));
        }

        _skin = _modelRoot.CreateSkin();

        if (nodes.Length == 1)
        {
            _skin.BindJoints(nodes[0].VisualParent.WorldMatrix, nodes);
        }
        else
        {
            _skin.BindJoints(nodes);
        }
    }

    private void StoreBones()
    {
        ValidateBones();

        var positionCount = _fileWrapper.Header.BonePositions.Count;

        var nodes = new Node[positionCount];

        var armature = _modelRoot.UseScene(0).CreateNode("Armature");
        for (var i = 0; i < positionCount; i++)
        {
            var name = _fileWrapper.CMesh.BoneNames[i].GetResolvedText()!;

            var boneRig = _fileWrapper.CMesh.BoneRigMatrices[i];
            Matrix4x4.Invert(boneRig, out var inverseBoneRig);
            inverseBoneRig.M44 = 1;


            nodes[i] = armature.CreateNode(name);
            nodes[i].WorldMatrix = RotY(YUp(inverseBoneRig));
        }

        _skin = _modelRoot.CreateSkin();

        if (nodes.Length == 1)
        {
            _skin.BindJoints(nodes[0].VisualParent.WorldMatrix, nodes);
        }
        else
        {
            _skin.BindJoints(nodes);
        }

        Matrix4x4 RotY(Matrix4x4 src)
        {
            var axisBaseChange = new Matrix4x4(
                0.0F, 0.0F, 1.0F, 0.0F,
                0.0F, 1.0F, 0.0F, 0.0F,
                -1.0F, 0.0F, 0.0F, 0.0F,
                0.0F, 0.0F, 0.0F, 1.0F);

            return Matrix4x4.Multiply(axisBaseChange, src);
        }

        Matrix4x4 YUp(Matrix4x4 src)
        {
            return src with
            {
                M12 = src.M13,
                M13 = -src.M12,

                M22 = src.M23,
                M23 = -src.M22,

                M32 = src.M33,
                M33 = -src.M32,

                M42 = src.M43,
                M43 = -src.M42,
                M44 = 1
            };
        }
    }
}
