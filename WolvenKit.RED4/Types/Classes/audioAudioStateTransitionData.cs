using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioStateTransitionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("allConditionsFulfilled")] 
		public CBool AllConditionsFulfilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("exitTime")] 
		public CFloat ExitTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("exitSignal")] 
		public CName ExitSignal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("readVariableActions")] 
		public CArray<audioAudioSceneVariableReadActionData> ReadVariableActions
		{
			get => GetPropertyValue<CArray<audioAudioSceneVariableReadActionData>>();
			set => SetPropertyValue<CArray<audioAudioSceneVariableReadActionData>>(value);
		}

		[Ordinal(6)] 
		[RED("conditions")] 
		public CArray<CName> Conditions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioAudioStateTransitionData()
		{
			AllConditionsFulfilled = true;
			ReadVariableActions = new();
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
