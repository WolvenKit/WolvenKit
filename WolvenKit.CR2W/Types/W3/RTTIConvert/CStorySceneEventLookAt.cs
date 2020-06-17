using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAt : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("target")] 		public CName Target { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("type")] 		public EDialogLookAtType Type { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("level")] 		public ELookAtLevel Level { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		[RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[RED("headRotationRatio")] 		public CFloat HeadRotationRatio { get; set;}

		[RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[RED("eyesLookAtDampScale")] 		public CFloat EyesLookAtDampScale { get; set;}

		[RED("resetCloth")] 		public EDialogResetClothAndDanglesType ResetCloth { get; set;}

		public CStorySceneEventLookAt(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventLookAt(cr2w);

	}
}