using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.IO;

public class CollisionReader : Red4Reader, IBufferReader
{
    public CollisionReader(Stream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not worldCollisionNode node)
        {
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        var data = new CollisionBuffer();

        buffer.Data = data;

        try
        { 
            _reader.BaseStream.Seek((node.NumActors * 48) + (node.NumShapeInfos * 32), SeekOrigin.Begin);

            var materials = new List<CName>();
            var materialIndices = new List<byte>();
            var presets = new List<CName>();

            var positions = new List<Vector3>();
            var rotations = new List<Quaternion>();
            var scales = new List<Vector3>();

            for (var i = 0; i < node.NumShapePositions; i++)
            {
                positions.Add(new Vector3()
                {
                    X = _reader.ReadSingle(),
                    Y = _reader.ReadSingle(),
                    Z = _reader.ReadSingle()
                });
            }

            for (var i = 0; i < node.NumShapeRotations; i++)
            {
                rotations.Add(new Quaternion()
                {
                    I = _reader.ReadSingle(),
                    J = _reader.ReadSingle(),
                    K = _reader.ReadSingle(),
                    R = _reader.ReadSingle()
                });
            }

            for (var i = 0; i < node.NumScales; i++)
            {
                scales.Add(new Vector3()
                {
                    X = _reader.ReadSingle(),
                    Y = _reader.ReadSingle(),
                    Z = _reader.ReadSingle()
                });
            }

            for (var i = 0; i < node.NumMaterials; i++)
            {
                materials.Add(_reader.ReadUInt64());
            }

            for (var i = 0; i < node.NumPresets; i++)
            {
                presets.Add(_reader.ReadUInt64());
            }

            // seems to be always 1:1, skip for now
            for (var i = 0; i < node.NumShapeIndices; i++)
            {
                _reader.ReadUInt32();
            }

            for (var i = 0; i < node.NumMaterialIndices; i++)
            {
                materialIndices.Add(_reader.ReadByte());
            }

            _reader.BaseStream.Seek(node.NumActors * 48, SeekOrigin.Begin);

            var shapes = new List<CollisionShape>();

            for (var i = 0; i < node.NumShapeInfos; i++)
            {
                // peek to get the type
                _reader.BaseStream.Seek(12, SeekOrigin.Current);
                var shapeType = (physicsShapeType)_reader.ReadInt16();
                _reader.BaseStream.Seek(-14, SeekOrigin.Current);

                CollisionShape s;
                if (shapeType is physicsShapeType.TriangleMesh or physicsShapeType.ConvexMesh)
                {
                    s = new CollisionShapeMesh
                    {
                        Hash = _reader.ReadUInt64()
                    };
                    _reader.ReadSingle(); // always 0
                }
                else
                {
                    s = new CollisionShapeSimple {
                        Size =
                        {
                            X = _reader.ReadSingle(),
                            Y = _reader.ReadSingle(),
                            Z = _reader.ReadSingle()
                        }
                    };
                }

                s.ShapeType = (physicsShapeType)_reader.ReadInt16();

                s.Uk1 = _reader.ReadInt16(); // always 0

                var materialStartIndex = _reader.ReadInt16();
                var numMaterials = _reader.ReadInt16();
                for (var j = 0; j < numMaterials; j++)
                {
                    s.Materials.Add(materials[materialIndices[materialStartIndex + j]]);
                }

                var positionIndex = _reader.ReadInt16();
                if (positionIndex != -1)
                {
                    s.Position = positions[positionIndex];
                }

                var rotationIndex = _reader.ReadInt16();
                if (rotationIndex != -1)
                {
                    s.Rotation = rotations[rotationIndex];
                }

                s.Preset = presets[_reader.ReadByte()];
                s.ProxyType = (physicsProxyType)_reader.ReadByte();

                s.Uk2 = _reader.ReadUInt16(); // always 0
                s.Uk3 = _reader.ReadUInt32(); // always 0

                shapes.Add(s);
            }

            _reader.BaseStream.Seek(0, SeekOrigin.Begin);

            for (var i = 0; i < node.NumActors; i++)
            {
                var a = new CollisionActor();

                data.Actors.Add(a);

                a.Position.X.Bits = _reader.ReadInt32();
                a.Position.Y.Bits = _reader.ReadInt32();
                a.Position.Z.Bits = _reader.ReadInt32();
                _reader.ReadInt32();  // always 0

                a.Orientation.I = _reader.ReadSingle();
                a.Orientation.J = _reader.ReadSingle();
                a.Orientation.K = _reader.ReadSingle();
                a.Orientation.R = _reader.ReadSingle();

                var shapeStartIndex = _reader.ReadUInt16();
                var shapeCount = _reader.ReadUInt16();
                for (int shapeIndex = shapeStartIndex; shapeIndex < shapeStartIndex + shapeCount; shapeIndex++)
                {
                    data.Actors[i].Shapes.Add(shapes[shapeIndex]);
                }

                var scaleIndex = _reader.ReadInt16();

                if (scaleIndex != -1)
                {
                    a.Scale = scales[scaleIndex];
                }
                else
                {
                    a.Scale = new Vector3()
                    {
                        X = 1,
                        Y = 1,
                        Z = 1
                    };
                }

                a.Uk1 = _reader.ReadInt16(); // EMaterialVertexFactory?
                a.Uk2 = _reader.ReadUInt64();
            }
        }
        catch (Exception)
        {
            // ignore
        }


        return EFileReadErrorCodes.NoError;
    }
}