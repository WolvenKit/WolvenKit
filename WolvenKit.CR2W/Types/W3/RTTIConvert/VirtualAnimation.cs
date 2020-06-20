using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimation : CVariable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("time")] 		public CFloat Time { get; set;}

		[RED("startTime")] 		public CFloat StartTime { get; set;}

		[RED("endTime")] 		public CFloat EndTime { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("useMotion")] 		public CBool UseMotion { get; set;}

		[RED("boneToExtract")] 		public CInt32 BoneToExtract { get; set;}

		[RED("bones", 2,0)] 		public CArray<CInt32> Bones { get; set;}

		[RED("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("track")] 		public CInt32 Track { get; set;}

		[RED("animset")] 		public CSoft<CSkeletalAnimationSet> Animset { get; set;}

		public VirtualAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VirtualAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}