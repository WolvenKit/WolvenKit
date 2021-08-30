using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMixingActionData : RedBaseClass
	{
		private CEnum<audioMixingActionType> _actionType;
		private CEnum<locVoiceoverContext> _voContext;
		private CName _tagValue;
		private CFloat _dbOffset;
		private CFloat _distanceRolloffFactor;
		private CName _voEventOverride;
		private CUInt64 _customParametersSetKey;
		private CArray<audioAudSimpleParameter> _customParameters;

		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<audioMixingActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(1)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get => GetProperty(ref _voContext);
			set => SetProperty(ref _voContext, value);
		}

		[Ordinal(2)] 
		[RED("tagValue")] 
		public CName TagValue
		{
			get => GetProperty(ref _tagValue);
			set => SetProperty(ref _tagValue, value);
		}

		[Ordinal(3)] 
		[RED("dbOffset")] 
		public CFloat DbOffset
		{
			get => GetProperty(ref _dbOffset);
			set => SetProperty(ref _dbOffset, value);
		}

		[Ordinal(4)] 
		[RED("distanceRolloffFactor")] 
		public CFloat DistanceRolloffFactor
		{
			get => GetProperty(ref _distanceRolloffFactor);
			set => SetProperty(ref _distanceRolloffFactor, value);
		}

		[Ordinal(5)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get => GetProperty(ref _voEventOverride);
			set => SetProperty(ref _voEventOverride, value);
		}

		[Ordinal(6)] 
		[RED("customParametersSetKey")] 
		public CUInt64 CustomParametersSetKey
		{
			get => GetProperty(ref _customParametersSetKey);
			set => SetProperty(ref _customParametersSetKey, value);
		}

		[Ordinal(7)] 
		[RED("customParameters")] 
		public CArray<audioAudSimpleParameter> CustomParameters
		{
			get => GetProperty(ref _customParameters);
			set => SetProperty(ref _customParameters, value);
		}

		public audioMixingActionData()
		{
			_actionType = new() { Value = Enums.audioMixingActionType.EmitterTag };
			_voContext = new() { Value = Enums.locVoiceoverContext.Vo_Context_Community };
			_distanceRolloffFactor = 1.000000F;
		}
	}
}
