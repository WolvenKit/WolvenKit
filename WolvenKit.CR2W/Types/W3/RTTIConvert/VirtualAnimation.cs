using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimation : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("time")] 		public CFloat Time { get; set;}

		[Ordinal(0)] [RED("("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(0)] [RED("("endTime")] 		public CFloat EndTime { get; set;}

		[Ordinal(0)] [RED("("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(0)] [RED("("useMotion")] 		public CBool UseMotion { get; set;}

		[Ordinal(0)] [RED("("boneToExtract")] 		public CInt32 BoneToExtract { get; set;}

		[Ordinal(0)] [RED("("bones", 2,0)] 		public CArray<CInt32> Bones { get; set;}

		[Ordinal(0)] [RED("("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		[Ordinal(0)] [RED("("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(0)] [RED("("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(0)] [RED("("track")] 		public CInt32 Track { get; set;}

		[Ordinal(0)] [RED("("animset")] 		public CSoft<CSkeletalAnimationSet> Animset { get; set;}

		public VirtualAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VirtualAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}