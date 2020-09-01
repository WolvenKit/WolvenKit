using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAtDuration : CStorySceneEventDuration
	{
		[Ordinal(0)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(0)] [RED("bodyTarget")] 		public CName BodyTarget { get; set;}

		[Ordinal(0)] [RED("bodyEnabled")] 		public CBool BodyEnabled { get; set;}

		[Ordinal(0)] [RED("bodyInstant")] 		public CBool BodyInstant { get; set;}

		[Ordinal(0)] [RED("bodyWeight")] 		public CFloat BodyWeight { get; set;}

		[Ordinal(0)] [RED("bodyStaticPointWS")] 		public Vector BodyStaticPointWS { get; set;}

		[Ordinal(0)] [RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(0)] [RED("level")] 		public CEnum<ELookAtLevel> Level { get; set;}

		[Ordinal(0)] [RED("bodyTransitionWeight")] 		public CFloat BodyTransitionWeight { get; set;}

		[Ordinal(0)] [RED("usesNewTransition")] 		public CBool UsesNewTransition { get; set;}

		[Ordinal(0)] [RED("useTwoTargets")] 		public CBool UseTwoTargets { get; set;}

		[Ordinal(0)] [RED("eyesTarget")] 		public CName EyesTarget { get; set;}

		[Ordinal(0)] [RED("eyesEnabled")] 		public CBool EyesEnabled { get; set;}

		[Ordinal(0)] [RED("eyesInstant")] 		public CBool EyesInstant { get; set;}

		[Ordinal(0)] [RED("eyesWeight")] 		public CFloat EyesWeight { get; set;}

		[Ordinal(0)] [RED("eyesStaticPointWS")] 		public Vector EyesStaticPointWS { get; set;}

		[Ordinal(0)] [RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[Ordinal(0)] [RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[Ordinal(0)] [RED("sceneRange")] 		public CFloat SceneRange { get; set;}

		[Ordinal(0)] [RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[Ordinal(0)] [RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[Ordinal(0)] [RED("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		[Ordinal(0)] [RED("oldLookAtEyesSpeed")] 		public CFloat OldLookAtEyesSpeed { get; set;}

		[Ordinal(0)] [RED("oldLookAtEyesDampScale")] 		public CFloat OldLookAtEyesDampScale { get; set;}

		[Ordinal(0)] [RED("blinkSettings")] 		public SStorySceneEventLookAtBlinkSettings BlinkSettings { get; set;}

		public CStorySceneEventLookAtDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventLookAtDuration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}