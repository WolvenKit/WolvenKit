using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuenEntity : W3SignEntity
	{
		[RED("effects", 2,0)] 		public CArray<SQuenEffects> Effects { get; set;}

		[RED("hitEntityTemplate")] 		public CHandle<CEntityTemplate> HitEntityTemplate { get; set;}

		[RED("shieldDuration")] 		public CFloat ShieldDuration { get; set;}

		[RED("shieldHealth")] 		public CFloat ShieldHealth { get; set;}

		[RED("initialShieldHealth")] 		public CFloat InitialShieldHealth { get; set;}

		[RED("dischargePercent")] 		public CFloat DischargePercent { get; set;}

		[RED("ownerBoneIndex")] 		public CInt32 OwnerBoneIndex { get; set;}

		[RED("blockedAllDamage")] 		public CBool BlockedAllDamage { get; set;}

		[RED("shieldStartTime")] 		public EngineTime ShieldStartTime { get; set;}

		[RED("hitEntityTimestamps", 2,0)] 		public CArray<EngineTime> HitEntityTimestamps { get; set;}

		[RED("MIN_HIT_ENTITY_SPAWN_DELAY")] 		public CFloat MIN_HIT_ENTITY_SPAWN_DELAY { get; set;}

		[RED("hitDoTEntities", 2,0)] 		public CArray<CHandle<W3VisualFx>> HitDoTEntities { get; set;}

		[RED("showForceFinishedFX")] 		public CBool ShowForceFinishedFX { get; set;}

		[RED("freeFromBearSetBonus")] 		public CBool FreeFromBearSetBonus { get; set;}

		public W3QuenEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuenEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}