using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpperBodyEventsTransition : UpperBodyTransition
	{
		[Ordinal(0)] 
		[RED("switchButtonPushed")] 
		public CBool SwitchButtonPushed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("cyclePushed")] 
		public CBool CyclePushed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cycleBlock")] 
		public CFloat CycleBlock
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("switchPending")] 
		public CBool SwitchPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UpperBodyEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
