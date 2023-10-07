using System;
using System.Collections.Generic;
using System.IO;
using DynamicData;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;
using Vector3 = SharpDX.Vector3;

namespace WolvenKit.App.Helpers;

public class GeometryCacheReaderLite
{
    public static SimpleGeometryCacheBuffer ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not physicsGeometryCache pg)
        {
            throw new Exception();
        }

        var data = new SimpleGeometryCacheBuffer();

        using var ms = new MemoryStream(buffer.GetBytes());
        using var br = new BinaryReader(ms);

        while (br.BaseStream.Position < br.BaseStream.Length)
        {
            var id = new string(br.ReadChars(8));

            if (id == "NXS\x0001MESH")
            {
                var entry = new SimpleMeshCacheEntry();

                ms.Position += 8;

                var flags = br.ReadUInt32();

                var vertexCount = br.ReadInt32();
                var faceCount = br.ReadInt32();

                for (var i = 0; i < vertexCount; i++)
                {
                    entry.Vertices.Add(new Vector3()
                    {
                        X = br.ReadSingle(),
                        Y = br.ReadSingle(),
                        Z = br.ReadSingle()
                    });
                }

                for (var i = 0; i < faceCount; i++)
                {
                    var ra = new List<ushort>();
                    if ((flags & 0b1000) > 0)
                    {
                        ra.Add(br.ReadUInt16());
                        ra.Add(br.ReadUInt16());
                        ra.Add(br.ReadUInt16());
                    }
                    else
                    {
                        ra.Add(br.ReadByte());
                        ra.Add(br.ReadByte());
                        ra.Add(br.ReadByte());
                    }
                    entry.Faces.Add(ra);
                }

                if ((flags & 0b1) > 0)
                {
                    ms.Position += faceCount * 2;
                }

                ms.Position += 52;

                var uvCount = br.ReadUInt32();
                ms.Position += uvCount * 4 * 4;

                ms.Position += 28;

                var faceFlagCount = br.ReadUInt32();
                ms.Position += faceFlagCount;

                data.Entries.Add(entry);
            }
            else if (id == "NXS\x0001CVXM")
            {
                var entry = new SimpleCVXMCacheEntry();

                ms.Position += 32;

                var vertexCount = br.ReadUInt32();
                var edgeCount = br.ReadUInt32();
                var faceDataCount = br.ReadUInt32();

                ms.Position += 4;

                for (var i = 0; i < vertexCount; i++)
                {
                    entry.Vertices.Add(new SharpDX.Vector3()
                    {
                        X = br.ReadSingle(),
                        Y = br.ReadSingle(),
                        Z = br.ReadSingle()
                    });
                }

                var vertexCount2 = new byte[faceDataCount];

                for (var i = 0; i < faceDataCount; i++)
                {
                    entry.FaceData.Add(new Vector3()
                    {
                        X = br.ReadSingle(),
                        Y = br.ReadSingle(),
                        Z = br.ReadSingle()
                    });

                    ms.Position += 6;
                    vertexCount2[i] = br.ReadByte();
                    ms.Position += 1;
                }

                foreach (var c in vertexCount2)
                {
                    var lst = new List<byte>();
                    for (var i = 0; i < c; i++)
                    {
                        lst.Add(br.ReadByte());
                    }
                    entry.Faces.Add(lst);
                }

                ms.Position += edgeCount * 2;
                ms.Position += vertexCount * 3;
                ms.Position += 80;

                var uk1 = br.ReadSingle();

                if (uk1 < 0)
                {
                    ms.Position += 16;
                }
                else
                {
                    ms.Position += 28;

                    var uk3Count = br.ReadUInt32();
                    ms.Position += uk3Count * 2;

                    ms.Position += 12;

                    var uk4Count = br.ReadUInt32();
                    var uk5Count = br.ReadUInt32();

                    ms.Position += uk4Count;
                    ms.Position += 20;
                    ms.Position += uk5Count;
                }

                data.Entries.Add(entry);
            }
            else
            {
                throw new Exception();
            }
        }

        return data;
    }
}