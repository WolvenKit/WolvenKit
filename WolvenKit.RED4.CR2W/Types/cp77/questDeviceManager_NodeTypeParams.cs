using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeTypeParams : ISerializable
	{
		private NodeRef _objectRef;
		private CName _slotName;
		private gameEntityReference _entityRef;
		private CName _deviceControllerClass;
		private CName _deviceAction;
		private CArray<questDeviceManager_ActionProperty> _actionProperties;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("deviceControllerClass")] 
		public CName DeviceControllerClass
		{
			get
			{
				if (_deviceControllerClass == null)
				{
					_deviceControllerClass = (CName) CR2WTypeManager.Create("CName", "deviceControllerClass", cr2w, this);
				}
				return _deviceControllerClass;
			}
			set
			{
				if (_deviceControllerClass == value)
				{
					return;
				}
				_deviceControllerClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("deviceAction")] 
		public CName DeviceAction
		{
			get
			{
				if (_deviceAction == null)
				{
					_deviceAction = (CName) CR2WTypeManager.Create("CName", "deviceAction", cr2w, this);
				}
				return _deviceAction;
			}
			set
			{
				if (_deviceAction == value)
				{
					return;
				}
				_deviceAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionProperties")] 
		public CArray<questDeviceManager_ActionProperty> ActionProperties
		{
			get
			{
				if (_actionProperties == null)
				{
					_actionProperties = (CArray<questDeviceManager_ActionProperty>) CR2WTypeManager.Create("array:questDeviceManager_ActionProperty", "actionProperties", cr2w, this);
				}
				return _actionProperties;
			}
			set
			{
				if (_actionProperties == value)
				{
					return;
				}
				_actionProperties = value;
				PropertySet(this);
			}
		}

		public questDeviceManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
