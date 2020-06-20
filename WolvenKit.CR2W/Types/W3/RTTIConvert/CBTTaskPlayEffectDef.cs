using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayEffectDef : IBehTreeTaskDefinition
	{
		[RED("effectName")] 		public CBehTreeValCName EffectName { get; set;}

		[RED("sfxInsteadOfVfx")] 		public CBool SfxInsteadOfVfx { get; set;}

		[RED("onWeaponItem")] 		public CBool OnWeaponItem { get; set;}

		[RED("turnOff")] 		public CBool TurnOff { get; set;}

		[RED("onTarget")] 		public CBool OnTarget { get; set;}

		[RED("onActionTarget")] 		public CBool OnActionTarget { get; set;}

		[RED("connectEffectWithTarget")] 		public CBool ConnectEffectWithTarget { get; set;}

		[RED("connectWithActionTarget")] 		public CBool ConnectWithActionTarget { get; set;}

		[RED("playEffectOnComponent")] 		public CBool PlayEffectOnComponent { get; set;}

		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[RED("bothGameplayAndAnimEvent")] 		public CBool BothGameplayAndAnimEvent { get; set;}

		[RED("onInitialize")] 		public CBool OnInitialize { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[RED("onFailure")] 		public CBool OnFailure { get; set;}

		[RED("delayEffect")] 		public CFloat DelayEffect { get; set;}

		[RED("checkIfEffectIsPlaying")] 		public CBool CheckIfEffectIsPlaying { get; set;}

		[RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[RED("onTaggedEntity")] 		public CBool OnTaggedEntity { get; set;}

		[RED("tagToFind")] 		public CName TagToFind { get; set;}

		public CBTTaskPlayEffectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayEffectDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}