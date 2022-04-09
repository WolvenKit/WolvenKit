using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateMachineConditionalEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIAnimStateTransitionCondition>>();
			set => SetPropertyValue<CHandle<animIAnimStateTransitionCondition>>(value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimStateMachineConditionalEntry()
		{
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
