using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class worldTrafficCompiledNode : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficCompiledNode_App1> Unk1
    {
        get => GetPropertyValue<CArray<worldTrafficCompiledNode_App1>>();
        set => SetPropertyValue<CArray<worldTrafficCompiledNode_App1>>(value);
    }

    partial void PostConstruct()
    {
        Unk1 = new CArray<worldTrafficCompiledNode_App1>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        Unk1 = new CArray<worldTrafficCompiledNode_App1>();

        var unk1 = reader.BaseReader.ReadUInt16();
        if (unk1 != 1)
        {
            throw new TodoException($"Unknown value in {nameof(worldTrafficCompiledNode)}");
        }

        var cnt1 = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt1; i++)
        {
            var entry1 = new worldTrafficCompiledNode_App1();

            entry1.Unk1 = reader.ReadCUInt32();
            entry1.Unk2 = new Box
            {
                Max = new Vector4
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                },
                Min = new Vector4
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat(),
                    W = reader.ReadCFloat()
                }
            };
            entry1.Unk3 = reader.ReadCUInt64();
            entry1.Unk4 = reader.BaseReader.ReadBytes(5);
            entry1.Unk5 = reader.ReadCFloat();
            entry1.Unk6 = reader.ReadCFloat();

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (int j = 0; j < cnt2; j++)
            {
                var entry2 = new worldTrafficCompiledNode_App2();

                entry2.Unk1 = reader.ReadCFloat();
                entry2.Unk2 = reader.ReadCFloat();
                entry2.Unk3 = reader.ReadCUInt8();
                entry2.Unk4 = reader.ReadCUInt32();

                var cnt3 = reader.BaseReader.ReadVLQInt32();
                for (int k = 0; k < cnt3; k++)
                {
                    var entry3 = new worldTrafficCompiledNode_App3();

                    entry3.Unk1 = reader.ReadCUInt32();
                    entry3.Unk2 = reader.ReadCFloat();

                    entry2.Unk5.Add(entry3);
                }

                entry1.Unk7.Add(entry2);
            }

            var cnt4 = reader.BaseReader.ReadVLQInt32();
            for (int j = 0; j < cnt4; j++)
            {
                entry1.Handles.Add((CHandle<AITrafficWorkspotCompiled>)reader.ReadCHandle<AITrafficWorkspotCompiled>());
            }

            Unk1.Add(entry1);
        }
    }

    public void Write(Red4Writer writer)
    {
        writer.BaseWriter.Write((ushort)1);

        writer.BaseWriter.WriteVLQInt32(Unk1.Count);
        foreach (var app1 in Unk1)
        {
            writer.Write(app1.Unk1);

            writer.Write(app1.Unk2.Max.X);
            writer.Write(app1.Unk2.Max.Y);
            writer.Write(app1.Unk2.Max.Z);
            writer.Write(app1.Unk2.Max.W);

            writer.Write(app1.Unk2.Min.X);
            writer.Write(app1.Unk2.Min.Y);
            writer.Write(app1.Unk2.Min.Z);
            writer.Write(app1.Unk2.Min.W);

            writer.Write(app1.Unk3);
            writer.BaseWriter.Write(app1.Unk4);
            writer.Write(app1.Unk5);
            writer.Write(app1.Unk6);

            writer.BaseWriter.WriteVLQInt32(app1.Unk7.Count);
            foreach (var app2 in app1.Unk7)
            {
                writer.Write(app2.Unk1);
                writer.Write(app2.Unk2);
                writer.Write(app2.Unk3);
                writer.Write(app2.Unk4);

                writer.BaseWriter.WriteVLQInt32(app2.Unk5.Count);
                foreach (var app3 in app2.Unk5)
                {
                    writer.Write(app3.Unk1);
                    writer.Write(app3.Unk2);
                }
            }

            writer.BaseWriter.WriteVLQInt32(app1.Handles.Count);
            foreach (var handle in app1.Handles)
            {
                writer.Write((IRedHandle)handle);
            }
        }
    }
}

public class worldTrafficCompiledNode_App1 : RedBaseClass
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unk1
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public Box Unk2
    {
        get => GetPropertyValue<Box>();
        set => SetPropertyValue<Box>(value);
    }

    [RED("unk3")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 Unk3
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("unk4")]
    [REDProperty(IsIgnored = true)]
    public CByteArray Unk4
    {
        get => GetPropertyValue<CByteArray>();
        set => SetPropertyValue<CByteArray>(value);
    }

    [RED("unk5")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unk5
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk6")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unk6
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk7")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficCompiledNode_App2> Unk7
    {
        get => GetPropertyValue<CArray<worldTrafficCompiledNode_App2>>();
        set => SetPropertyValue<CArray<worldTrafficCompiledNode_App2>>(value);
    }

    [RED("unk8")]
    [REDProperty(IsIgnored = true)]
    public CArray<CHandle<AITrafficWorkspotCompiled>> Handles
    {
        get => GetPropertyValue<CArray<CHandle<AITrafficWorkspotCompiled>>>();
        set => SetPropertyValue<CArray<CHandle<AITrafficWorkspotCompiled>>>(value);
    }

    public worldTrafficCompiledNode_App1()
    {
        Unk4 = new CByteArray();
        Unk7 = new CArray<worldTrafficCompiledNode_App2>();
        Handles = new CArray<CHandle<AITrafficWorkspotCompiled>>();
    }
}

public class worldTrafficCompiledNode_App2 : RedBaseClass
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unk1
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unk2
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk3")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unk3
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unk4")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unk4
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unk5")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficCompiledNode_App3> Unk5
    {
        get => GetPropertyValue<CArray<worldTrafficCompiledNode_App3>>();
        set => SetPropertyValue<CArray<worldTrafficCompiledNode_App3>>(value);
    }

    public worldTrafficCompiledNode_App2()
    {
        Unk5 = new CArray<worldTrafficCompiledNode_App3>();
    }
}

public class worldTrafficCompiledNode_App3 : RedBaseClass
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unk1
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unk2
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}