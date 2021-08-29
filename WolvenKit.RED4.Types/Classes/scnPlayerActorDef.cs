using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPlayerActorDef : RedBaseClass
	{
		private scnActorId _actorId;
		private CName _specTemplate;
		private TweakDBID _specCharacterRecordId;
		private CName _specAppearance;
		private scnVoicetagId _voicetagId;
		private CArray<scnSRRefId> _animSets;
		private scnLipsyncAnimSetSRRefId _lipsyncAnimSet;
		private CArray<scnRidFacialAnimSetSRRefId> _facialAnimSets;
		private CArray<scnRidCyberwareAnimSetSRRefId> _cyberwareAnimSets;
		private CArray<scnRidDeformationAnimSetSRRefId> _deformationAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _bodyCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _facialCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _cyberwareCinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CEnum<scnEntityAcquisitionPlan> _acquisitionPlan;
		private scnFindNetworkPlayerParams _findNetworkPlayerParams;
		private scnFindEntityInContextParams _findActorInContextParams;
		private CString _playerName;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("specTemplate")] 
		public CName SpecTemplate
		{
			get => GetProperty(ref _specTemplate);
			set => SetProperty(ref _specTemplate, value);
		}

		[Ordinal(2)] 
		[RED("specCharacterRecordId")] 
		public TweakDBID SpecCharacterRecordId
		{
			get => GetProperty(ref _specCharacterRecordId);
			set => SetProperty(ref _specCharacterRecordId, value);
		}

		[Ordinal(3)] 
		[RED("specAppearance")] 
		public CName SpecAppearance
		{
			get => GetProperty(ref _specAppearance);
			set => SetProperty(ref _specAppearance, value);
		}

		[Ordinal(4)] 
		[RED("voicetagId")] 
		public scnVoicetagId VoicetagId
		{
			get => GetProperty(ref _voicetagId);
			set => SetProperty(ref _voicetagId, value);
		}

		[Ordinal(5)] 
		[RED("animSets")] 
		public CArray<scnSRRefId> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(6)] 
		[RED("lipsyncAnimSet")] 
		public scnLipsyncAnimSetSRRefId LipsyncAnimSet
		{
			get => GetProperty(ref _lipsyncAnimSet);
			set => SetProperty(ref _lipsyncAnimSet, value);
		}

		[Ordinal(7)] 
		[RED("facialAnimSets")] 
		public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets
		{
			get => GetProperty(ref _facialAnimSets);
			set => SetProperty(ref _facialAnimSets, value);
		}

		[Ordinal(8)] 
		[RED("cyberwareAnimSets")] 
		public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets
		{
			get => GetProperty(ref _cyberwareAnimSets);
			set => SetProperty(ref _cyberwareAnimSets, value);
		}

		[Ordinal(9)] 
		[RED("deformationAnimSets")] 
		public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets
		{
			get => GetProperty(ref _deformationAnimSets);
			set => SetProperty(ref _deformationAnimSets, value);
		}

		[Ordinal(10)] 
		[RED("bodyCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets
		{
			get => GetProperty(ref _bodyCinematicAnimSets);
			set => SetProperty(ref _bodyCinematicAnimSets, value);
		}

		[Ordinal(11)] 
		[RED("facialCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets
		{
			get => GetProperty(ref _facialCinematicAnimSets);
			set => SetProperty(ref _facialCinematicAnimSets, value);
		}

		[Ordinal(12)] 
		[RED("cyberwareCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets
		{
			get => GetProperty(ref _cyberwareCinematicAnimSets);
			set => SetProperty(ref _cyberwareCinematicAnimSets, value);
		}

		[Ordinal(13)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetProperty(ref _dynamicAnimSets);
			set => SetProperty(ref _dynamicAnimSets, value);
		}

		[Ordinal(14)] 
		[RED("acquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan
		{
			get => GetProperty(ref _acquisitionPlan);
			set => SetProperty(ref _acquisitionPlan, value);
		}

		[Ordinal(15)] 
		[RED("findNetworkPlayerParams")] 
		public scnFindNetworkPlayerParams FindNetworkPlayerParams
		{
			get => GetProperty(ref _findNetworkPlayerParams);
			set => SetProperty(ref _findNetworkPlayerParams, value);
		}

		[Ordinal(16)] 
		[RED("findActorInContextParams")] 
		public scnFindEntityInContextParams FindActorInContextParams
		{
			get => GetProperty(ref _findActorInContextParams);
			set => SetProperty(ref _findActorInContextParams, value);
		}

		[Ordinal(17)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get => GetProperty(ref _playerName);
			set => SetProperty(ref _playerName, value);
		}
	}
}
