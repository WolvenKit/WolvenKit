using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceRef : CVariable
	{
		private NodeRef _nodeRef;
		private CName _componentName;
		private CName _deviceClassName;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public worldDeviceRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
