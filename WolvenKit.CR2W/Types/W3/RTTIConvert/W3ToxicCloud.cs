using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ToxicCloud : CGameplayEntity
	{
		[Ordinal(0)] [RED("("poisonDamage")] 		public SAbilityAttributeValue PoisonDamage { get; set;}

		[Ordinal(0)] [RED("("explosionDamage")] 		public SAbilityAttributeValue ExplosionDamage { get; set;}

		[Ordinal(0)] [RED("("restorationTime")] 		public CFloat RestorationTime { get; set;}

		[Ordinal(0)] [RED("("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[Ordinal(0)] [RED("("fxOnSettle")] 		public CName FxOnSettle { get; set;}

		[Ordinal(0)] [RED("("fxOnSettleCluster")] 		public CName FxOnSettleCluster { get; set;}

		[Ordinal(0)] [RED("("fxOnExplode")] 		public CName FxOnExplode { get; set;}

		[Ordinal(0)] [RED("("fxOnExplodeCluster")] 		public CName FxOnExplodeCluster { get; set;}

		[Ordinal(0)] [RED("("bIsEnabled")] 		public CBool BIsEnabled { get; set;}

		[Ordinal(0)] [RED("("usePoisonBuffWithAnim")] 		public CBool UsePoisonBuffWithAnim { get; set;}

		[Ordinal(0)] [RED("("cameraShakeRadius")] 		public CFloat CameraShakeRadius { get; set;}

		[Ordinal(0)] [RED("("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[Ordinal(0)] [RED("("burningChance")] 		public CFloat BurningChance { get; set;}

		[Ordinal(0)] [RED("("excludedTags", 2,0)] 		public CArray<CName> ExcludedTags { get; set;}

		[Ordinal(0)] [RED("("chainedExplosion")] 		public CBool ChainedExplosion { get; set;}

		[Ordinal(0)] [RED("("entitiesInPoisonRange", 2,0)] 		public CArray<CHandle<CActor>> EntitiesInPoisonRange { get; set;}

		[Ordinal(0)] [RED("("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(0)] [RED("("poisonArea")] 		public CHandle<CTriggerAreaComponent> PoisonArea { get; set;}

		[Ordinal(0)] [RED("("explosionArea")] 		public CHandle<CTriggerAreaComponent> ExplosionArea { get; set;}

		[Ordinal(0)] [RED("("explodingTargetDamages", 2,0)] 		public CArray<SRawDamage> ExplodingTargetDamages { get; set;}

		[Ordinal(0)] [RED("("entitiesInExplosionRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInExplosionRange { get; set;}

		[Ordinal(0)] [RED("("isFromBomb")] 		public CBool IsFromBomb { get; set;}

		[Ordinal(0)] [RED("("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(0)] [RED("("buffSpecParams")] 		public CHandle<W3BuffDoTParams> BuffSpecParams { get; set;}

		[Ordinal(0)] [RED("("isFromClusterBomb")] 		public CBool IsFromClusterBomb { get; set;}

		[Ordinal(0)] [RED("("bombOwner")] 		public CHandle<CActor> BombOwner { get; set;}

		[Ordinal(0)] [RED("("wasPerk16Active")] 		public CBool WasPerk16Active { get; set;}

		[Ordinal(0)] [RED("("canMultiplyDamageFromPerk20")] 		public CBool CanMultiplyDamageFromPerk20 { get; set;}

		[Ordinal(0)] [RED("("friendlyFire")] 		public CBool FriendlyFire { get; set;}

		public W3ToxicCloud(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ToxicCloud(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}