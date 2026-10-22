using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("cleaningMachineSkillChecks")] 
		public CHandle<EngDemoContainer> CleaningMachineSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public CleaningMachineControllerPS()
		{
			DeviceName = "LocKey#2033";
			TweakDBRecord = "Devices.CleaningMachine";
			TweakDBDescriptionRecord = "device_descriptions.CleaningMachine";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
