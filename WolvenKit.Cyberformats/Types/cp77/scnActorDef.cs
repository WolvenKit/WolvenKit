using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnActorDef : CVariable
	{
		[Ordinal(0)] [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(1)] [RED("voicetagId")] public scnVoicetagId VoicetagId { get; set; }
		[Ordinal(2)] [RED("acquisitionPlan")] public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan { get; set; }
		[Ordinal(3)] [RED("findActorInContextParams")] public scnFindEntityInContextParams FindActorInContextParams { get; set; }
		[Ordinal(4)] [RED("findActorInWorldParams")] public scnFindEntityInWorldParams FindActorInWorldParams { get; set; }
		[Ordinal(5)] [RED("spawnDespawnParams")] public scnSpawnDespawnEntityParams SpawnDespawnParams { get; set; }
		[Ordinal(6)] [RED("spawnSetParams")] public scnSpawnSetParams SpawnSetParams { get; set; }
		[Ordinal(7)] [RED("communityParams")] public scnCommunityParams CommunityParams { get; set; }
		[Ordinal(8)] [RED("spawnerParams")] public scnSpawnerParams SpawnerParams { get; set; }
		[Ordinal(9)] [RED("animSets")] public CArray<scnSRRefId> AnimSets { get; set; }
		[Ordinal(10)] [RED("lipsyncAnimSet")] public scnLipsyncAnimSetSRRefId LipsyncAnimSet { get; set; }
		[Ordinal(11)] [RED("facialAnimSets")] public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets { get; set; }
		[Ordinal(12)] [RED("cyberwareAnimSets")] public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets { get; set; }
		[Ordinal(13)] [RED("deformationAnimSets")] public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets { get; set; }
		[Ordinal(14)] [RED("bodyCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets { get; set; }
		[Ordinal(15)] [RED("facialCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets { get; set; }
		[Ordinal(16)] [RED("cyberwareCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets { get; set; }
		[Ordinal(17)] [RED("dynamicAnimSets")] public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets { get; set; }
		[Ordinal(18)] [RED("actorName")] public CString ActorName { get; set; }
		[Ordinal(19)] [RED("specCharacterRecordId")] public TweakDBID SpecCharacterRecordId { get; set; }
		[Ordinal(20)] [RED("specAppearance")] public CName SpecAppearance { get; set; }

		public scnActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
