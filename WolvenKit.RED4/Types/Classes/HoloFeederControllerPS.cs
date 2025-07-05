using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloFeederControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("turnOnSFX")] 
		public CName TurnOnSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(108)] 
		[RED("turnOffSFX")] 
		public CName TurnOffSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HoloFeederControllerPS()
		{
			DeviceName = "LocKey#95";
			TweakDBRecord = 77660230936;
			TweakDBDescriptionRecord = 131405305371;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
