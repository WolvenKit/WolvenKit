using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.Common.PhysX;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.RED4;

public class GeometryCacheReader
{
    public static List<PhysXMesh> ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not physicsGeometryCache pg)
        {
            throw new Exception();
        }

        var result = new List<PhysXMesh>();

        using var ms = new MemoryStream(buffer.GetBytes());
        using var br = new BinaryReader(ms);

        while (br.BaseStream.Position < br.BaseStream.Length)
        {
            var header = PhysXHelper.ReadHeader(br);

            if (header is { Type1: "NXS", Type2: "MESH" })
            {
                var triangleMesh = new BV4TriangleMesh();
                triangleMesh.Load(br, header);

                result.Add(triangleMesh);
            }
            else if (header is { Type1: "NXS", Type2: "CVXM" })
            {
                var convexMesh = new ConvexMesh();
                convexMesh.Load(br, header);

                result.Add(convexMesh);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        return result;
    }
}