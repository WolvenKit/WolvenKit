using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TeleportNodetoSlotOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("gameObjectRef")] 
		public NodeRef GameObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public TeleportNodetoSlotOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
