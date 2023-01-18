using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class CollisionWriter : Red4Writer
{
    public CollisionWriter(MemoryStream ms) : base(ms)
    {

    }

    public void WriteBuffer(CollisionBuffer collisionBuffer, worldCollisionNode node)
    {
        var shapes = new List<CollisionShape>();
        var shapeIndices = new List<uint>();

        var scales = new List<Vector3>();
        var positions = new List<Vector3>();
        var rotations = new List<Quaternion>();
        var presets = new List<ulong>();
        var materials = new List<ulong>();
        var materialIndices = new List<byte>();

        foreach (var actor in collisionBuffer.Actors)
        {
            _writer.Write(actor.Position.X.Bits);
            _writer.Write(actor.Position.Y.Bits);
            _writer.Write(actor.Position.Z.Bits);
            _writer.Write((int)0);

            _writer.Write(actor.Orientation.I);
            _writer.Write(actor.Orientation.J);
            _writer.Write(actor.Orientation.K);
            _writer.Write(actor.Orientation.R);

            _writer.Write((ushort)shapes.Count);
            shapes.AddRange(actor.Shapes);
            _writer.Write((ushort)actor.Shapes.Count);

            if (actor.Scale.X != 1 || actor.Scale.Y != 1 || actor.Scale.Z != 1)
            {
                _writer.Write(GetIndex(ref scales, actor.Scale));
            }
            else
            {
                _writer.Write((short)-1);
            }

            _writer.Write(actor.Uk1);
            _writer.Write(actor.Uk2);
        }

        for (int i = 0; i < shapes.Count; i++)
        {
            var shape = shapes[i];

            if (shape is CollisionShapeMesh meshShape)
            {
                _writer.Write(meshShape.Hash);
                _writer.Write((float)0);
            }
            else if (shape is CollisionShapeSimple simpleShape)
            {
                _writer.Write(simpleShape.Size.X);
                _writer.Write(simpleShape.Size.Y);
                _writer.Write(simpleShape.Size.Z);
            }

            _writer.Write((short)(Enums.physicsShapeType)shape.ShapeType);

            _writer.Write(shape.Uk1);

            if (shape.Materials.Count == 0)
            {
                shape.Materials.Add(0);
            }

            for (var j = 0; j < shape.Materials.Count; j++)
            {
                var material = shape.Materials[j];

                var materialIndex = materials.IndexOf(material);
                if (materialIndex == -1)
                {
                    materials.Add(material);
                    materialIndex = materials.Count - 1;
                }

                materialIndices.Add((byte)materialIndex);
                var materialIndexIndex = materialIndices.Count - 1;

                if (j == 0)
                {
                    _writer.Write((short)materialIndexIndex);
                    _writer.Write((short)shape.Materials.Count);
                }
            }

            // Not sure...
            if (shape.Position.X != 0 || shape.Position.Y != 0 || shape.Position.Z != 0)
            {
                _writer.Write(GetIndex(ref positions, shape.Position));
            }
            else
            {
                _writer.Write((short)-1);
            }

            // Not sure...
            if (shape.Rotation.I != 0 || shape.Rotation.J != 0 || shape.Rotation.K != 0 || shape.Rotation.R != 1)
            {
                _writer.Write(GetIndex(ref rotations, shape.Rotation));
            }
            else
            {
                _writer.Write((short)-1);
            }

            var presetIndex = presets.IndexOf(shape.Preset);
            if (presetIndex != -1)
            {
                _writer.Write((byte)presetIndex);
            }
            else
            {
                presets.Add(shape.Preset);
                _writer.Write((byte)(presets.Count - 1));
            }

            _writer.Write((byte)(Enums.physicsProxyType)shape.ProxyType);

            _writer.Write(shape.Uk2);
            _writer.Write(shape.Uk3);

            shapeIndices.Add((uint)i);
        }

        foreach (var position in positions)
        {
            _writer.Write(position.X);
            _writer.Write(position.Y);
            _writer.Write(position.Z);
        }

        foreach (var rotation in rotations)
        {
            _writer.Write(rotation.I);
            _writer.Write(rotation.J);
            _writer.Write(rotation.K);
            _writer.Write(rotation.R);
        }

        foreach (var scale in scales)
        {
            _writer.Write(scale.X);
            _writer.Write(scale.Y);
            _writer.Write(scale.Z);
        }

        foreach (var material in materials)
        {
            _writer.Write(material);
        }

        foreach (var preset in presets)
        {
            _writer.Write(preset);
        }

        // how???
        foreach (var shapeIndex in shapeIndices)
        {
            _writer.Write(shapeIndex);
        }

        foreach (var materialIndex in materialIndices)
        {
            _writer.Write(materialIndex);
        }

        node.NumActors = (CUInt16)collisionBuffer.Actors.Count;
        node.NumShapeInfos = (CUInt16)shapeIndices.Count;
        node.NumShapePositions = (CUInt16)positions.Count;
        node.NumShapeRotations = (CUInt16)rotations.Count;
        node.NumScales = (CUInt16)scales.Count;
        node.NumMaterials = (CUInt16)materials.Count;
        node.NumPresets = (CUInt16)presets.Count;
        node.NumMaterialIndices = (CUInt16)materialIndices.Count;
        node.NumShapeIndices = (CUInt16)shapeIndices.Count;

        // TODO: could be array of physicsStaticCollisionShapeCategory of physicsShapeType
        // node.StaticCollisionShapeCategories
    }

    private short GetIndex(ref List<Vector3> list, Vector3 value)
    {
        for (short i = 0; i < list.Count; i++)
        {
            if (list[i].X == value.X && list[i].Y == value.Y && list[i].Z == value.Z)
            {
                return i;
            }
        }

        list.Add(value);
        return (short)(list.Count - 1);
    }

    private short GetIndex(ref List<Quaternion> list, Quaternion value)
    {
        for (short i = 0; i < list.Count; i++)
        {
            if (list[i].I == value.I && list[i].J == value.J && list[i].K == value.K && list[i].R == value.R)
            {
                return i;
            }
        }

        list.Add(value);
        return (short)(list.Count - 1);
    }
}
