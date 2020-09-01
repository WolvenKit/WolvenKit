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
		[Ordinal(0)] [RED("("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("("effects", 2,0)] 		public CArray<CHandle<CBaseGameplayEffect>> Effects { get; set;}

		[Ordinal(0)] [RED("("statDeltas", 2,0)] 		public CArray<CFloat> StatDeltas { get; set;}

		[Ordinal(0)] [RED("("cachedDamages", 2,0)] 		public CArray<SEffectCachedDamage> CachedDamages { get; set;}

		[Ordinal(0)] [RED("("isReady")] 		public CBool IsReady { get; set;}

		[Ordinal(0)] [RED("("currentlyAnimatedCS")] 		public CHandle<CBaseGameplayEffect> CurrentlyAnimatedCS { get; set;}

		[Ordinal(0)] [RED("("currentlyPlayedFX", 2,0)] 		public CArray<SCurrentBuffFX> CurrentlyPlayedFX { get; set;}

		[Ordinal(0)] [RED("("pausedEffects", 2,0)] 		public CArray<STemporarilyPausedEffect> PausedEffects { get; set;}

		[Ordinal(0)] [RED("("pausedNotAppliedAutoBuffs", 2,0)] 		public CArray<SPausedAutoEffect> PausedNotAppliedAutoBuffs { get; set;}

		[Ordinal(0)] [RED("("ownerIsWitcher")] 		public CBool OwnerIsWitcher { get; set;}

		[Ordinal(0)] [RED("("isInitializingAutobuffs")] 		public CBool IsInitializingAutobuffs { get; set;}

		[Ordinal(0)] [RED("("hasCriticalStateSaveLock")] 		public CBool HasCriticalStateSaveLock { get; set;}

		[Ordinal(0)] [RED("("criticalStateSaveLockId")] 		public CInt32 CriticalStateSaveLockId { get; set;}

		[Ordinal(0)] [RED("("vitalityAutoRegenOn")] 		public CBool VitalityAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("essenceAutoRegenOn")] 		public CBool EssenceAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("staminaAutoRegenOn")] 		public CBool StaminaAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("moraleAutoRegenOn")] 		public CBool MoraleAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("panicAutoRegenOn")] 		public CBool PanicAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("airAutoRegenOn")] 		public CBool AirAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("swimmingStaminaAutoRegenOn")] 		public CBool SwimmingStaminaAutoRegenOn { get; set;}

		[Ordinal(0)] [RED("("adrenalineAutoRegenOn")] 		public CBool AdrenalineAutoRegenOn { get; set;}

		public W3EffectManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EffectManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}