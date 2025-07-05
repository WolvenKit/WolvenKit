using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimeDilationParameters : IScriptable
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("timeDilation")] 
		public CFloat TimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("playerTimeDilation")] 
		public CFloat PlayerTimeDilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TimeDilationParameters()
		{
			TimeDilation = 0.010000F;
			PlayerTimeDilation = 0.010000F;
			Duration = 9999.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
