using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayEffectDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("effectName")] 		public CBehTreeValCName EffectName { get; set;}

		[Ordinal(0)] [RED("sfxInsteadOfVfx")] 		public CBool SfxInsteadOfVfx { get; set;}

		[Ordinal(0)] [RED("onWeaponItem")] 		public CBool OnWeaponItem { get; set;}

		[Ordinal(0)] [RED("turnOff")] 		public CBool TurnOff { get; set;}

		[Ordinal(0)] [RED("onTarget")] 		public CBool OnTarget { get; set;}

		[Ordinal(0)] [RED("onActionTarget")] 		public CBool OnActionTarget { get; set;}

		[Ordinal(0)] [RED("connectEffectWithTarget")] 		public CBool ConnectEffectWithTarget { get; set;}

		[Ordinal(0)] [RED("connectWithActionTarget")] 		public CBool ConnectWithActionTarget { get; set;}

		[Ordinal(0)] [RED("playEffectOnComponent")] 		public CBool PlayEffectOnComponent { get; set;}

		[Ordinal(0)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(0)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("bothGameplayAndAnimEvent")] 		public CBool BothGameplayAndAnimEvent { get; set;}

		[Ordinal(0)] [RED("onInitialize")] 		public CBool OnInitialize { get; set;}

		[Ordinal(0)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(0)] [RED("onFailure")] 		public CBool OnFailure { get; set;}

		[Ordinal(0)] [RED("delayEffect")] 		public CFloat DelayEffect { get; set;}

		[Ordinal(0)] [RED("checkIfEffectIsPlaying")] 		public CBool CheckIfEffectIsPlaying { get; set;}

		[Ordinal(0)] [RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("onTaggedEntity")] 		public CBool OnTaggedEntity { get; set;}

		[Ordinal(0)] [RED("tagToFind")] 		public CName TagToFind { get; set;}

		public CBTTaskPlayEffectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayEffectDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}