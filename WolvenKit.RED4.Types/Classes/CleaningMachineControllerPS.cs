using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("cleaningMachineSkillChecks")] 
		public CHandle<EngDemoContainer> CleaningMachineSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public CleaningMachineControllerPS()
		{
			DeviceName = "LocKey#2033";
			TweakDBRecord = new() { Value = 99989064598 };
			TweakDBDescriptionRecord = new() { Value = 151161254181 };
		}
	}
}
