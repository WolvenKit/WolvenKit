using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_Stop : questTimeDilation_Operation
	{
		[Ordinal(0)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questTimeDilation_Stop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
