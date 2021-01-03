using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnActorDef : CVariable
	{
		[Ordinal(0)]  [RED("acquisitionPlan")] public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan { get; set; }
		[Ordinal(1)]  [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(2)]  [RED("actorName")] public CString ActorName { get; set; }
		[Ordinal(3)]  [RED("animSets")] public CArray<scnSRRefId> AnimSets { get; set; }
		[Ordinal(4)]  [RED("bodyCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets { get; set; }
		[Ordinal(5)]  [RED("communityParams")] public scnCommunityParams CommunityParams { get; set; }
		[Ordinal(6)]  [RED("cyberwareAnimSets")] public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets { get; set; }
		[Ordinal(7)]  [RED("cyberwareCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets { get; set; }
		[Ordinal(8)]  [RED("deformationAnimSets")] public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets { get; set; }
		[Ordinal(9)]  [RED("dynamicAnimSets")] public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets { get; set; }
		[Ordinal(10)]  [RED("facialAnimSets")] public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets { get; set; }
		[Ordinal(11)]  [RED("facialCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets { get; set; }
		[Ordinal(12)]  [RED("findActorInContextParams")] public scnFindEntityInContextParams FindActorInContextParams { get; set; }
		[Ordinal(13)]  [RED("findActorInWorldParams")] public scnFindEntityInWorldParams FindActorInWorldParams { get; set; }
		[Ordinal(14)]  [RED("lipsyncAnimSet")] public scnLipsyncAnimSetSRRefId LipsyncAnimSet { get; set; }
		[Ordinal(15)]  [RED("spawnDespawnParams")] public scnSpawnDespawnEntityParams SpawnDespawnParams { get; set; }
		[Ordinal(16)]  [RED("spawnSetParams")] public scnSpawnSetParams SpawnSetParams { get; set; }
		[Ordinal(17)]  [RED("spawnerParams")] public scnSpawnerParams SpawnerParams { get; set; }
		[Ordinal(18)]  [RED("specAppearance")] public CName SpecAppearance { get; set; }
		[Ordinal(19)]  [RED("specCharacterRecordId")] public TweakDBID SpecCharacterRecordId { get; set; }
		[Ordinal(20)]  [RED("voicetagId")] public scnVoicetagId VoicetagId { get; set; }

		public scnActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
