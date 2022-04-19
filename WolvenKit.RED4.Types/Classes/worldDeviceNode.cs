using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDeviceNode : worldEntityNode
	{
		[Ordinal(9)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("alphaHackStreamingDistanceOverride")] 
		public CFloat AlphaHackStreamingDistanceOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("deviceConnections")] 
		public CArray<worldDeviceConnections> DeviceConnections
		{
			get => GetPropertyValue<CArray<worldDeviceConnections>>();
			set => SetPropertyValue<CArray<worldDeviceConnections>>(value);
		}

		public worldDeviceNode()
		{
			DeviceConnections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
