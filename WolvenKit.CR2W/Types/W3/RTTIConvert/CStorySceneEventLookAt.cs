using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAt : CStorySceneEvent
	{
		[Ordinal(0)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(0)] [RED("target")] 		public CName Target { get; set;}

		[Ordinal(0)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(0)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[Ordinal(0)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[Ordinal(0)] [RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[Ordinal(0)] [RED("instant")] 		public CBool Instant { get; set;}

		[Ordinal(0)] [RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[Ordinal(0)] [RED("headRotationRatio")] 		public CFloat HeadRotationRatio { get; set;}

		[Ordinal(0)] [RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[Ordinal(0)] [RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[Ordinal(0)] [RED("eyesLookAtDampScale")] 		public CFloat EyesLookAtDampScale { get; set;}

		[Ordinal(0)] [RED("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		public CStorySceneEventLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}