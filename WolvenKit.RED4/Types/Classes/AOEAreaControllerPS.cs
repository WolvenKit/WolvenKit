using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetPropertyValue<AOEAreaSetup>();
			set => SetPropertyValue<AOEAreaSetup>(value);
		}

		public AOEAreaControllerPS()
		{
			DeviceName = "LocKey#188";
			TweakDBRecord = "Devices.AOE_Area";
			TweakDBDescriptionRecord = "device_descriptions.AOE_Area";
			AOEAreaSetup = new AOEAreaSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
