using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaintenancePanelControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("maintenancePanelSkillChecks")] 
		public CHandle<EngineeringContainer> MaintenancePanelSkillChecks
		{
			get => GetPropertyValue<CHandle<EngineeringContainer>>();
			set => SetPropertyValue<CHandle<EngineeringContainer>>(value);
		}

		public MaintenancePanelControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-MaintenancePanel";
		}
	}
}
