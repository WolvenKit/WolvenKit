using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSkeletalAnimationSetEntry : ISerializable
	{
		[Ordinal(0)] [RED("animation")] 		public CPtr<CSkeletalAnimation> Animation { get; set;}

		[Ordinal(0)] [RED("compressedPoseBlend")] 		public CEnum<ECompressedPoseBlend> CompressedPoseBlend { get; set;}

		[Ordinal(0)] [RED("params", 2,0)] 		public CArray<CPtr<ISkeletalAnimationSetEntryParam>> Params { get; set;}

		[Ordinal(0)] [RED("eventsGroupsRanges", 2,0)] 		public CArray<SEventGroupsRanges> EventsGroupsRanges { get; set;}

		public CSkeletalAnimationSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimationSetEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}