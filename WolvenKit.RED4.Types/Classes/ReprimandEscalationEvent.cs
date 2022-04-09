using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReprimandEscalationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("startReprimand")] 
		public CBool StartReprimand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("startDeescalate")] 
		public CBool StartDeescalate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ReprimandEscalationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
