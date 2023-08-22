using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("MovableDeviceSetup")] 
		public MovableDeviceSetup MovableDeviceSetup
		{
			get => GetPropertyValue<MovableDeviceSetup>();
			set => SetPropertyValue<MovableDeviceSetup>(value);
		}

		[Ordinal(105)] 
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
			TweakDBDescriptionRecord = 142248231645;
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ShouldScannerShowRole = true;
			MovableDeviceSetup = new MovableDeviceSetup { NumberOfUses = 1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
