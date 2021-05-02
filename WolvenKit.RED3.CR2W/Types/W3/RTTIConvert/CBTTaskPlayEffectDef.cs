using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayEffectDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("effectName")] 		public CBehTreeValCName EffectName { get; set;}

		[Ordinal(2)] [RED("sfxInsteadOfVfx")] 		public CBool SfxInsteadOfVfx { get; set;}

		[Ordinal(3)] [RED("onWeaponItem")] 		public CBool OnWeaponItem { get; set;}

		[Ordinal(4)] [RED("turnOff")] 		public CBool TurnOff { get; set;}

		[Ordinal(5)] [RED("onTarget")] 		public CBool OnTarget { get; set;}

		[Ordinal(6)] [RED("onActionTarget")] 		public CBool OnActionTarget { get; set;}

		[Ordinal(7)] [RED("connectEffectWithTarget")] 		public CBool ConnectEffectWithTarget { get; set;}

		[Ordinal(8)] [RED("connectWithActionTarget")] 		public CBool ConnectWithActionTarget { get; set;}

		[Ordinal(9)] [RED("playEffectOnComponent")] 		public CBool PlayEffectOnComponent { get; set;}

		[Ordinal(10)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(11)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(12)] [RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(13)] [RED("bothGameplayAndAnimEvent")] 		public CBool BothGameplayAndAnimEvent { get; set;}

		[Ordinal(14)] [RED("onInitialize")] 		public CBool OnInitialize { get; set;}

		[Ordinal(15)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(16)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(17)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(18)] [RED("onFailure")] 		public CBool OnFailure { get; set;}

		[Ordinal(19)] [RED("delayEffect")] 		public CFloat DelayEffect { get; set;}

		[Ordinal(20)] [RED("checkIfEffectIsPlaying")] 		public CBool CheckIfEffectIsPlaying { get; set;}

		[Ordinal(21)] [RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[Ordinal(22)] [RED("onTaggedEntity")] 		public CBool OnTaggedEntity { get; set;}

		[Ordinal(23)] [RED("tagToFind")] 		public CName TagToFind { get; set;}

		public CBTTaskPlayEffectDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}