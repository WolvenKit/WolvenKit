using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPetardParams : CVariable
	{
		[RED("damages", 2,0)] 		public CArray<SRawDamage> Damages { get; set;}

		[RED("buffs", 2,0)] 		public CArray<SEffectInfo> Buffs { get; set;}

		[RED("ignoresArmor")] 		public CBool IgnoresArmor { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("cylinderHeight")] 		public CFloat CylinderHeight { get; set;}

		[RED("cylinderOffsetZ")] 		public CFloat CylinderOffsetZ { get; set;}

		[RED("playHitAnimMode")] 		public CEnum<EActionHitAnim> PlayHitAnimMode { get; set;}

		[RED("disabledAbilities", 2,0)] 		public CArray<SBlockedAbility> DisabledAbilities { get; set;}

		[RED("fxPlayedWhenAbilityDisabled", 2,0)] 		public CArray<CName> FxPlayedWhenAbilityDisabled { get; set;}

		[RED("fxStoppedWhenAbilityDisabled", 2,0)] 		public CArray<CName> FxStoppedWhenAbilityDisabled { get; set;}

		[RED("fxPlayedOnHit", 2,0)] 		public CArray<CName> FxPlayedOnHit { get; set;}

		[RED("surfaceFX")] 		public SFXSurfacePostParams SurfaceFX { get; set;}

		[RED("fx", 2,0)] 		public CArray<CName> Fx { get; set;}

		[RED("fxCluster", 2,0)] 		public CArray<CName> FxCluster { get; set;}

		[RED("fxClusterWater", 2,0)] 		public CArray<CName> FxClusterWater { get; set;}

		[RED("fxWater", 2,0)] 		public CArray<CName> FxWater { get; set;}

		[RED("componentsToSnap", 2,0)] 		public CArray<CName> ComponentsToSnap { get; set;}

		[RED("decalComponentNames", 2,0)] 		public CArray<CName> DecalComponentNames { get; set;}

		[RED("decalComponentVisibleTimes", 2,0)] 		public CArray<CFloat> DecalComponentVisibleTimes { get; set;}

		[RED("decalComponentUseRandom")] 		public CBool DecalComponentUseRandom { get; set;}

		[RED("decalComponentScaleModifier")] 		public CFloat DecalComponentScaleModifier { get; set;}

		public SPetardParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPetardParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}