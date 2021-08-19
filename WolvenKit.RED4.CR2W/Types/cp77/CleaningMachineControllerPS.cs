using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		private CHandle<EngDemoContainer> _cleaningMachineSkillChecks;

		[Ordinal(109)] 
		[RED("cleaningMachineSkillChecks")] 
		public CHandle<EngDemoContainer> CleaningMachineSkillChecks
		{
			get => GetProperty(ref _cleaningMachineSkillChecks);
			set => SetProperty(ref _cleaningMachineSkillChecks, value);
		}

		public CleaningMachineControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
