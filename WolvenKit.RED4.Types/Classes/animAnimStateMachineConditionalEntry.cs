using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateMachineConditionalEntry : ISerializable
	{
		private CUInt32 _targetStateIndex;
		private CHandle<animIAnimStateTransitionCondition> _condition;
		private CBool _isEnabled;
		private CInt32 _priority;
		private CBool _isForcedToTrue;

		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get => GetProperty(ref _targetStateIndex);
			set => SetProperty(ref _targetStateIndex, value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(4)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get => GetProperty(ref _isForcedToTrue);
			set => SetProperty(ref _isForcedToTrue, value);
		}

		public animAnimStateMachineConditionalEntry()
		{
			_isEnabled = true;
		}
	}
}
