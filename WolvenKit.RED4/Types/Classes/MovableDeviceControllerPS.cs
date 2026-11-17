using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("MovableDeviceSetup")] 
		public MovableDeviceSetup MovableDeviceSetup
		{
			get => GetPropertyValue<MovableDeviceSetup>();
			set => SetPropertyValue<MovableDeviceSetup>(value);
		}

		[Ordinal(108)] 
		[RED("movableDeviceSkillChecks")] 
		public CHandle<DemolitionContainer> MovableDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<DemolitionContainer>>();
			set => SetPropertyValue<CHandle<DemolitionContainer>>(value);
		}

		public MovableDeviceControllerPS()
		{
			DeviceName = "MovableDevice";
			TweakDBRecord = "Devices.MovableDevice";
			TweakDBDescriptionRecord = "device_descriptions.MovableDevice";
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ShouldScannerShowRole = true;
			MovableDeviceSetup = new MovableDeviceSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
