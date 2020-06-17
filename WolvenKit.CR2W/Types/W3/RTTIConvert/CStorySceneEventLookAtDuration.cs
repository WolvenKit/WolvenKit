using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLookAtDuration : CStorySceneEventDuration
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("bodyTarget")] 		public CName BodyTarget { get; set;}

		[RED("bodyEnabled")] 		public CBool BodyEnabled { get; set;}

		[RED("bodyInstant")] 		public CBool BodyInstant { get; set;}

		[RED("bodyWeight")] 		public CFloat BodyWeight { get; set;}

		[RED("bodyStaticPointWS")] 		public Vector BodyStaticPointWS { get; set;}

		[RED("type")] 		public EDialogLookAtType Type { get; set;}

		[RED("level")] 		public ELookAtLevel Level { get; set;}

		[RED("bodyTransitionWeight")] 		public CFloat BodyTransitionWeight { get; set;}

		[RED("usesNewTransition")] 		public CBool UsesNewTransition { get; set;}

		[RED("useTwoTargets")] 		public CBool UseTwoTargets { get; set;}

		[RED("eyesTarget")] 		public CName EyesTarget { get; set;}

		[RED("eyesEnabled")] 		public CBool EyesEnabled { get; set;}

		[RED("eyesInstant")] 		public CBool EyesInstant { get; set;}

		[RED("eyesWeight")] 		public CFloat EyesWeight { get; set;}

		[RED("eyesStaticPointWS")] 		public Vector EyesStaticPointWS { get; set;}

		[RED("eyesLookAtConvergenceWeight")] 		public CFloat EyesLookAtConvergenceWeight { get; set;}

		[RED("eyesLookAtIsAdditive")] 		public CBool EyesLookAtIsAdditive { get; set;}

		[RED("sceneRange")] 		public CFloat SceneRange { get; set;}

		[RED("gameplayRange")] 		public CFloat GameplayRange { get; set;}

		[RED("limitDeact")] 		public CBool LimitDeact { get; set;}

		[RED("resetCloth")] 		public EDialogResetClothAndDanglesType ResetCloth { get; set;}

		[RED("oldLookAtEyesSpeed")] 		public CFloat OldLookAtEyesSpeed { get; set;}

		[RED("oldLookAtEyesDampScale")] 		public CFloat OldLookAtEyesDampScale { get; set;}

		[RED("blinkSettings")] 		public SStorySceneEventLookAtBlinkSettings BlinkSettings { get; set;}

		public CStorySceneEventLookAtDuration(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventLookAtDuration(cr2w);

	}
}