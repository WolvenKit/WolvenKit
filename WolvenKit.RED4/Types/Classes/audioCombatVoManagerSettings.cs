using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCombatVoManagerSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("thresholdDbForCombatDialog")] 
		public CFloat ThresholdDbForCombatDialog
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxVoHearableHorizontalDistance")] 
		public CFloat MaxVoHearableHorizontalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxVoHearableVerticalDistance")] 
		public CFloat MaxVoHearableVerticalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxVoVisibleDistance")] 
		public CFloat MaxVoVisibleDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("triggerVoEventBufferTime")] 
		public CFloat TriggerVoEventBufferTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("triggerIdleChattersTime")] 
		public CFloat TriggerIdleChattersTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("minNoVOTimeNeededToTryPlayingGenericVO")] 
		public CFloat MinNoVOTimeNeededToTryPlayingGenericVO
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("specificVoicesetVoVariationMinRepeatTime")] 
		public CFloat SpecificVoicesetVoVariationMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("forceApucVoiceTagSelectionProbability")] 
		public CFloat ForceApucVoiceTagSelectionProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("voiceTagSelectionRandomTimeOffset")] 
		public CFloat VoiceTagSelectionRandomTimeOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("genericRelaxedVOContexts")] 
		public CArray<CName> GenericRelaxedVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(12)] 
		[RED("genericFearVOContexts")] 
		public CArray<CName> GenericFearVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(13)] 
		[RED("genericAlertedVOContexts")] 
		public CArray<CName> GenericAlertedVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(14)] 
		[RED("genericCombatVOContexts")] 
		public CArray<CName> GenericCombatVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(15)] 
		[RED("genericCombatLosingVOContexts")] 
		public CArray<CName> GenericCombatLosingVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("genericCombatSingleEnemyVOContexts")] 
		public CArray<CName> GenericCombatSingleEnemyVOContexts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioCombatVoManagerSettings()
		{
			ThresholdDbForCombatDialog = -200.000000F;
			MaxVoHearableHorizontalDistance = 8.000000F;
			MaxVoHearableVerticalDistance = 3.000000F;
			MaxVoVisibleDistance = 30.000000F;
			TriggerVoEventBufferTime = 0.200000F;
			TriggerIdleChattersTime = 1.000000F;
			MinNoVOTimeNeededToTryPlayingGenericVO = 12.000000F;
			SpecificVoicesetVoVariationMinRepeatTime = 60.000000F;
			ForceApucVoiceTagSelectionProbability = 0.500000F;
			VoiceTagSelectionRandomTimeOffset = 1.000000F;
			GenericRelaxedVOContexts = new();
			GenericFearVOContexts = new();
			GenericAlertedVOContexts = new();
			GenericCombatVOContexts = new();
			GenericCombatLosingVOContexts = new();
			GenericCombatSingleEnemyVOContexts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
