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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
