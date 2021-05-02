using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSceneCameraShotDescription : CVariable
	{
		[Ordinal(1)] [RED("shotName")] 		public CName ShotName { get; set;}

		[Ordinal(2)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(3)] [RED("overrideDof")] 		public CBool OverrideDof { get; set;}

		[Ordinal(4)] [RED("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[Ordinal(5)] [RED("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[Ordinal(6)] [RED("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[Ordinal(7)] [RED("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[Ordinal(8)] [RED("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		public SSceneCameraShotDescription(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSceneCameraShotDescription(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}