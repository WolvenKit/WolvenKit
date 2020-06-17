using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSceneCameraShotDescription : CVariable
	{
		[RED("shotName")] 		public CName ShotName { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("overrideDof")] 		public CBool OverrideDof { get; set;}

		[RED("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[RED("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[RED("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[RED("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[RED("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		public SSceneCameraShotDescription(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSceneCameraShotDescription(cr2w);

	}
}