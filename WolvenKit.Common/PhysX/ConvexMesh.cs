using System;
using System.IO;
using SharpDX;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Common.PhysX;

public class ConvexMesh : PhysXMesh
{
    public ConvexHullData HullData { get; set; } = new();
    public uint Nb { get; set; }
    public float Mass { get; set; }
    public Matrix3x3 Inertia { get; set; }
    public BigConvexData BigConvexData { get; set; } = new();

    public bool Load(BinaryReader reader, PhysXHeader header)
    {
        if (header.Type1 != "NXS" || header.Type2 != "CVXM")
        {
            throw new Exception();
        }

        if (header.Version != 13)
        {
            throw new NotSupportedException();
        }

        // unused
        var serialFlags = reader.ReadUInt32();

        HullData.Load(reader);

        var geomEpsilon = reader.ReadSingle();
        HullData.AABB = reader.BaseStream.ReadStruct<Bounds3>();

        var mMass = reader.ReadSingle();
        if (mMass != -1.0f)
        {
            Inertia = reader.BaseStream.ReadStruct<Matrix3x3>();
            HullData.CenterOfMass = reader.BaseStream.ReadStruct<Vector3>();
        }

        var gaussMapFlag = reader.ReadSingle();
        if (gaussMapFlag != -1.0f)
        {
            if (gaussMapFlag != 1.0f)
            {
                throw new Exception();
            }

            BigConvexData.Load(reader);
        }

        HullData.Internal = reader.BaseStream.ReadStruct<InternalObjectsData>();

        return true;
    }
}