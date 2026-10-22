using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class worldCookedCollisionNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedCollisionNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 48;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedCollisionNode_Class1();

            entry.Unknown1[0] = br.ReadCFloat();
            entry.Unknown1[1] = br.ReadCFloat();
            entry.Unknown1[2] = br.ReadCFloat();
            entry.Unknown1[3] = br.ReadCFloat();

            entry.Unknown2 = br.ReadCUInt64();
            entry.Unknown3 = br.ReadCUInt32();
            entry.Unknown4 = br.ReadCUInt16();
            entry.Unknown5 = br.ReadCUInt16();
            entry.Unknown6 = br.ReadCUInt16();
            entry.Unknown7 = br.ReadCUInt16();
            entry.Unknown8 = br.ReadCUInt16();
            entry.Unknown9 = br.ReadCUInt16();
            entry.Unknown10 = br.ReadCUInt16();
            entry.Unknown11 = br.ReadCUInt16();
            entry.Unknown12 = br.ReadCUInt16();
            entry.Unknown13 = br.ReadCUInt8();

            br.BaseReader.ReadByte(); // padding

            result.Unknown1.Add(entry);
        }

        Buffer.Data = result;

        LoadCompiledData(result.Unknown1);
    }

    protected void LoadCompiledData(CArray<worldCookedCollisionNode_Class1> infos)
    {
        using var ms = new MemoryStream(CompiledData.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var result = new worldCookedCollisionNode_Class2();

        foreach (var info in infos)
        {
            if (br.BaseStream.Position != info.Unknown3)
            {
                return;
            }

            var entry = new worldCookedCollisionNode_Class3();

            for (var i = 0; i < info.Unknown4; i++)
            {
                var subEntry = new worldCookedCollisionNode_Class4();

                subEntry.Unknown1.Position.X.Bits = br.ReadCInt32();
                subEntry.Unknown1.Position.Y.Bits = br.ReadCInt32();
                subEntry.Unknown1.Position.Z.Bits = br.ReadCInt32();
                br.BaseReader.ReadBytes(4); // padding

                subEntry.Unknown1.Orientation.I = br.ReadCFloat();
                subEntry.Unknown1.Orientation.J = br.ReadCFloat();
                subEntry.Unknown1.Orientation.K = br.ReadCFloat();
                subEntry.Unknown1.Orientation.R = br.ReadCFloat();

                subEntry.Unknown2 = br.ReadCUInt16();
                subEntry.Unknown3 = br.ReadCUInt16();
                subEntry.Unknown4 = br.ReadCInt16();
                subEntry.Unknown5 = br.ReadCUInt8();
                br.BaseReader.ReadBytes(9); // padding

                entry.Unknown1.Add(subEntry);
            }

            for (var i = 0; i < info.Unknown5; i++)
            {
                var subEntry = new worldCookedCollisionNode_Class5();

                subEntry.Unknown1.Pe = br.ReadCUInt8();

                for (var j = 0; j < 12; j++)
                {
                    subEntry.Unknown1.Ta[j] = br.ReadCUInt8();
                }
                br.BaseReader.ReadBytes(3); // padding

                subEntry.Unknown2 = br.ReadCUInt16();
                subEntry.Unknown3 = br.ReadCUInt16();
                subEntry.Unknown4 = br.ReadCInt16();
                subEntry.Unknown5 = br.ReadCInt16();
                subEntry.Unknown6 = br.ReadCUInt8();
                subEntry.Unknown7 = br.ReadCUInt8();
                br.BaseReader.ReadBytes(6); // padding

                entry.Unknown2.Add(subEntry);
            }

            for (var i = 0; i < info.Unknown6; i++)
            {
                var subEntry = new Vector3();

                subEntry.X = br.ReadCFloat();
                subEntry.Y = br.ReadCFloat();
                subEntry.Z = br.ReadCFloat();

                entry.Unknown3.Add(subEntry);
            }

            for (var i = 0; i < info.Unknown7; i++)
            {
                var subEntry = new Quaternion();

                subEntry.I = br.ReadCFloat();
                subEntry.J = br.ReadCFloat();
                subEntry.K = br.ReadCFloat();
                subEntry.R = br.ReadCFloat();

                entry.Unknown4.Add(subEntry);
            }

            for (var i = 0; i < info.Unknown8; i++)
            {
                var subEntry = new Vector3();

                subEntry.X = br.ReadCFloat();
                subEntry.Y = br.ReadCFloat();
                subEntry.Z = br.ReadCFloat();

                entry.Unknown5.Add(subEntry);
            }

            for (var i = 0; i < info.Unknown9; i++)
            {
                entry.Unknown6.Add((CName)br.BaseReader.ReadUInt64());
            }

            for (var i = 0; i < info.Unknown10; i++)
            {
                entry.Unknown7.Add((CName)br.BaseReader.ReadUInt64());
            }

            for (var i = 0; i < info.Unknown11; i++)
            {
                entry.Unknown8.Add(br.ReadCUInt32());
            }

            for (var i = 0; i < info.Unknown12; i++)
            {
                entry.Unknown9.Add(br.ReadCUInt8());
            }

            var paddingLen = ((ms.Position + 15U) & (~15)) - ms.Position;
            br.BaseReader.ReadBytes((int)paddingLen); // padding to 16 bytes

            result.Unknown1.Add(entry);
        }

        CompiledData.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedCollisionNode_Buffer data)
        {
            throw new Exception();
        }

        StoreCompiledData(data.Unknown1);

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 48);
        foreach (var entry in data.Unknown1)
        {
            bw.Write(entry.Unknown1[0]);
            bw.Write(entry.Unknown1[1]);
            bw.Write(entry.Unknown1[2]);
            bw.Write(entry.Unknown1[3]);

            bw.Write(entry.Unknown2);
            bw.Write(entry.Unknown3);
            bw.Write(entry.Unknown4);
            bw.Write(entry.Unknown5);
            bw.Write(entry.Unknown6);
            bw.Write(entry.Unknown7);
            bw.Write(entry.Unknown8);
            bw.Write(entry.Unknown9);
            bw.Write(entry.Unknown10);
            bw.Write(entry.Unknown11);
            bw.Write(entry.Unknown12);
            bw.Write(entry.Unknown13);

            bw.BaseWriter.Write((byte)0); // padding
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }

    protected void StoreCompiledData(CArray<worldCookedCollisionNode_Class1> infos)
    {
        if(CompiledData.Data is not worldCookedCollisionNode_Class2 data)
        {
            throw new Exception();
        }

        if (infos.Count != data.Unknown1.Count)
        {
            throw new Exception("Mismatch between collision node infos and compiled data entries count.");
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        for (var i = 0; i < data.Unknown1.Count; i++)
        {
            var entry = data.Unknown1[i];

            var paddingLen = ((ms.Position + 15U) & (~15)) - ms.Position;
            bw.BaseWriter.Write(new byte[paddingLen]); // padding to 16 bytes

            infos[i].Unknown3 = (CUInt32)bw.BaseStream.Position;

            infos[i].Unknown4 = (CUInt16)entry.Unknown1.Count;
            foreach (var actor in entry.Unknown1)
            {
                bw.Write(actor.Unknown1.Position.X.Bits);
                bw.Write(actor.Unknown1.Position.Y.Bits);
                bw.Write(actor.Unknown1.Position.Z.Bits);
                bw.BaseWriter.Write(new byte[4]); // padding

                bw.Write(actor.Unknown1.Orientation.I);
                bw.Write(actor.Unknown1.Orientation.J);
                bw.Write(actor.Unknown1.Orientation.K);
                bw.Write(actor.Unknown1.Orientation.R);

                bw.Write(actor.Unknown2);
                bw.Write(actor.Unknown3);
                bw.Write(actor.Unknown4);
                bw.Write(actor.Unknown5);
                bw.BaseWriter.Write(new byte[9]); // padding
            }

            infos[i].Unknown5 = (CUInt16)entry.Unknown2.Count;
            foreach (var shapeInfo in entry.Unknown2)
            {
                bw.Write(shapeInfo.Unknown1.Pe);
                foreach (var ta in shapeInfo.Unknown1.Ta)
                {
                    bw.Write(ta);
                }

                bw.BaseWriter.Write(new byte[3]); // padding

                bw.Write(shapeInfo.Unknown2);
                bw.Write(shapeInfo.Unknown3);
                bw.Write(shapeInfo.Unknown4);
                bw.Write(shapeInfo.Unknown5);
                bw.Write(shapeInfo.Unknown6);
                bw.Write(shapeInfo.Unknown7);
                bw.BaseWriter.Write(new byte[6]); // padding
            }

            infos[i].Unknown6 = (CUInt16)entry.Unknown3.Count;
            foreach (var shapePosition in entry.Unknown3)
            {
                bw.Write(shapePosition.X);
                bw.Write(shapePosition.Y);
                bw.Write(shapePosition.Z);
            }

            infos[i].Unknown7 = (CUInt16)entry.Unknown4.Count;
            foreach (var shapeRotation in entry.Unknown4)
            {
                bw.Write(shapeRotation.I);
                bw.Write(shapeRotation.J);
                bw.Write(shapeRotation.K);
                bw.Write(shapeRotation.R);
            }

            infos[i].Unknown8 = (CUInt16)entry.Unknown5.Count;
            foreach (var scale in entry.Unknown5)
            {
                bw.Write(scale.X);
                bw.Write(scale.Y);
                bw.Write(scale.Z);
            }

            infos[i].Unknown9 = (CUInt16)entry.Unknown6.Count;
            foreach (var material in entry.Unknown6)
            {
                bw.BaseWriter.Write((ulong)material);
            }

            infos[i].Unknown10 = (CUInt16)entry.Unknown7.Count;
            foreach (var preset in entry.Unknown7)
            {
                bw.BaseWriter.Write((ulong)preset);
            }

            infos[i].Unknown11 = (CUInt16)entry.Unknown8.Count;
            foreach (var shapeIndex in entry.Unknown8)
            {
                bw.Write(shapeIndex);
            }

            infos[i].Unknown12 = (CUInt16)entry.Unknown9.Count;
            foreach (var materialIndex in entry.Unknown9)
            {
                bw.Write(materialIndex);
            }
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        CompiledData.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedCollisionNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedCollisionNode_Class1> Unknown1 { get; set; } = new();
}

public class worldCookedCollisionNode_Class1 : RedBaseClass
{
    [RED("unknown1", 4)]
    [REDProperty(IsIgnored = true)]
    public CArrayFixedSize<CFloat> Unknown1
    {
        get => GetPropertyValue<CArrayFixedSize<CFloat>>();
        set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 Unknown2
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown3
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown4
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown5
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown6
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown7
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown8")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown8
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown9")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown9
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown10")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown10
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown11")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown11
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown12")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown12
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown13")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown13
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionNode_Class1()
    {
        Unknown1 = new CArrayFixedSize<CFloat>(4);
    }
}

public class worldCookedCollisionNode_Class2 : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedCollisionNode_Class3> Unknown1 { get; set; } = new();
}

public class worldCookedCollisionNode_Class3 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldCookedCollisionNode_Class4> Unknown1
    {
        get => GetPropertyValue<CArray<worldCookedCollisionNode_Class4>>();
        set => SetPropertyValue<CArray<worldCookedCollisionNode_Class4>>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldCookedCollisionNode_Class5> Unknown2
    {
        get => GetPropertyValue<CArray<worldCookedCollisionNode_Class5>>();
        set => SetPropertyValue<CArray<worldCookedCollisionNode_Class5>>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> Unknown3
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CArray<Quaternion> Unknown4
    {
        get => GetPropertyValue<CArray<Quaternion>>();
        set => SetPropertyValue<CArray<Quaternion>>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> Unknown5
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Unknown6
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Unknown7
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("unknown8")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt32> Unknown8
    {
        get => GetPropertyValue<CArray<CUInt32>>();
        set => SetPropertyValue<CArray<CUInt32>>(value);
    }

    [RED("unknown9")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt8> Unknown9
    {
        get => GetPropertyValue<CArray<CUInt8>>();
        set => SetPropertyValue<CArray<CUInt8>>(value);
    }

    public worldCookedCollisionNode_Class3()
    {
        Unknown1 = new();
        Unknown2 = new();
        Unknown3 = new();
        Unknown4 = new();
        Unknown5 = new();
        Unknown6 = new();
        Unknown7 = new();
        Unknown8 = new();
        Unknown9 = new();
    }
}

public class worldCookedCollisionNode_Class4 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public WorldTransform Unknown1
    {
        get => GetPropertyValue<WorldTransform>();
        set => SetPropertyValue<WorldTransform>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown2
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown3
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CInt16 Unknown4
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown5
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionNode_Class4()
    {
        Unknown1 = new();
    }
}

public class worldCookedCollisionNode_Class5 : RedBaseClass
{
    [RED("unknwon1")]
    [REDProperty(IsIgnored = true)]
    public physicsGeometryKey Unknown1
    {
        get => GetPropertyValue<physicsGeometryKey>();
        set => SetPropertyValue<physicsGeometryKey>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown2
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown3
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CInt16 Unknown4
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CInt16 Unknown5
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown6
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown7
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionNode_Class5()
    {
        Unknown1 = new();
    }
}
