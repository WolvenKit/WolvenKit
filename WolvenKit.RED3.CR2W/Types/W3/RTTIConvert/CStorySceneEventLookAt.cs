using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAt : CStorySceneEvent
	{
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("target")] 		public CName Target { get; set;}

		[Ordinal(3)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(4)] [RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(5)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(6)] [RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[Ordinal(7)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(8)] [RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[Ordinal(9)] [RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[Ordinal(10)] [RED("instant")] 		public CBool Instant { get; set;}

		[Ordinal(11)] [RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[Ordinal(12)] [RED("headRotationRatio")] 		public CFloat HeadRotationRatio { get; set;}

		[Ordinal(13)] [RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[Ordinal(14)] [RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[Ordinal(15)] [RED("eyesLookAtDampScale")] 		public CFloat EyesLookAtDampScale { get; set;}

		[Ordinal(16)] [RED("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		public CStorySceneEventLookAt(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}