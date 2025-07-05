using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class gameSmartObjectAnimationDatabase : IRedCustomData
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CArray<gameSmartObjectAnimationDatabase_App1> Unk1
    {
        get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App1>>();
        set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App1>>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<gameSmartObjectAnimationDatabase_App3> Unk2
    {
        get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App3>>();
        set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App3>>(value);
    }

    [RED("pathHashes")]
    [REDProperty(IsIgnored = true)]
    public CArray<gameSmartObjectAnimationDatabase_PathHashPair> PathHashes
    {
        get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_PathHashPair>>();
        set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_PathHashPair>>(value);
    }

    partial void PostConstruct()
    {
        Unk1 = new CArray<gameSmartObjectAnimationDatabase_App1>();
        Unk2 = new CArray<gameSmartObjectAnimationDatabase_App3>();
        PathHashes = new CArray<gameSmartObjectAnimationDatabase_PathHashPair>();
    }

    public void CustomRead(Red4Reader reader, uint size)
    {
        Unk1 = new CArray<gameSmartObjectAnimationDatabase_App1>();
        Unk2 = new CArray<gameSmartObjectAnimationDatabase_App3>();
        PathHashes = new CArray<gameSmartObjectAnimationDatabase_PathHashPair>();

        var unk1 = reader.BaseReader.ReadInt32();
        if (unk1 != -1)
        {
            throw new TodoException();
        }

        var cnt1 = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt1; i++)
        {
            var entry1 = new gameSmartObjectAnimationDatabase_App1();

            entry1.Unk1 = reader.ReadCName();

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (int j = 0; j < cnt2; j++)
            {
                // TODO: I almost certain that this structure is wrong

                var entry2 = new gameSmartObjectAnimationDatabase_App2();


                // Some kind of frames?
                var cnt3 = reader.BaseReader.ReadVLQInt32();
                for (int k = 0; k < cnt3; k++)
                {
                    entry2.Unk2.Add(ReadBox());
                }

                entry2.EndPoint = ReadBox();
                entry2.StartPoint = ReadBox();

                entry2.AnimationSet = new CResourceReference<animAnimSet>(reader.BaseReader.ReadUInt64());

                entry1.Unk2.Add(entry2);
            }
            entry1.Unk3 = reader.ReadCUInt32();

            Unk1.Add(entry1);
        }

        var cnt4 = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt4; i++)
        {
            var entry1 = new gameSmartObjectAnimationDatabase_App3();

            entry1.AnimRig = new CResourceReference<animRig>(reader.BaseReader.ReadUInt64());

            var cnt5 = reader.BaseReader.ReadVLQInt32();
            for (int j = 0; j < cnt5; j++)
            {
                entry1.AnimationSets.Add(new CResourceReference<animAnimSet>(reader.BaseReader.ReadUInt64()));
            }

            var cnt6 = reader.BaseReader.ReadVLQInt32();
            for (int j = 0; j < cnt6; j++)
            {
                var entry2 = new gameSmartObjectAnimationDatabase_App4();

                entry2.AnimationSet = new CResourceReference<animAnimSet>(reader.BaseReader.ReadUInt64());

                var cnt7 = reader.BaseReader.ReadVLQInt32();
                for (int k = 0; k < cnt7; k++)
                {
                    entry2.Unk2.Add(reader.ReadCName());
                }
                entry1.Unk3.Add(entry2);
            }

            Unk2.Add(entry1);
        }

        var cnt8 = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt8; i++)
        {
            var entry1 = new gameSmartObjectAnimationDatabase_PathHashPair();

            entry1.Hash = reader.BaseReader.ReadUInt64();
            entry1.Path = reader.ReadCString();

            if (FNV1A64HashAlgorithm.HashString(entry1.Path) != entry1.Hash)
            {
                throw new TodoException("gameSmartObjectAnimationDatabase: Invalid hash pair");
            }

            PathHashes.Add(entry1);
        }

        Box ReadBox()
        {
            return new Box
            {
                Min =
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                },
                Max =
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                }
            };
        }
    }

    public void CustomWrite(Red4Writer writer)
    {
        writer.BaseWriter.Write(-1);

        writer.BaseWriter.WriteVLQInt32(Unk1.Count);
        foreach (var app1 in Unk1)
        {
            writer.Write(app1.Unk1);
            writer.BaseWriter.WriteVLQInt32(app1.Unk2.Count);
            foreach (var app2 in app1.Unk2)
            {
                writer.BaseWriter.WriteVLQInt32(app2.Unk2.Count);
                foreach (var box in app2.Unk2)
                {
                    WriteBox(box);
                }

                WriteBox(app2.EndPoint);
                WriteBox(app2.StartPoint);

                writer.BaseWriter.Write((ulong)app2.AnimationSet.DepotPath);
            }
            writer.Write(app1.Unk3);
        }

        writer.BaseWriter.WriteVLQInt32(Unk2.Count);
        foreach (var app3 in Unk2)
        {
            writer.BaseWriter.Write((ulong)app3.AnimRig.DepotPath);

            writer.BaseWriter.WriteVLQInt32(app3.AnimationSets.Count);
            foreach (var animationSet in app3.AnimationSets)
            {
                writer.BaseWriter.Write((ulong)animationSet.DepotPath);
            }

            writer.BaseWriter.WriteVLQInt32(app3.Unk3.Count);
            foreach (var app4 in app3.Unk3)
            {
                writer.BaseWriter.Write((ulong)app4.AnimationSet.DepotPath);

                writer.BaseWriter.WriteVLQInt32(app4.Unk2.Count);
                foreach (var cName in app4.Unk2)
                {
                    writer.Write(cName);
                }
            }
        }

        writer.BaseWriter.WriteVLQInt32(PathHashes.Count);
        foreach (var app5 in PathHashes)
        {
            writer.Write(app5.Hash);
            writer.Write(app5.Path);
        }

        void WriteBox(Box box)
        {
            writer.Write(box.Min.X);
            writer.Write(box.Min.Y);
            writer.Write(box.Min.Z);
            writer.Write(box.Min.W);

            writer.Write(box.Max.X);
            writer.Write(box.Max.Y);
            writer.Write(box.Max.Z);
            writer.Write(box.Max.W);
        }
    }
}

public class gameSmartObjectAnimationDatabase_App1 : RedBaseClass
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CName Unk1
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<gameSmartObjectAnimationDatabase_App2> Unk2
    {
        get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App2>>();
        set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App2>>(value);
    }

    [RED("unk3")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unk3
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    public gameSmartObjectAnimationDatabase_App1()
    {
        Unk2 = new CArray<gameSmartObjectAnimationDatabase_App2>();
    }
}

public class gameSmartObjectAnimationDatabase_App2 : RedBaseClass
{
    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<Box> Unk2
    {
        get => GetPropertyValue<CArray<Box>>();
        set => SetPropertyValue<CArray<Box>>(value);
    }

    [RED("endPoint")]
    [REDProperty(IsIgnored = true)]
    public Box EndPoint
    {
        get => GetPropertyValue<Box>();
        set => SetPropertyValue<Box>(value);
    }

    [RED("startPoint")]
    [REDProperty(IsIgnored = true)]
    public Box StartPoint
    {
        get => GetPropertyValue<Box>();
        set => SetPropertyValue<Box>(value);
    }

    [RED("animationSet")]
    [REDProperty(IsIgnored = true)]
    public CResourceReference<animAnimSet> AnimationSet
    {
        get => GetPropertyValue<CResourceReference<animAnimSet>>();
        set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
    }

    public gameSmartObjectAnimationDatabase_App2()
    {
        Unk2 = new CArray<Box>();
    }
}

public class gameSmartObjectAnimationDatabase_App3 : RedBaseClass
{
    [RED("animRig")]
    [REDProperty(IsIgnored = true)]
    public CResourceReference<animRig> AnimRig
    {
        get => GetPropertyValue<CResourceReference<animRig>>();
        set => SetPropertyValue<CResourceReference<animRig>>(value);
    }

    [RED("animationSets")]
    [REDProperty(IsIgnored = true)]
    public CArray<CResourceReference<animAnimSet>> AnimationSets
    {
        get => GetPropertyValue<CArray<CResourceReference<animAnimSet>>>();
        set => SetPropertyValue<CArray<CResourceReference<animAnimSet>>>(value);
    }

    [RED("unk3")]
    [REDProperty(IsIgnored = true)]
    public CArray<gameSmartObjectAnimationDatabase_App4> Unk3
    {
        get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App4>>();
        set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App4>>(value);
    }

    public gameSmartObjectAnimationDatabase_App3()
    {
        AnimationSets = new CArray<CResourceReference<animAnimSet>>();
        Unk3 = new CArray<gameSmartObjectAnimationDatabase_App4>();
    }
}

public class gameSmartObjectAnimationDatabase_App4 : RedBaseClass
{
    [RED("animationSet")]
    [REDProperty(IsIgnored = true)]
    public CResourceReference<animAnimSet> AnimationSet
    {
        get => GetPropertyValue<CResourceReference<animAnimSet>>();
        set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Unk2
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    public gameSmartObjectAnimationDatabase_App4()
    {
        Unk2 = new CArray<CName>();
    }
}

public class gameSmartObjectAnimationDatabase_PathHashPair : RedBaseClass
{
    [RED("pathHash")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 Hash
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("path")]
    [REDProperty(IsIgnored = true)]
    public CString Path
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}