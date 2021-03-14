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
			get
			{
				if (_deviceClassName == null)
				{
					_deviceClassName = (CName) CR2WTypeManager.Create("CName", "deviceClassName", cr2w, this);
				}
				return _deviceClassName;
			}
			set
			{
				if (_deviceClassName == value)
				{
					return;
				}
				_deviceClassName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("alphaHackStreamingDistanceOverride")] 
		public CFloat AlphaHackStreamingDistanceOverride
		{
			get
			{
				if (_alphaHackStreamingDistanceOverride == null)
				{
					_alphaHackStreamingDistanceOverride = (CFloat) CR2WTypeManager.Create("Float", "alphaHackStreamingDistanceOverride", cr2w, this);
				}
				return _alphaHackStreamingDistanceOverride;
			}
			set
			{
				if (_alphaHackStreamingDistanceOverride == value)
				{
					return;
				}
				_alphaHackStreamingDistanceOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("deviceConnections")] 
		public CArray<worldDeviceConnections> DeviceConnections
		{
			get
			{
				if (_deviceConnections == null)
				{
					_deviceConnections = (CArray<worldDeviceConnections>) CR2WTypeManager.Create("array:worldDeviceConnections", "deviceConnections", cr2w, this);
				}
				return _deviceConnections;
			}
			set
			{
				if (_deviceConnections == value)
				{
					return;
				}
				_deviceConnections = value;
				PropertySet(this);
			}
		}

		public worldDeviceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
