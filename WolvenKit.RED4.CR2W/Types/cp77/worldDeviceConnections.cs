using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceConnections : CVariable
	{
		private CName _deviceClassName;
		private CArray<NodeRef> _nodeRefs;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("nodeRefs")] 
		public CArray<NodeRef> NodeRefs
		{
			get
			{
				if (_nodeRefs == null)
				{
					_nodeRefs = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "nodeRefs", cr2w, this);
				}
				return _nodeRefs;
			}
			set
			{
				if (_nodeRefs == value)
				{
					return;
				}
				_nodeRefs = value;
				PropertySet(this);
			}
		}

		public worldDeviceConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
