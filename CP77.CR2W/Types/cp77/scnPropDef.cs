using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPropDef : CVariable
	{
		[Ordinal(0)]  [RED("entityAcquisitionPlan")] public CEnum<scnEntityAcquisitionPlan> EntityAcquisitionPlan { get; set; }
		[Ordinal(1)]  [RED("findEntityInEntityParams")] public scnFindEntityInEntityParams FindEntityInEntityParams { get; set; }
		[Ordinal(2)]  [RED("spawnDespawnParams")] public scnSpawnDespawnEntityParams SpawnDespawnParams { get; set; }
		[Ordinal(3)]  [RED("spawnSetParams")] public scnSpawnSetParams SpawnSetParams { get; set; }
		[Ordinal(4)]  [RED("communityParams")] public scnCommunityParams CommunityParams { get; set; }
		[Ordinal(5)]  [RED("spawnerParams")] public scnSpawnerParams SpawnerParams { get; set; }
		[Ordinal(6)]  [RED("findEntityInNodeParams")] public scnFindEntityInNodeParams FindEntityInNodeParams { get; set; }
		[Ordinal(7)]  [RED("findEntityInWorldParams")] public scnFindEntityInWorldParams FindEntityInWorldParams { get; set; }
		[Ordinal(8)]  [RED("propId")] public scnPropId PropId { get; set; }
		[Ordinal(9)]  [RED("propName")] public CString PropName { get; set; }
		[Ordinal(10)]  [RED("specPropRecordId")] public TweakDBID SpecPropRecordId { get; set; }
		[Ordinal(11)]  [RED("animSets")] public CArray<scnRidAnimSetSRRefId> AnimSets { get; set; }
		[Ordinal(12)]  [RED("cinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> CinematicAnimSets { get; set; }
		[Ordinal(13)]  [RED("dynamicAnimSets")] public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets { get; set; }

		public scnPropDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
