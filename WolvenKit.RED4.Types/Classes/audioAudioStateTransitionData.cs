using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioStateTransitionData : RedBaseClass
	{
		private CUInt8 _targetStateId;
		private CBool _allConditionsFulfilled;
		private CFloat _transitionTime;
		private CFloat _exitTime;
		private CName _exitSignal;
		private CArray<audioAudioSceneVariableReadActionData> _readVariableActions;
		private CArray<CName> _conditions;

		[Ordinal(0)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get => GetProperty(ref _targetStateId);
			set => SetProperty(ref _targetStateId, value);
		}

		[Ordinal(1)] 
		[RED("allConditionsFulfilled")] 
		public CBool AllConditionsFulfilled
		{
			get => GetProperty(ref _allConditionsFulfilled);
			set => SetProperty(ref _allConditionsFulfilled, value);
		}

		[Ordinal(2)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetProperty(ref _transitionTime);
			set => SetProperty(ref _transitionTime, value);
		}

		[Ordinal(3)] 
		[RED("exitTime")] 
		public CFloat ExitTime
		{
			get => GetProperty(ref _exitTime);
			set => SetProperty(ref _exitTime, value);
		}

		[Ordinal(4)] 
		[RED("exitSignal")] 
		public CName ExitSignal
		{
			get => GetProperty(ref _exitSignal);
			set => SetProperty(ref _exitSignal, value);
		}

		[Ordinal(5)] 
		[RED("readVariableActions")] 
		public CArray<audioAudioSceneVariableReadActionData> ReadVariableActions
		{
			get => GetProperty(ref _readVariableActions);
			set => SetProperty(ref _readVariableActions, value);
		}

		[Ordinal(6)] 
		[RED("conditions")] 
		public CArray<CName> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}
