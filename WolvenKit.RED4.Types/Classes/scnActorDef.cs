using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnActorDef : RedBaseClass
	{
		private scnActorId _actorId;
		private scnVoicetagId _voicetagId;
		private CEnum<scnEntityAcquisitionPlan> _acquisitionPlan;
		private scnFindEntityInContextParams _findActorInContextParams;
		private scnFindEntityInWorldParams _findActorInWorldParams;
		private scnSpawnDespawnEntityParams _spawnDespawnParams;
		private scnSpawnSetParams _spawnSetParams;
		private scnCommunityParams _communityParams;
		private scnSpawnerParams _spawnerParams;
		private CArray<scnSRRefId> _animSets;
		private scnLipsyncAnimSetSRRefId _lipsyncAnimSet;
		private CArray<scnRidFacialAnimSetSRRefId> _facialAnimSets;
		private CArray<scnRidCyberwareAnimSetSRRefId> _cyberwareAnimSets;
		private CArray<scnRidDeformationAnimSetSRRefId> _deformationAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _bodyCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _facialCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _cyberwareCinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CString _actorName;
		private TweakDBID _specCharacterRecordId;
		private CName _specAppearance;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("voicetagId")] 
		public scnVoicetagId VoicetagId
		{
			get => GetProperty(ref _voicetagId);
			set => SetProperty(ref _voicetagId, value);
		}

		[Ordinal(2)] 
		[RED("acquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan
		{
			get => GetProperty(ref _acquisitionPlan);
			set => SetProperty(ref _acquisitionPlan, value);
		}

		[Ordinal(3)] 
		[RED("findActorInContextParams")] 
		public scnFindEntityInContextParams FindActorInContextParams
		{
			get => GetProperty(ref _findActorInContextParams);
			set => SetProperty(ref _findActorInContextParams, value);
		}

		[Ordinal(4)] 
		[RED("findActorInWorldParams")] 
		public scnFindEntityInWorldParams FindActorInWorldParams
		{
			get => GetProperty(ref _findActorInWorldParams);
			set => SetProperty(ref _findActorInWorldParams, value);
		}

		[Ordinal(5)] 
		[RED("spawnDespawnParams")] 
		public scnSpawnDespawnEntityParams SpawnDespawnParams
		{
			get => GetProperty(ref _spawnDespawnParams);
			set => SetProperty(ref _spawnDespawnParams, value);
		}

		[Ordinal(6)] 
		[RED("spawnSetParams")] 
		public scnSpawnSetParams SpawnSetParams
		{
			get => GetProperty(ref _spawnSetParams);
			set => SetProperty(ref _spawnSetParams, value);
		}

		[Ordinal(7)] 
		[RED("communityParams")] 
		public scnCommunityParams CommunityParams
		{
			get => GetProperty(ref _communityParams);
			set => SetProperty(ref _communityParams, value);
		}

		[Ordinal(8)] 
		[RED("spawnerParams")] 
		public scnSpawnerParams SpawnerParams
		{
			get => GetProperty(ref _spawnerParams);
			set => SetProperty(ref _spawnerParams, value);
		}

		[Ordinal(9)] 
		[RED("animSets")] 
		public CArray<scnSRRefId> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(10)] 
		[RED("lipsyncAnimSet")] 
		public scnLipsyncAnimSetSRRefId LipsyncAnimSet
		{
			get => GetProperty(ref _lipsyncAnimSet);
			set => SetProperty(ref _lipsyncAnimSet, value);
		}

		[Ordinal(11)] 
		[RED("facialAnimSets")] 
		public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets
		{
			get => GetProperty(ref _facialAnimSets);
			set => SetProperty(ref _facialAnimSets, value);
		}

		[Ordinal(12)] 
		[RED("cyberwareAnimSets")] 
		public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets
		{
			get => GetProperty(ref _cyberwareAnimSets);
			set => SetProperty(ref _cyberwareAnimSets, value);
		}

		[Ordinal(13)] 
		[RED("deformationAnimSets")] 
		public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets
		{
			get => GetProperty(ref _deformationAnimSets);
			set => SetProperty(ref _deformationAnimSets, value);
		}

		[Ordinal(14)] 
		[RED("bodyCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets
		{
			get => GetProperty(ref _bodyCinematicAnimSets);
			set => SetProperty(ref _bodyCinematicAnimSets, value);
		}

		[Ordinal(15)] 
		[RED("facialCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets
		{
			get => GetProperty(ref _facialCinematicAnimSets);
			set => SetProperty(ref _facialCinematicAnimSets, value);
		}

		[Ordinal(16)] 
		[RED("cyberwareCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets
		{
			get => GetProperty(ref _cyberwareCinematicAnimSets);
			set => SetProperty(ref _cyberwareCinematicAnimSets, value);
		}

		[Ordinal(17)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetProperty(ref _dynamicAnimSets);
			set => SetProperty(ref _dynamicAnimSets, value);
		}

		[Ordinal(18)] 
		[RED("actorName")] 
		public CString ActorName
		{
			get => GetProperty(ref _actorName);
			set => SetProperty(ref _actorName, value);
		}

		[Ordinal(19)] 
		[RED("specCharacterRecordId")] 
		public TweakDBID SpecCharacterRecordId
		{
			get => GetProperty(ref _specCharacterRecordId);
			set => SetProperty(ref _specCharacterRecordId, value);
		}

		[Ordinal(20)] 
		[RED("specAppearance")] 
		public CName SpecAppearance
		{
			get => GetProperty(ref _specAppearance);
			set => SetProperty(ref _specAppearance, value);
		}
	}
}
