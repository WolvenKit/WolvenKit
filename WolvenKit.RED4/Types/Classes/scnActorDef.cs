using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnActorDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("voicetagId")] 
		public scnVoicetagId VoicetagId
		{
			get => GetPropertyValue<scnVoicetagId>();
			set => SetPropertyValue<scnVoicetagId>(value);
		}

		[Ordinal(2)] 
		[RED("acquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan
		{
			get => GetPropertyValue<CEnum<scnEntityAcquisitionPlan>>();
			set => SetPropertyValue<CEnum<scnEntityAcquisitionPlan>>(value);
		}

		[Ordinal(3)] 
		[RED("findActorInContextParams")] 
		public scnFindEntityInContextParams FindActorInContextParams
		{
			get => GetPropertyValue<scnFindEntityInContextParams>();
			set => SetPropertyValue<scnFindEntityInContextParams>(value);
		}

		[Ordinal(4)] 
		[RED("findActorInWorldParams")] 
		public scnFindEntityInWorldParams FindActorInWorldParams
		{
			get => GetPropertyValue<scnFindEntityInWorldParams>();
			set => SetPropertyValue<scnFindEntityInWorldParams>(value);
		}

		[Ordinal(5)] 
		[RED("spawnDespawnParams")] 
		public scnSpawnDespawnEntityParams SpawnDespawnParams
		{
			get => GetPropertyValue<scnSpawnDespawnEntityParams>();
			set => SetPropertyValue<scnSpawnDespawnEntityParams>(value);
		}

		[Ordinal(6)] 
		[RED("spawnSetParams")] 
		public scnSpawnSetParams SpawnSetParams
		{
			get => GetPropertyValue<scnSpawnSetParams>();
			set => SetPropertyValue<scnSpawnSetParams>(value);
		}

		[Ordinal(7)] 
		[RED("communityParams")] 
		public scnCommunityParams CommunityParams
		{
			get => GetPropertyValue<scnCommunityParams>();
			set => SetPropertyValue<scnCommunityParams>(value);
		}

		[Ordinal(8)] 
		[RED("spawnerParams")] 
		public scnSpawnerParams SpawnerParams
		{
			get => GetPropertyValue<scnSpawnerParams>();
			set => SetPropertyValue<scnSpawnerParams>(value);
		}

		[Ordinal(9)] 
		[RED("animSets")] 
		public CArray<scnSRRefId> AnimSets
		{
			get => GetPropertyValue<CArray<scnSRRefId>>();
			set => SetPropertyValue<CArray<scnSRRefId>>(value);
		}

		[Ordinal(10)] 
		[RED("lipsyncAnimSet")] 
		public scnLipsyncAnimSetSRRefId LipsyncAnimSet
		{
			get => GetPropertyValue<scnLipsyncAnimSetSRRefId>();
			set => SetPropertyValue<scnLipsyncAnimSetSRRefId>(value);
		}

		[Ordinal(11)] 
		[RED("facialAnimSets")] 
		public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets
		{
			get => GetPropertyValue<CArray<scnRidFacialAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidFacialAnimSetSRRefId>>(value);
		}

		[Ordinal(12)] 
		[RED("cyberwareAnimSets")] 
		public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets
		{
			get => GetPropertyValue<CArray<scnRidCyberwareAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidCyberwareAnimSetSRRefId>>(value);
		}

		[Ordinal(13)] 
		[RED("deformationAnimSets")] 
		public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets
		{
			get => GetPropertyValue<CArray<scnRidDeformationAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidDeformationAnimSetSRRefId>>(value);
		}

		[Ordinal(14)] 
		[RED("bodyCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(15)] 
		[RED("facialCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(16)] 
		[RED("cyberwareCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(17)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>(value);
		}

		[Ordinal(18)] 
		[RED("holocallInitScn")] 
		public CResourceAsyncReference<CResource> HolocallInitScn
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(19)] 
		[RED("actorName")] 
		public CString ActorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(20)] 
		[RED("specCharacterRecordId")] 
		public TweakDBID SpecCharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(21)] 
		[RED("specAppearance")] 
		public CName SpecAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnActorDef()
		{
			ActorId = new() { Id = 4294967295 };
			VoicetagId = new();
			FindActorInContextParams = new() { VoiceVagId = new() };
			FindActorInWorldParams = new() { ActorRef = new() { Names = new() } };
			SpawnDespawnParams = new() { SpawnOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } }, ItemOwnerId = new() { Id = 4294967040 }, SpawnOnStart = true, IsEnabled = true, ValidateSpawnPostion = true };
			SpawnSetParams = new();
			CommunityParams = new();
			SpawnerParams = new();
			AnimSets = new();
			LipsyncAnimSet = new() { Id = 4294967295 };
			FacialAnimSets = new();
			CyberwareAnimSets = new();
			DeformationAnimSets = new();
			BodyCinematicAnimSets = new();
			FacialCinematicAnimSets = new();
			CyberwareCinematicAnimSets = new();
			DynamicAnimSets = new();
			SpecAppearance = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
