using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get => GetPropertyValue<FanSetup>();
			set => SetPropertyValue<FanSetup>(value);
		}

		public FanControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
