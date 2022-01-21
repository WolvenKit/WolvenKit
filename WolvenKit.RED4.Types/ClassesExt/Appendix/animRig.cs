using System.Collections.Generic;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class animRig : IRedAppendix
    {
        [RED("boneParentIndexes")]
        [REDProperty(IsIgnored = true)]
        public CArray<CInt16> BoneParentIndexes
        {
            get => GetPropertyValue<CArray<CInt16>>();
            set => SetPropertyValue<CArray<CInt16>>(value);
        }

        [RED("boneTransforms")]
        [REDProperty(IsIgnored = true)]
        public CArray<QsTransform> BoneTransforms
        {
            get => GetPropertyValue<CArray<QsTransform>>();
            set => SetPropertyValue<CArray<QsTransform>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            BoneParentIndexes = new CArray<CInt16>();
            BoneTransforms = new CArray<QsTransform>();

            var count = BoneNames.Count;
            for (var i = 0; i < count; i++)
            {
                BoneParentIndexes.Add(reader.ReadCInt16());
            }

            for (var i = 0; i < count; i++)
            {
                var qs = new QsTransform();

                qs.Translation.X = reader.ReadCFloat();
                qs.Translation.Y = reader.ReadCFloat();
                qs.Translation.Z = reader.ReadCFloat();
                qs.Translation.W = reader.ReadCFloat();

                qs.Rotation.I = reader.ReadCFloat();
                qs.Rotation.J = reader.ReadCFloat();
                qs.Rotation.K = reader.ReadCFloat();
                qs.Rotation.R = reader.ReadCFloat();

                qs.Scale.X = reader.ReadCFloat();
                qs.Scale.Y = reader.ReadCFloat();
                qs.Scale.Z = reader.ReadCFloat();
                qs.Scale.W = reader.ReadCFloat();

                BoneTransforms.Add(qs);
            }
        }

        public void Write(Red4Writer writer)
        {
            foreach (var e in BoneParentIndexes)
            {
                writer.Write(e);
            }

            foreach (var qs in BoneTransforms)
            {
                writer.Write(qs.Translation.X);
                writer.Write(qs.Translation.Y);
                writer.Write(qs.Translation.Z);
                writer.Write(qs.Translation.W);

                writer.Write(qs.Rotation.I);
                writer.Write(qs.Rotation.J);
                writer.Write(qs.Rotation.K);
                writer.Write(qs.Rotation.R);

                writer.Write(qs.Scale.X);
                writer.Write(qs.Scale.Y);
                writer.Write(qs.Scale.Z);
                writer.Write(qs.Scale.W);
            }
        }
    }
}
