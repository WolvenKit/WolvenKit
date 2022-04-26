using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFlybySettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("flybyEvent")] 
		public CName FlybyEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioFlybySettings()
		{
			MovementSpeed = 15.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
