using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAtDuration : CStorySceneEventDuration
	{
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("bodyTarget")] 		public CName BodyTarget { get; set;}

		[Ordinal(3)] [RED("bodyEnabled")] 		public CBool BodyEnabled { get; set;}

		[Ordinal(4)] [RED("bodyInstant")] 		public CBool BodyInstant { get; set;}

		[Ordinal(5)] [RED("bodyWeight")] 		public CFloat BodyWeight { get; set;}

		[Ordinal(6)] [RED("bodyStaticPointWS")] 		public Vector BodyStaticPointWS { get; set;}

		[Ordinal(7)] [RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(8)] [RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[Ordinal(9)] [RED("bodyTransitionWeight")] 		public CFloat BodyTransitionWeight { get; set;}

		[Ordinal(10)] [RED("usesNewTransition")] 		public CBool UsesNewTransition { get; set;}

		[Ordinal(11)] [RED("useTwoTargets")] 		public CBool UseTwoTargets { get; set;}

		[Ordinal(12)] [RED("eyesTarget")] 		public CName EyesTarget { get; set;}

		[Ordinal(13)] [RED("eyesEnabled")] 		public CBool EyesEnabled { get; set;}

		[Ordinal(14)] [RED("eyesInstant")] 		public CBool EyesInstant { get; set;}

		[Ordinal(15)] [RED("eyesWeight")] 		public CFloat EyesWeight { get; set;}

		[Ordinal(16)] [RED("eyesStaticPointWS")] 		public Vector EyesStaticPointWS { get; set;}

		[Ordinal(17)] [RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[Ordinal(18)] [RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[Ordinal(19)] [RED("sceneRange")] 		public CFloat SceneRange { get; set;}

		[Ordinal(20)] [RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[Ordinal(21)] [RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[Ordinal(22)] [RED("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		[Ordinal(23)] [RED("oldLookAtEyesSpeed")] 		public CFloat OldLookAtEyesSpeed { get; set;}

		[Ordinal(24)] [RED("oldLookAtEyesDampScale")] 		public CFloat OldLookAtEyesDampScale { get; set;}

		[Ordinal(25)] [RED("blinkSettings")] 		public SStorySceneEventLookAtBlinkSettings BlinkSettings { get; set;}

		public CStorySceneEventLookAtDuration(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventLookAtDuration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}