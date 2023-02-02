using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimeDilationFocusModeEvents : TimeDilationEventsTransitions
	{
		[Ordinal(0)] 
		[RED("timeDilation")] 
		public CFloat TimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("playerDilation")] 
		public CFloat PlayerDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("applyTimeDilationToPlayer")] 
		public CBool ApplyTimeDilationToPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("timeDilationReason")] 
		public CName TimeDilationReason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TimeDilationFocusModeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
