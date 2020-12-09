using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPetardParams : CVariable
	{
		[Ordinal(1)] [RED("damages", 2,0)] 		public CArray<SRawDamage> Damages { get; set;}

		[Ordinal(2)] [RED("buffs", 2,0)] 		public CArray<SEffectInfo> Buffs { get; set;}

		[Ordinal(3)] [RED("ignoresArmor")] 		public CBool IgnoresArmor { get; set;}

		[Ordinal(4)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(5)] [RED("cylinderHeight")] 		public CFloat CylinderHeight { get; set;}

		[Ordinal(6)] [RED("cylinderOffsetZ")] 		public CFloat CylinderOffsetZ { get; set;}

		[Ordinal(7)] [RED("playHitAnimMode")] 		public CEnum<EActionHitAnim> PlayHitAnimMode { get; set;}

		[Ordinal(8)] [RED("disabledAbilities", 2,0)] 		public CArray<SBlockedAbility> DisabledAbilities { get; set;}

		[Ordinal(9)] [RED("fxPlayedWhenAbilityDisabled", 2,0)] 		public CArray<CName> FxPlayedWhenAbilityDisabled { get; set;}

		[Ordinal(10)] [RED("fxStoppedWhenAbilityDisabled", 2,0)] 		public CArray<CName> FxStoppedWhenAbilityDisabled { get; set;}

		[Ordinal(11)] [RED("fxPlayedOnHit", 2,0)] 		public CArray<CName> FxPlayedOnHit { get; set;}

		[Ordinal(12)] [RED("surfaceFX")] 		public SFXSurfacePostParams SurfaceFX { get; set;}

		[Ordinal(13)] [RED("fx", 2,0)] 		public CArray<CName> Fx { get; set;}

		[Ordinal(14)] [RED("fxCluster", 2,0)] 		public CArray<CName> FxCluster { get; set;}

		[Ordinal(15)] [RED("fxClusterWater", 2,0)] 		public CArray<CName> FxClusterWater { get; set;}

		[Ordinal(16)] [RED("fxWater", 2,0)] 		public CArray<CName> FxWater { get; set;}

		[Ordinal(17)] [RED("componentsToSnap", 2,0)] 		public CArray<CName> ComponentsToSnap { get; set;}

		[Ordinal(18)] [RED("decalComponentNames", 2,0)] 		public CArray<CName> DecalComponentNames { get; set;}

		[Ordinal(19)] [RED("decalComponentVisibleTimes", 2,0)] 		public CArray<CFloat> DecalComponentVisibleTimes { get; set;}

		[Ordinal(20)] [RED("decalComponentUseRandom")] 		public CBool DecalComponentUseRandom { get; set;}

		[Ordinal(21)] [RED("decalComponentScaleModifier")] 		public CFloat DecalComponentScaleModifier { get; set;}

		public SPetardParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPetardParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}