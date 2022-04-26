using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDeviceConnections : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("nodeRefs")] 
		public CArray<NodeRef> NodeRefs
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public worldDeviceConnections()
		{
			NodeRefs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
