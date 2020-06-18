using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSkeletalAnimationSetEntry : ISerializable
	{
		[RED("animation")] 		public CPtr<CSkeletalAnimation> Animation { get; set;}

		[RED("compressedPoseBlend")] 		public CEnum<ECompressedPoseBlend> CompressedPoseBlend { get; set;}

		[RED("params", 2,0)] 		public CArray<CPtr<ISkeletalAnimationSetEntryParam>> Params { get; set;}

		[RED("eventsGroupsRanges", 2,0)] 		public CArray<SEventGroupsRanges> EventsGroupsRanges { get; set;}

		public CSkeletalAnimationSetEntry(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CSkeletalAnimationSetEntry(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}