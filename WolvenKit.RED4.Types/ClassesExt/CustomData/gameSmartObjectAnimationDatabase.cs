using System;
using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
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

        [RED("unk3")]
        [REDProperty(IsIgnored = true)]
        public CArray<gameSmartObjectAnimationDatabase_App5> Unk3
        {
            get => GetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App5>>();
            set => SetPropertyValue<CArray<gameSmartObjectAnimationDatabase_App5>>(value);
        }

        public void CustomRead(Red4Reader reader, uint size)
        {
            Unk1 = new CArray<gameSmartObjectAnimationDatabase_App1>();
            Unk2 = new CArray<gameSmartObjectAnimationDatabase_App3>();
            Unk3 = new CArray<gameSmartObjectAnimationDatabase_App5>();

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

                    var cnt3 = reader.BaseReader.ReadVLQInt32();

                    entry2.Unk1 = reader.ReadCUInt32();
                    for (int k = 0; k < (cnt3 * 2) + 3; k++)
                    {
                        var entry3 = new Vector4();

                        entry3.X = reader.ReadCFloat();
                        entry3.Y = reader.ReadCFloat();
                        entry3.Z = reader.ReadCFloat();
                        entry3.W = reader.ReadCFloat();

                        entry2.Unk2.Add(entry3);
                    }

                    entry2.Unk3 = reader.ReadSharedDataBuffer(20);
                    entry1.Unk2.Add(entry2);
                }
                entry1.Unk3 = reader.ReadCUInt32();

                Unk1.Add(entry1);
            }

            var cnt4 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt4; i++)
            {
                var entry1 = new gameSmartObjectAnimationDatabase_App3();

                entry1.Unk1 = reader.ReadCUInt64();

                var cnt5 = reader.BaseReader.ReadVLQInt32();
                for (int j = 0; j < cnt5; j++)
                {
                    entry1.Unk2.Add(reader.ReadCUInt64());
                }

                var cnt6 = reader.BaseReader.ReadVLQInt32();
                for (int j = 0; j < cnt6; j++)
                {
                    var entry2 = new gameSmartObjectAnimationDatabase_App4();

                    entry2.Unk1 = reader.ReadCUInt64();

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
                var entry1 = new gameSmartObjectAnimationDatabase_App5();

                entry1.Unk1 = reader.ReadCUInt64();
                entry1.Unk2 = reader.ReadCString();

                Unk3.Add(entry1);
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
                    writer.BaseWriter.WriteVLQInt32((app2.Unk2.Count - 3) / 2);
                    writer.Write(app2.Unk1);

                    foreach (var vec in app2.Unk2)
                    {
                        writer.Write(vec.X);
                        writer.Write(vec.Y);
                        writer.Write(vec.Z);
                        writer.Write(vec.W);
                    }

                    writer.Write(app2.Unk3);
                }
                writer.Write(app1.Unk3);
            }

            writer.BaseWriter.WriteVLQInt32(Unk2.Count);
            foreach (var app3 in Unk2)
            {
                writer.Write(app3.Unk1);

                writer.BaseWriter.WriteVLQInt32(app3.Unk2.Count);
                foreach (var hash in app3.Unk2)
                {
                    writer.Write(hash);
                }

                writer.BaseWriter.WriteVLQInt32(app3.Unk3.Count);
                foreach (var app4 in app3.Unk3)
                {
                    writer.Write(app4.Unk1);

                    writer.BaseWriter.WriteVLQInt32(app4.Unk2.Count);
                    foreach (var cName in app4.Unk2)
                    {
                        writer.Write(cName);
                    }
                }
            }

            writer.BaseWriter.WriteVLQInt32(Unk3.Count);
            foreach (var app5 in Unk3)
            {
                writer.Write(app5.Unk1);
                writer.Write(app5.Unk2);
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
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CUInt32 Unk1
        {
            get => GetPropertyValue<CUInt32>();
            set => SetPropertyValue<CUInt32>(value);
        }

        [RED("unk2")]
        [REDProperty(IsIgnored = true)]
        public CArray<Vector4> Unk2
        {
            get => GetPropertyValue<CArray<Vector4>>();
            set => SetPropertyValue<CArray<Vector4>>(value);
        }

        [RED("unk3")]
        [REDProperty(IsIgnored = true)]
        public SharedDataBuffer Unk3
        {
            get => GetPropertyValue<SharedDataBuffer>();
            set => SetPropertyValue<SharedDataBuffer>(value);
        }

        public gameSmartObjectAnimationDatabase_App2()
        {
            Unk2 = new CArray<Vector4>();
        }
    }

    public class gameSmartObjectAnimationDatabase_App3 : RedBaseClass
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CUInt64 Unk1 // hash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        [RED("unk2")]
        [REDProperty(IsIgnored = true)]
        public CArray<CUInt64> Unk2 // hashes
        {
            get => GetPropertyValue<CArray<CUInt64>>();
            set => SetPropertyValue<CArray<CUInt64>>(value);
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
            Unk2 = new CArray<CUInt64>();
            Unk3 = new CArray<gameSmartObjectAnimationDatabase_App4>();
        }
    }

    public class gameSmartObjectAnimationDatabase_App4 : RedBaseClass
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CUInt64 Unk1 // hash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
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

    public class gameSmartObjectAnimationDatabase_App5 : RedBaseClass
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CUInt64 Unk1 // hash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        [RED("unk2")]
        [REDProperty(IsIgnored = true)]
        public CString Unk2
        {
            get => GetPropertyValue<CString>();
            set => SetPropertyValue<CString>(value);
        }
    }
}
