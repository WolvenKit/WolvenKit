using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseGameplayEffect : CObject
	{
		[Ordinal(1)] [RED("timeActive")] 		public CFloat TimeActive { get; set;}

		[Ordinal(2)] [RED("initialDuration")] 		public CFloat InitialDuration { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("timeLeft")] 		public CFloat TimeLeft { get; set;}

		[Ordinal(5)] [RED("pauseCounters", 2,0)] 		public CArray<SBuffPauseLock> PauseCounters { get; set;}

		[Ordinal(6)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(7)] [RED("resistStat")] 		public CEnum<ECharacterDefenseStats> ResistStat { get; set;}

		[Ordinal(8)] [RED("resistance")] 		public CFloat Resistance { get; set;}

		[Ordinal(9)] [RED("creatorPowerStat")] 		public SAbilityAttributeValue CreatorPowerStat { get; set;}

		[Ordinal(10)] [RED("isPausedDuringDialogAndCutscene")] 		public CBool IsPausedDuringDialogAndCutscene { get; set;}

		[Ordinal(11)] [RED("dontAddAbilityOnTarget")] 		public CBool DontAddAbilityOnTarget { get; set;}

		[Ordinal(12)] [RED("canBeAppliedOnDeadTarget")] 		public CBool CanBeAppliedOnDeadTarget { get; set;}

		[Ordinal(13)] [RED("effectManager")] 		public CHandle<W3EffectManager> EffectManager { get; set;}

		[Ordinal(14)] [RED("isPositive")] 		public CBool IsPositive { get; set;}

		[Ordinal(15)] [RED("isNeutral")] 		public CBool IsNeutral { get; set;}

		[Ordinal(16)] [RED("isNegative")] 		public CBool IsNegative { get; set;}

		[Ordinal(17)] [RED("isOnPlayer")] 		public CBool IsOnPlayer { get; set;}

		[Ordinal(18)] [RED("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[Ordinal(19)] [RED("isPotionEffect")] 		public CBool IsPotionEffect { get; set;}

		[Ordinal(20)] [RED("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(21)] [RED("attributeName")] 		public CName AttributeName { get; set;}

		[Ordinal(22)] [RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(23)] [RED("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(24)] [RED("creatorHandle")] 		public EntityHandle CreatorHandle { get; set;}

		[Ordinal(25)] [RED("effectValue")] 		public SAbilityAttributeValue EffectValue { get; set;}

		[Ordinal(26)] [RED("potionItemName")] 		public CName PotionItemName { get; set;}

		[Ordinal(27)] [RED("deny", 2,0)] 		public CArray<CEnum<EEffectType>> Deny { get; set;}

		[Ordinal(28)] [RED("override", 2,0)] 		public CArray<CEnum<EEffectType>> Override { get; set;}

		[Ordinal(29)] [RED("sourceName")] 		public CString SourceName { get; set;}

		[Ordinal(30)] [RED("cameraEffectName")] 		public CName CameraEffectName { get; set;}

		[Ordinal(31)] [RED("isPlayingCameraEffect")] 		public CBool IsPlayingCameraEffect { get; set;}

		[Ordinal(32)] [RED("switchCameraEffect")] 		public CBool SwitchCameraEffect { get; set;}

		[Ordinal(33)] [RED("isCameraEffectNameValid")] 		public CBool IsCameraEffectNameValid { get; set;}

		[Ordinal(34)] [RED("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(35)] [RED("showOnHUD")] 		public CBool ShowOnHUD { get; set;}

		[Ordinal(36)] [RED("effectNameLocalisationKey")] 		public CString EffectNameLocalisationKey { get; set;}

		[Ordinal(37)] [RED("effectDescriptionLocalisationKey")] 		public CString EffectDescriptionLocalisationKey { get; set;}

		[Ordinal(38)] [RED("targetEffectName")] 		public CName TargetEffectName { get; set;}

		[Ordinal(39)] [RED("shouldPlayTargetEffect")] 		public CBool ShouldPlayTargetEffect { get; set;}

		[Ordinal(40)] [RED("onAddedSound")] 		public CName OnAddedSound { get; set;}

		[Ordinal(41)] [RED("onRemovedSound")] 		public CName OnRemovedSound { get; set;}

		[Ordinal(42)] [RED("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[Ordinal(43)] [RED("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public CBaseGameplayEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}