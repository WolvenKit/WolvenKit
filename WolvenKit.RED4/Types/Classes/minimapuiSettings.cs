using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class minimapuiSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("showTime")] 
		public CFloat ShowTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("hideTime")] 
		public CFloat HideTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public minimapuiSettings()
		{
			ShowTime = 0.300000F;
			HideTime = 0.250000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
