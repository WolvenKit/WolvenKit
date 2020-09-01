using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSceneCameraShotDescription : CVariable
	{
		[Ordinal(0)] [RED("("shotName")] 		public CName ShotName { get; set;}

		[Ordinal(0)] [RED("("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("("overrideDof")] 		public CBool OverrideDof { get; set;}

		[Ordinal(0)] [RED("("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		public SSceneCameraShotDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSceneCameraShotDescription(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}