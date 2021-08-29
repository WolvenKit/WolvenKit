using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		private CHandle<EngDemoContainer> _cleaningMachineSkillChecks;

		[Ordinal(109)] 
		[RED("cleaningMachineSkillChecks")] 
		public CHandle<EngDemoContainer> CleaningMachineSkillChecks
		{
			get => GetProperty(ref _cleaningMachineSkillChecks);
			set => SetProperty(ref _cleaningMachineSkillChecks, value);
		}
	}
}
