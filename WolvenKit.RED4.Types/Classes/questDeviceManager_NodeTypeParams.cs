using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDeviceManager_NodeTypeParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("deviceAction")] 
		public CName DeviceAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("actionProperties")] 
		public CArray<questDeviceManager_ActionProperty> ActionProperties
		{
			get => GetPropertyValue<CArray<questDeviceManager_ActionProperty>>();
			set => SetPropertyValue<CArray<questDeviceManager_ActionProperty>>(value);
		}

		public questDeviceManager_NodeTypeParams()
		{
			EntityRef = new() { Names = new() };
			ActionProperties = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
