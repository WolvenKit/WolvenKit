using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseGameplayEffect : CObject
	{
		[RED("timeActive")] 		public CFloat TimeActive { get; set;}

		[RED("initialDuration")] 		public CFloat InitialDuration { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("timeLeft")] 		public CFloat TimeLeft { get; set;}

		[RED("pauseCounters", 2,0)] 		public CArray<SBuffPauseLock> PauseCounters { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("resistStat")] 		public CEnum<ECharacterDefenseStats> ResistStat { get; set;}

		[RED("resistance")] 		public CFloat Resistance { get; set;}

		[RED("creatorPowerStat")] 		public SAbilityAttributeValue CreatorPowerStat { get; set;}

		[RED("isPausedDuringDialogAndCutscene")] 		public CBool IsPausedDuringDialogAndCutscene { get; set;}

		[RED("dontAddAbilityOnTarget")] 		public CBool DontAddAbilityOnTarget { get; set;}

		[RED("canBeAppliedOnDeadTarget")] 		public CBool CanBeAppliedOnDeadTarget { get; set;}

		[RED("effectManager")] 		public CHandle<W3EffectManager> EffectManager { get; set;}

		[RED("isPositive")] 		public CBool IsPositive { get; set;}

		[RED("isNeutral")] 		public CBool IsNeutral { get; set;}

		[RED("isNegative")] 		public CBool IsNegative { get; set;}

		[RED("isOnPlayer")] 		public CBool IsOnPlayer { get; set;}

		[RED("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[RED("isPotionEffect")] 		public CBool IsPotionEffect { get; set;}

		[RED("abilityName")] 		public CName AbilityName { get; set;}

		[RED("attributeName")] 		public CName AttributeName { get; set;}

		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("creatorHandle")] 		public EntityHandle CreatorHandle { get; set;}

		[RED("effectValue")] 		public SAbilityAttributeValue EffectValue { get; set;}

		[RED("potionItemName")] 		public CName PotionItemName { get; set;}

		[RED("deny", 2,0)] 		public CArray<CEnum<EEffectType>> Deny { get; set;}

		[RED("override", 2,0)] 		public CArray<CEnum<EEffectType>> Override { get; set;}

		[RED("sourceName")] 		public CString SourceName { get; set;}

		[RED("cameraEffectName")] 		public CName CameraEffectName { get; set;}

		[RED("isPlayingCameraEffect")] 		public CBool IsPlayingCameraEffect { get; set;}

		[RED("switchCameraEffect")] 		public CBool SwitchCameraEffect { get; set;}

		[RED("isCameraEffectNameValid")] 		public CBool IsCameraEffectNameValid { get; set;}

		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("showOnHUD")] 		public CBool ShowOnHUD { get; set;}

		[RED("effectNameLocalisationKey")] 		public CString EffectNameLocalisationKey { get; set;}

		[RED("effectDescriptionLocalisationKey")] 		public CString EffectDescriptionLocalisationKey { get; set;}

		[RED("targetEffectName")] 		public CName TargetEffectName { get; set;}

		[RED("shouldPlayTargetEffect")] 		public CBool ShouldPlayTargetEffect { get; set;}

		[RED("onAddedSound")] 		public CName OnAddedSound { get; set;}

		[RED("onRemovedSound")] 		public CName OnRemovedSound { get; set;}

		[RED("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[RED("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public CBaseGameplayEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseGameplayEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}