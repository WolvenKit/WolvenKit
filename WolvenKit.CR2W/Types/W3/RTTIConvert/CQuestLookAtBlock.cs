using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestLookAtBlock : CQuestGraphBlock
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("target")] 		public CName Target { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("canCloseEyes")] 		public CBool CanCloseEyes { get; set;}

		[RED("forceCloseEyes")] 		public CBool ForceCloseEyes { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		[RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[RED("headRotationRatio")] 		public CFloat HeadRotationRatio { get; set;}

		[RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[RED("eyesLookAtDampScale")] 		public CFloat EyesLookAtDampScale { get; set;}

		public CQuestLookAtBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestLookAtBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}