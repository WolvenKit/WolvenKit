using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.Common.Services;
using Splat;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.IO
{
    public class CollisionReader : Red4Reader, IBufferReader
    {
        public CollisionReader(MemoryStream ms) : base(ms)
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
                _reader.BaseStream.Seek(node.NumActors * 48 + node.NumShapeInfos * 32, SeekOrigin.Begin);

                var positions = new List<Vector3>();
                var rotations = new List<Quaternion>();
                var scales = new List<Vector3>();

                for (int i = 0; i < node.NumShapePositions; i++)
                {
                    positions.Add(new Vector3()
                    {
                        X = _reader.ReadSingle(),
                        Y = _reader.ReadSingle(),
                        Z = _reader.ReadSingle()
                    });
                }

                for (int i = 0; i < node.NumShapeRotations; i++)
                {
                    rotations.Add(new Quaternion()
                    {
                        I = _reader.ReadSingle(),
                        J = _reader.ReadSingle(),
                        K = _reader.ReadSingle(),
                        R = _reader.ReadSingle()
                    });
                }

                for (int i = 0; i < node.NumScales; i++)
                {
                    scales.Add(new Vector3()
                    {
                        X = _reader.ReadSingle(),
                        Y = _reader.ReadSingle(),
                        Z = _reader.ReadSingle()
                    });
                }

                for (int i = 0; i < node.NumMaterials; i++)
                {
                    data.Materials.Add(_reader.ReadUInt64());
                }

                for (int i = 0; i < node.NumPresets; i++)
                {
                    data.Presets.Add(_reader.ReadUInt64());
                }

                // not sure how this is suppose to be used
                for (int i = 0; i < node.NumShapeIndices; i++)
                {
                    data.ShapeIndices.Add(_reader.ReadUInt32());
                }

                for (int i = 0; i < node.NumMaterialIndices; i++)
                {
                    data.MaterialIndices.Add(_reader.ReadByte());
                }

                _reader.BaseStream.Seek(0, SeekOrigin.Begin);

                for (int i = 0; i < node.NumActors; i++)
                {
                    var a = new CollisionActor();

                    data.Actors.Add(a);

                    a.Position.X.Bits = _reader.ReadInt32();
                    a.Position.Y.Bits = _reader.ReadInt32();
                    a.Position.Z.Bits = _reader.ReadInt32();
                    _reader.ReadInt32();

                    a.Orientation.I = _reader.ReadSingle();
                    a.Orientation.J = _reader.ReadSingle();
                    a.Orientation.K = _reader.ReadSingle();
                    a.Orientation.R = _reader.ReadSingle();

                    a.ShapeIndexStart = _reader.ReadUInt16();
                    a.NumShapes = _reader.ReadUInt16();

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

                for (int i = 0; i < node.NumShapeInfos; i++)
                {
                    var s = new CollisionShape();

                    data.Shapes.Add(s);

                    _reader.BaseStream.Seek(12, SeekOrigin.Current);

                    s.ShapeType = (physicsShapeType)_reader.ReadByte();

                    _reader.BaseStream.Seek(-13, SeekOrigin.Current);

                    if (s.ShapeType == physicsShapeType.TriangleMesh || s.ShapeType == physicsShapeType.ConvexMesh)
                    {
                        s.Hash = _reader.ReadUInt64();
                        _reader.ReadSingle();
                    }
                    else
                    {
                        s.Size.X = _reader.ReadSingle();
                        s.Size.Y = _reader.ReadSingle();
                        s.Size.Z = _reader.ReadSingle();
                    } 

                    var uk0 = _reader.ReadInt16(); // type
                    var uk1 = _reader.ReadInt16(); 
                    var uk2 = _reader.ReadInt16(); // materialIndexIndex
                    var uk3 = _reader.ReadInt16(); // numMaterials
                    var uk4 = _reader.ReadInt16(); // positionIndex
                    var uk5 = _reader.ReadInt16(); // rotationIndex

                    var uk6 = _reader.ReadByte(); // presetIndex
                    var uk7 = _reader.ReadByte(); // physicsProxyType?
                    var uk8 = _reader.ReadUInt16();
                    var uk9 = _reader.ReadUInt32();

                    s.Uks.Add((CInt16)uk1);
                    s.Uks.Add((CInt16)uk3);
                    s.Uks.Add((CUInt8)uk7);
                    s.Uks.Add((CUInt16)uk8);
                    s.Uks.Add((CUInt32)uk9);

                    s.Index = (ushort)uk2;

                    s.Preset = data.Presets[uk6];
                    s.Material = data.Materials[data.MaterialIndices[s.Index]];

                    if (uk4 != -1)
                    {
                        s.Position = positions[uk4];
                    }

                    if (uk5 != -1)
                    {
                        s.Rotation = rotations[uk5];
                    }

                    s.ProxyType = (physicsProxyType)uk7;
                }

                for (int i = 0; i < node.NumActors; i++)
                {
                    for (int shapeIndex = data.Actors[i].ShapeIndexStart; shapeIndex < data.Actors[i].ShapeIndexStart + data.Actors[i].NumShapes; shapeIndex++)
                    {
                        data.Actors[i].Shapes.Add(data.Shapes[shapeIndex]);
                    }
                }

            }
            catch (Exception)
            {

            }


            return EFileReadErrorCodes.NoError;
        }
    }
}
