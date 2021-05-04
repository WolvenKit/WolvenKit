using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceNode : worldEntityNode
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

		public worldDeviceNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
