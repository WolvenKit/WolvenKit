using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayerActorDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("specTemplate")] 
		public CName SpecTemplate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("specCharacterRecordId")] 
		public TweakDBID SpecCharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("specAppearance")] 
		public CName SpecAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("voicetagId")] 
		public scnVoicetagId VoicetagId
		{
			get => GetPropertyValue<scnVoicetagId>();
			set => SetPropertyValue<scnVoicetagId>(value);
		}

		[Ordinal(5)] 
		[RED("animSets")] 
		public CArray<scnSRRefId> AnimSets
		{
			get => GetPropertyValue<CArray<scnSRRefId>>();
			set => SetPropertyValue<CArray<scnSRRefId>>(value);
		}

		[Ordinal(6)] 
		[RED("lipsyncAnimSet")] 
		public scnLipsyncAnimSetSRRefId LipsyncAnimSet
		{
			get => GetPropertyValue<scnLipsyncAnimSetSRRefId>();
			set => SetPropertyValue<scnLipsyncAnimSetSRRefId>(value);
		}

		[Ordinal(7)] 
		[RED("facialAnimSets")] 
		public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets
		{
			get => GetPropertyValue<CArray<scnRidFacialAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidFacialAnimSetSRRefId>>(value);
		}

		[Ordinal(8)] 
		[RED("cyberwareAnimSets")] 
		public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets
		{
			get => GetPropertyValue<CArray<scnRidCyberwareAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidCyberwareAnimSetSRRefId>>(value);
		}

		[Ordinal(9)] 
		[RED("deformationAnimSets")] 
		public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets
		{
			get => GetPropertyValue<CArray<scnRidDeformationAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnRidDeformationAnimSetSRRefId>>(value);
		}

		[Ordinal(10)] 
		[RED("bodyCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(11)] 
		[RED("facialCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(12)] 
		[RED("cyberwareCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRefId>>(value);
		}

		[Ordinal(13)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get => GetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>();
			set => SetPropertyValue<CArray<scnDynamicAnimSetSRRefId>>(value);
		}

		[Ordinal(14)] 
		[RED("acquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan
		{
			get => GetPropertyValue<CEnum<scnEntityAcquisitionPlan>>();
			set => SetPropertyValue<CEnum<scnEntityAcquisitionPlan>>(value);
		}

		[Ordinal(15)] 
		[RED("findNetworkPlayerParams")] 
		public scnFindNetworkPlayerParams FindNetworkPlayerParams
		{
			get => GetPropertyValue<scnFindNetworkPlayerParams>();
			set => SetPropertyValue<scnFindNetworkPlayerParams>(value);
		}

		[Ordinal(16)] 
		[RED("findActorInContextParams")] 
		public scnFindEntityInContextParams FindActorInContextParams
		{
			get => GetPropertyValue<scnFindEntityInContextParams>();
			set => SetPropertyValue<scnFindEntityInContextParams>(value);
		}

		[Ordinal(17)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public scnPlayerActorDef()
		{
			ActorId = new scnActorId { Id = uint.MaxValue };
			SpecTemplate = "(None)";
			SpecAppearance = "default";
			VoicetagId = new scnVoicetagId();
			AnimSets = new();
			LipsyncAnimSet = new scnLipsyncAnimSetSRRefId { Id = uint.MaxValue };
			FacialAnimSets = new();
			CyberwareAnimSets = new();
			DeformationAnimSets = new();
			BodyCinematicAnimSets = new();
			FacialCinematicAnimSets = new();
			CyberwareCinematicAnimSets = new();
			DynamicAnimSets = new();
			FindNetworkPlayerParams = new scnFindNetworkPlayerParams();
			FindActorInContextParams = new scnFindEntityInContextParams { VoiceVagId = new scnVoicetagId() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
