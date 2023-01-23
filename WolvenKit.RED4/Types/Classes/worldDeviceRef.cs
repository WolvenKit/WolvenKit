using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDeviceRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldDeviceRef()
		{
			ComponentName = "controller";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
