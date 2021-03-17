using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaintenancePanelControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _maintenancePanelSkillChecks;

		[Ordinal(104)] 
		[RED("maintenancePanelSkillChecks")] 
		public CHandle<EngineeringContainer> MaintenancePanelSkillChecks
		{
			get => GetProperty(ref _maintenancePanelSkillChecks);
			set => SetProperty(ref _maintenancePanelSkillChecks, value);
		}

		public MaintenancePanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
