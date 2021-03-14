using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		private CHandle<EngDemoContainer> _cleaningMachineSkillChecks;

		[Ordinal(108)] 
		[RED("cleaningMachineSkillChecks")] 
		public CHandle<EngDemoContainer> CleaningMachineSkillChecks
		{
			get
			{
				if (_cleaningMachineSkillChecks == null)
				{
					_cleaningMachineSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "cleaningMachineSkillChecks", cr2w, this);
				}
				return _cleaningMachineSkillChecks;
			}
			set
			{
				if (_cleaningMachineSkillChecks == value)
				{
					return;
				}
				_cleaningMachineSkillChecks = value;
				PropertySet(this);
			}
		}

		public CleaningMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
