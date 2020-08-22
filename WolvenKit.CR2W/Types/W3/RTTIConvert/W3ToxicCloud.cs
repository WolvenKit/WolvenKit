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
		[RED("poisonDamage")] 		public SAbilityAttributeValue PoisonDamage { get; set;}

		[RED("explosionDamage")] 		public SAbilityAttributeValue ExplosionDamage { get; set;}

		[RED("restorationTime")] 		public CFloat RestorationTime { get; set;}

		[RED("settlingTime")] 		public CFloat SettlingTime { get; set;}

		[RED("fxOnSettle")] 		public CName FxOnSettle { get; set;}

		[RED("fxOnSettleCluster")] 		public CName FxOnSettleCluster { get; set;}

		[RED("fxOnExplode")] 		public CName FxOnExplode { get; set;}

		[RED("fxOnExplodeCluster")] 		public CName FxOnExplodeCluster { get; set;}

		[RED("bIsEnabled")] 		public CBool BIsEnabled { get; set;}

		[RED("usePoisonBuffWithAnim")] 		public CBool UsePoisonBuffWithAnim { get; set;}

		[RED("cameraShakeRadius")] 		public CFloat CameraShakeRadius { get; set;}

		[RED("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[RED("burningChance")] 		public CFloat BurningChance { get; set;}

		[RED("excludedTags", 2,0)] 		public CArray<CName> ExcludedTags { get; set;}

		[RED("chainedExplosion")] 		public CBool ChainedExplosion { get; set;}

		[RED("entitiesInPoisonRange", 2,0)] 		public CArray<CHandle<CActor>> EntitiesInPoisonRange { get; set;}

		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("poisonArea")] 		public CHandle<CTriggerAreaComponent> PoisonArea { get; set;}

		[RED("explosionArea")] 		public CHandle<CTriggerAreaComponent> ExplosionArea { get; set;}

		[RED("explodingTargetDamages", 2,0)] 		public CArray<SRawDamage> ExplodingTargetDamages { get; set;}

		[RED("entitiesInExplosionRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInExplosionRange { get; set;}

		[RED("isFromBomb")] 		public CBool IsFromBomb { get; set;}

		[RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[RED("buffSpecParams")] 		public CHandle<W3BuffDoTParams> BuffSpecParams { get; set;}

		[RED("isFromClusterBomb")] 		public CBool IsFromClusterBomb { get; set;}

		[RED("bombOwner")] 		public CHandle<CActor> BombOwner { get; set;}

		[RED("wasPerk16Active")] 		public CBool WasPerk16Active { get; set;}

		[RED("canMultiplyDamageFromPerk20")] 		public CBool CanMultiplyDamageFromPerk20 { get; set;}

		[RED("friendlyFire")] 		public CBool FriendlyFire { get; set;}

		public W3ToxicCloud(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ToxicCloud(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}