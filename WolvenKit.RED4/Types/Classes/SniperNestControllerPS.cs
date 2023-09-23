using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SniperNestControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(150)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(151)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SniperNestControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
