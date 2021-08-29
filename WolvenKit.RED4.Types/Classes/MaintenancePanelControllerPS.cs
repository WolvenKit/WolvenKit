using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaintenancePanelControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _maintenancePanelSkillChecks;

		[Ordinal(105)] 
		[RED("maintenancePanelSkillChecks")] 
		public CHandle<EngineeringContainer> MaintenancePanelSkillChecks
		{
			get => GetProperty(ref _maintenancePanelSkillChecks);
			set => SetProperty(ref _maintenancePanelSkillChecks, value);
		}
	}
}
