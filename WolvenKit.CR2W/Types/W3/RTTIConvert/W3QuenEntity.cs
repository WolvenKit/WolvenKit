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
		[Ordinal(0)] [RED("("effects", 2,0)] 		public CArray<SQuenEffects> Effects { get; set;}

		[Ordinal(0)] [RED("("hitEntityTemplate")] 		public CHandle<CEntityTemplate> HitEntityTemplate { get; set;}

		[Ordinal(0)] [RED("("shieldDuration")] 		public CFloat ShieldDuration { get; set;}

		[Ordinal(0)] [RED("("shieldHealth")] 		public CFloat ShieldHealth { get; set;}

		[Ordinal(0)] [RED("("initialShieldHealth")] 		public CFloat InitialShieldHealth { get; set;}

		[Ordinal(0)] [RED("("dischargePercent")] 		public CFloat DischargePercent { get; set;}

		[Ordinal(0)] [RED("("ownerBoneIndex")] 		public CInt32 OwnerBoneIndex { get; set;}

		[Ordinal(0)] [RED("("blockedAllDamage")] 		public CBool BlockedAllDamage { get; set;}

		[Ordinal(0)] [RED("("shieldStartTime")] 		public EngineTime ShieldStartTime { get; set;}

		[Ordinal(0)] [RED("("hitEntityTimestamps", 2,0)] 		public CArray<EngineTime> HitEntityTimestamps { get; set;}

		[Ordinal(0)] [RED("("MIN_HIT_ENTITY_SPAWN_DELAY")] 		public CFloat MIN_HIT_ENTITY_SPAWN_DELAY { get; set;}

		[Ordinal(0)] [RED("("hitDoTEntities", 2,0)] 		public CArray<CHandle<W3VisualFx>> HitDoTEntities { get; set;}

		[Ordinal(0)] [RED("("showForceFinishedFX")] 		public CBool ShowForceFinishedFX { get; set;}

		[Ordinal(0)] [RED("("freeFromBearSetBonus")] 		public CBool FreeFromBearSetBonus { get; set;}

		public W3QuenEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuenEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}