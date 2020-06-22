using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EffectManager : CObject
	{
		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("effects", 2,0)] 		public CArray<CHandle<CBaseGameplayEffect>> Effects { get; set;}

		[RED("statDeltas", 2,0)] 		public CArray<CFloat> StatDeltas { get; set;}

		[RED("cachedDamages", 2,0)] 		public CArray<SEffectCachedDamage> CachedDamages { get; set;}

		[RED("isReady")] 		public CBool IsReady { get; set;}

		[RED("currentlyAnimatedCS")] 		public CHandle<CBaseGameplayEffect> CurrentlyAnimatedCS { get; set;}

		[RED("currentlyPlayedFX", 2,0)] 		public CArray<SCurrentBuffFX> CurrentlyPlayedFX { get; set;}

		[RED("pausedEffects", 2,0)] 		public CArray<STemporarilyPausedEffect> PausedEffects { get; set;}

		[RED("pausedNotAppliedAutoBuffs", 2,0)] 		public CArray<SPausedAutoEffect> PausedNotAppliedAutoBuffs { get; set;}

		[RED("ownerIsWitcher")] 		public CBool OwnerIsWitcher { get; set;}

		[RED("isInitializingAutobuffs")] 		public CBool IsInitializingAutobuffs { get; set;}

		[RED("hasCriticalStateSaveLock")] 		public CBool HasCriticalStateSaveLock { get; set;}

		[RED("criticalStateSaveLockId")] 		public CInt32 CriticalStateSaveLockId { get; set;}

		[RED("vitalityAutoRegenOn")] 		public CBool VitalityAutoRegenOn { get; set;}

		[RED("essenceAutoRegenOn")] 		public CBool EssenceAutoRegenOn { get; set;}

		[RED("staminaAutoRegenOn")] 		public CBool StaminaAutoRegenOn { get; set;}

		[RED("moraleAutoRegenOn")] 		public CBool MoraleAutoRegenOn { get; set;}

		[RED("panicAutoRegenOn")] 		public CBool PanicAutoRegenOn { get; set;}

		[RED("airAutoRegenOn")] 		public CBool AirAutoRegenOn { get; set;}

		[RED("swimmingStaminaAutoRegenOn")] 		public CBool SwimmingStaminaAutoRegenOn { get; set;}

		[RED("adrenalineAutoRegenOn")] 		public CBool AdrenalineAutoRegenOn { get; set;}

		public W3EffectManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EffectManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}