using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayerActorDef : CVariable
	{
		[Ordinal(0)]  [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(1)]  [RED("specTemplate")] public CName SpecTemplate { get; set; }
		[Ordinal(2)]  [RED("specCharacterRecordId")] public TweakDBID SpecCharacterRecordId { get; set; }
		[Ordinal(3)]  [RED("specAppearance")] public CName SpecAppearance { get; set; }
		[Ordinal(4)]  [RED("voicetagId")] public scnVoicetagId VoicetagId { get; set; }
		[Ordinal(5)]  [RED("animSets")] public CArray<scnSRRefId> AnimSets { get; set; }
		[Ordinal(6)]  [RED("lipsyncAnimSet")] public scnLipsyncAnimSetSRRefId LipsyncAnimSet { get; set; }
		[Ordinal(7)]  [RED("facialAnimSets")] public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets { get; set; }
		[Ordinal(8)]  [RED("cyberwareAnimSets")] public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets { get; set; }
		[Ordinal(9)]  [RED("deformationAnimSets")] public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets { get; set; }
		[Ordinal(10)]  [RED("bodyCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets { get; set; }
		[Ordinal(11)]  [RED("facialCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets { get; set; }
		[Ordinal(12)]  [RED("cyberwareCinematicAnimSets")] public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets { get; set; }
		[Ordinal(13)]  [RED("dynamicAnimSets")] public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets { get; set; }
		[Ordinal(14)]  [RED("acquisitionPlan")] public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan { get; set; }
		[Ordinal(15)]  [RED("findNetworkPlayerParams")] public scnFindNetworkPlayerParams FindNetworkPlayerParams { get; set; }
		[Ordinal(16)]  [RED("findActorInContextParams")] public scnFindEntityInContextParams FindActorInContextParams { get; set; }
		[Ordinal(17)]  [RED("playerName")] public CString PlayerName { get; set; }

		public scnPlayerActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
