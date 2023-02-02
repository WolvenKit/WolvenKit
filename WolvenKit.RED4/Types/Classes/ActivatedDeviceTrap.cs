using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceTrap : ActivatedDeviceTransfromAnim
	{
		[Ordinal(95)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		public ActivatedDeviceTrap()
		{
			ControllerTypeName = "ActivatedDeviceController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
