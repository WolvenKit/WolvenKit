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
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("target")] 		public CName Target { get; set;}

		[Ordinal(3)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(4)] [RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(5)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(6)] [RED("canCloseEyes")] 		public CBool CanCloseEyes { get; set;}

		[Ordinal(7)] [RED("forceCloseEyes")] 		public CBool ForceCloseEyes { get; set;}

		[Ordinal(8)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(9)] [RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[Ordinal(10)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(11)] [RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[Ordinal(12)] [RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[Ordinal(13)] [RED("instant")] 		public CBool Instant { get; set;}

		[Ordinal(14)] [RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[Ordinal(15)] [RED("headRotationRatio")] 		public CFloat HeadRotationRatio { get; set;}

		[Ordinal(16)] [RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[Ordinal(17)] [RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[Ordinal(18)] [RED("eyesLookAtDampScale")] 		public CFloat EyesLookAtDampScale { get; set;}

		public CQuestLookAtBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestLookAtBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}