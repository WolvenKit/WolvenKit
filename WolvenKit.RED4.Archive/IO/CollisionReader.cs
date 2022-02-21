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

namespace WolvenKit.RED4.Archive.IO
{
    public class CollisionReader : Red4Reader, IBufferReader
    {
        public CollisionReader(MemoryStream ms) : base(ms)
        {

        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            if (buffer.Parent is not worldCollisionNode node)
            {
                return EFileReadErrorCodes.UnsupportedVersion;
            }

            var data = new CollisionBuffer();

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

            for (int i = 0; i < node.NumShapePositions; i++)
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

            // etc

            _reader.BaseStream.Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < node.NumActors; i++)
            {
                var a = new CollisionActor();

                a.Position.X.Bits = _reader.ReadInt32();
                a.Position.Y.Bits = _reader.ReadInt32();
                a.Position.Z.Bits = _reader.ReadInt32();
                _reader.ReadInt32();

                a.Orientation.I = _reader.ReadSingle();
                a.Orientation.J = _reader.ReadSingle();
                a.Orientation.K = _reader.ReadSingle();
                a.Orientation.R = _reader.ReadSingle();

                a.Shape = _reader.ReadUInt16();
                a.Uk1 = _reader.ReadInt16();
                a.Uk2 = _reader.ReadInt16();
                a.Uk3 = _reader.ReadInt16();
                a.Uk4 = _reader.ReadUInt64();

                data.Actors.Add(a);
            }

            for (int i = 0; i < node.NumShapeInfos; i++)
            {
                var s = new CollisionShape();

                s.Hash = _reader.ReadUInt64();

                // etc
                _reader.ReadUInt64();
                _reader.ReadUInt64();
                _reader.ReadUInt64();

                data.Shapes.Add(s);
            }

            buffer.Data = data;

            return EFileReadErrorCodes.NoError;
        }
    }
}
