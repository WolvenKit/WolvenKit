using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDeviceNode : worldEntityNode
	{
		private CName _deviceClassName;
		private CFloat _alphaHackStreamingDistanceOverride;
		private CArray<worldDeviceConnections> _deviceConnections;

		[Ordinal(9)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetProperty(ref _deviceClassName);
			set => SetProperty(ref _deviceClassName, value);
		}

		[Ordinal(10)] 
		[RED("alphaHackStreamingDistanceOverride")] 
		public CFloat AlphaHackStreamingDistanceOverride
		{
			get => GetProperty(ref _alphaHackStreamingDistanceOverride);
			set => SetProperty(ref _alphaHackStreamingDistanceOverride, value);
		}

		[Ordinal(11)] 
		[RED("deviceConnections")] 
		public CArray<worldDeviceConnections> DeviceConnections
		{
			get => GetProperty(ref _deviceConnections);
			set => SetProperty(ref _deviceConnections, value);
		}
	}
}
