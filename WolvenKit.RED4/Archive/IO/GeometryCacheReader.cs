using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class GeometryCacheReader : Red4Reader, IBufferReader
{
    public GeometryCacheReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not physicsGeometryCache pg)
        {
            //return EFileReadErrorCodes.UnsupportedVersion;
        }

        var data = new GeometryCacheBuffer();

        var index = 0;

        try
        {

            while (_reader.BaseStream.Position < _reader.BaseStream.Length)
            {
                var id = _reader.ReadChars(8);

                if (id[4] == 'C')
                {
                    var entry = new CVXMCacheEntry();
                    data.Entries.Add(entry);

                    _reader.ReadUInt32(); // 13
                    _reader.ReadUInt32(); // 0
                    _reader.ReadChars(8); // ICE.CLHL
                    _reader.ReadUInt32(); // 8
                    _reader.ReadChars(8); // ICE.CVHL
                    _reader.ReadUInt32(); // 8

                    var vertexCount = _reader.ReadUInt32();
                    var edgeCount = _reader.ReadUInt32();
                    var faceDataCount = _reader.ReadUInt32();
                    var ukCount = _reader.ReadUInt32();

                    for (int i = 0; i < vertexCount; i++)
                    {
                        entry.Vertices.Add(new Vector3()
                        {
                            X = _reader.ReadSingle(),
                            Y = _reader.ReadSingle(),
                            Z = _reader.ReadSingle()
                        });
                    }

                    for (int i = 0; i < faceDataCount; i++)
                    {
                        var faceData = new CVXMCacheFaceData()
                        {
                            Normal = new Vector3()
                            {
                                X = _reader.ReadSingle(),
                                Y = _reader.ReadSingle(),
                                Z = _reader.ReadSingle()
                            },
                            Uk1 = _reader.ReadSingle()
                        };
                        var bits = _reader.ReadUInt16();
                        faceData.Uk2 = (CUInt8)((bits & 0b1100000000000000) >> 14);
                        faceData.Id = (CUInt16)(bits & 0b0011111111111111);
                        faceData.VertexCount = _reader.ReadByte();
                        faceData.Uk3 = _reader.ReadByte();
                        entry.FaceData.Add(faceData);
                    }

                    for (int i = 0; i < faceDataCount; i++)
                    {
                        var ra = new CArray<CUInt8>();
                        for (int j = 0; j < entry.FaceData[i]!.VertexCount; j++)
                        {
                            ra.Add(_reader.ReadByte());
                        }
                        entry.Faces.Add(ra);
                    }


                    for (int i = 0; i < edgeCount; i++)
                    {
                        var ra = new CArray<CUInt8>();
                        ra.Add(_reader.ReadByte());
                        ra.Add(_reader.ReadByte());
                        entry.Edges.Add(ra);
                    }

                    for (int i = 0; i < vertexCount; i++)
                    {
                        var ra = new CArray<CUInt8>();
                        ra.Add(_reader.ReadByte());
                        ra.Add(_reader.ReadByte());
                        ra.Add(_reader.ReadByte());
                        entry.Triangles.Add(ra);
                    }

                    _reader.ReadUInt32(); // 0

                    entry.Bounds.Min.X = _reader.ReadSingle();
                    entry.Bounds.Min.Y = _reader.ReadSingle();
                    entry.Bounds.Min.Z = _reader.ReadSingle();

                    entry.Bounds.Max.X = _reader.ReadSingle();
                    entry.Bounds.Max.Y = _reader.ReadSingle();
                    entry.Bounds.Max.Z = _reader.ReadSingle();

                    entry.Mass = _reader.ReadSingle();

                    for (int i = 0; i < 6; i++)
                    {
                        entry.Hashes.Add(_reader.ReadUInt64());
                    }

                    entry.Uk1 = _reader.ReadSingle();

                    if (entry.Uk1 < 0)
                    {
                        entry.Uk2 = new Vector4()
                        {
                            X = _reader.ReadSingle(),
                            Y = _reader.ReadSingle(),
                            Z = _reader.ReadSingle(),
                            W = _reader.ReadSingle()
                        };
                    }
                    else
                    {
                        _reader.ReadChars(8); // ICE.SUPM
                        _reader.ReadUInt32(); // 8
                        _reader.ReadChars(8); // ICE.GUAS
                        _reader.ReadUInt32(); // 8

                        _reader.ReadUInt32();

                        var uk3Count = _reader.ReadUInt32();

                        for (int i = 0; i < uk3Count; i++)
                        {
                            var ra = new CArray<CUInt8>();
                            ra.Add(_reader.ReadByte());
                            ra.Add(_reader.ReadByte());
                            entry.Uk3.Add(ra);
                        }

                        _reader.ReadChars(8); // ICE.VALE
                        _reader.ReadUInt32();

                        var uk5Count = _reader.ReadUInt32();
                        var uk7Count = _reader.ReadUInt32();

                        entry.Uk4 = _reader.ReadUInt32();

                        for (int i = 0; i < uk5Count; i++)
                        {
                            entry.Uk5.Add(_reader.ReadByte());
                        }

                        for (int i = 0; i < 16; i++)
                        {
                            entry.Uk6.Add(_reader.ReadByte());
                        }

                        for (int i = 0; i < uk7Count; i++)
                        {
                            entry.Uk7.Add(_reader.ReadByte());
                        }
                    }
                }
                else
                {
                    var entry = new MeshCacheEntry();
                    data.Entries.Add(entry);

                    _reader.ReadUInt32(); // 15
                    _reader.ReadUInt32(); // 1
                    entry.Flags = _reader.ReadUInt32();

                    var vertexCount = _reader.ReadInt32();
                    var faceCount = _reader.ReadInt32();

                    for (int i = 0; i < vertexCount; i++)
                    {
                        entry.Vertices.Add(new Vector3()
                        {
                            X = _reader.ReadSingle(),
                            Y = _reader.ReadSingle(),
                            Z = _reader.ReadSingle()
                        });
                    }

                    for (int i = 0; i < faceCount; i++)
                    {
                        var ra = new CArray<CUInt16>();
                        if ((entry.Flags & 0b1000) > 0)
                        {
                            ra.Add(_reader.ReadUInt16());
                            ra.Add(_reader.ReadUInt16());
                            ra.Add(_reader.ReadUInt16());
                        }
                        else
                        {
                            ra.Add(_reader.ReadByte());
                            ra.Add(_reader.ReadByte());
                            ra.Add(_reader.ReadByte());
                        }
                        entry.Faces.Add(ra);
                    }

                    if ((entry.Flags & 0b1) > 0)
                    {
                        for (int i = 0; i < faceCount; i++)
                        {
                            entry.Materials.Add(_reader.ReadUInt16());
                        }
                    }

                    _reader.ReadBytes(4); // BV4

                    entry.Uk1 = _reader.ReadUInt32(); // 2, num of materials?

                    entry.CenterOfMass = new Vector3()
                    {
                        X = _reader.ReadSingle(),
                        Y = _reader.ReadSingle(),
                        Z = _reader.ReadSingle()
                    };

                    entry.Mass = _reader.ReadSingle();

                    entry.Uk2 = _reader.ReadUInt32(); // 4, 2, 0?

                    for (int i = 0; i < 6; i++)
                    {
                        entry.Uk3.Add(_reader.ReadSingle());
                    }

                    var uvCount = _reader.ReadUInt32();

                    for (int i = 0; i < uvCount; i++)
                    {
                        var uv = new CArray<CArray<CFloat>>();
                        for (int j = 0; j < 4; j++)
                        {
                            var ra = new CArray<CFloat>();
                            ra.Add(_reader.ReadUInt16() / ushort.MaxValue);
                            ra.Add(_reader.ReadUInt16() / ushort.MaxValue);
                            uv.Add(ra);
                        }
                        entry.Uvs.Add(uv);
                    }

                    entry.Uk4 = _reader.ReadUInt32();

                    entry.Bounds.Min.X = _reader.ReadSingle();
                    entry.Bounds.Min.Y = _reader.ReadSingle();
                    entry.Bounds.Min.Z = _reader.ReadSingle();

                    entry.Bounds.Max.X = _reader.ReadSingle();
                    entry.Bounds.Max.Y = _reader.ReadSingle();
                    entry.Bounds.Max.Z = _reader.ReadSingle();

                    var faceFlagCount = _reader.ReadUInt32();

                    for (int i = 0; i < faceFlagCount; i++)
                    {
                        entry.FaceFlags.Add(_reader.ReadByte());
                    }
                }
                index++;
            }
        }
        catch (Exception)
        {
            //Locator.Current.GetService<ILoggerService>().Error(index.ToString());
        }

        buffer.Data = data;


        return EFileReadErrorCodes.NoError;

    }
}