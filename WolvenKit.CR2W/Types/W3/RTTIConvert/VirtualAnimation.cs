using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimation : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(3)] [RED("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(4)] [RED("endTime")] 		public CFloat EndTime { get; set;}

		[Ordinal(5)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(6)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(7)] [RED("useMotion")] 		public CBool UseMotion { get; set;}

		[Ordinal(8)] [RED("boneToExtract")] 		public CInt32 BoneToExtract { get; set;}

		[Ordinal(9)] [RED("bones", 2,0)] 		public CArray<CInt32> Bones { get; set;}

		[Ordinal(10)] [RED("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		[Ordinal(11)] [RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(12)] [RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(13)] [RED("track")] 		public CInt32 Track { get; set;}

		[Ordinal(14)] [RED("animset")] 		public CSoft<CSkeletalAnimationSet> Animset { get; set;}

		public VirtualAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VirtualAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}