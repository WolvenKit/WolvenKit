using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CSkeletalAnimationSetEntry : ISerializable
    {
        [RED("animation")] public CPtr<CSkeletalAnimation> Animation { get; set; }

        [RED("compressedPoseBlend")] public ECompressedPoseBlend CompressedPoseBlend { get; set; }

        [RED("params", 2, 0)] public CArray<CPtr<ISkeletalAnimationSetEntryParam>> Params { get; set; }

        [RED("eventsGroupsRanges", 2, 0)] public CArray<SEventGroupsRanges> EventsGroupsRanges { get; set; }

        [REDBuffer] public CArray<CVariantSizeType> Entries { get; set; }

        public CSkeletalAnimationSetEntry(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSkeletalAnimationSetEntry(cr2w);
        }

    }
}