using System.IO;using System.Runtime.Serialization;
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

		public W3ToxicCloud(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ToxicCloud(cr2w);

	}
}