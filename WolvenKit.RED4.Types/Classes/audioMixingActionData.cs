using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMixingActionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<audioMixingActionType> ActionType
		{
			get => GetPropertyValue<CEnum<audioMixingActionType>>();
			set => SetPropertyValue<CEnum<audioMixingActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(2)] 
		[RED("tagValue")] 
		public CName TagValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("dbOffset")] 
		public CFloat DbOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("distanceRolloffFactor")] 
		public CFloat DistanceRolloffFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("customParametersSetKey")] 
		public CUInt64 CustomParametersSetKey
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(7)] 
		[RED("customParameters")] 
		public CArray<audioAudSimpleParameter> CustomParameters
		{
			get => GetPropertyValue<CArray<audioAudSimpleParameter>>();
			set => SetPropertyValue<CArray<audioAudSimpleParameter>>(value);
		}

		public audioMixingActionData()
		{
			ActionType = Enums.audioMixingActionType.EmitterTag;
			VoContext = Enums.locVoiceoverContext.Vo_Context_Community;
			DistanceRolloffFactor = 1.000000F;
			CustomParameters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
