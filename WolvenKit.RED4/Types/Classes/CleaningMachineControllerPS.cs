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
			TweakDBRecord = 99989064598;
			TweakDBDescriptionRecord = 151161254181;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
