using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MaintenancePanel : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		public MaintenancePanel()
		{
			ControllerTypeName = "MaintenancePanelController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
