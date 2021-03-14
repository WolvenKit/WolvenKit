using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEventManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _isObjectPlayer;
		private gameEntityReference _objectRef;
		private CString _managerName;
		private CHandle<IScriptable> _event;
		private CName _pSClassName;
		private CName _componentName;

		[Ordinal(2)] 
		[RED("isObjectPlayer")] 
		public CBool IsObjectPlayer
		{
			get
			{
				if (_isObjectPlayer == null)
				{
					_isObjectPlayer = (CBool) CR2WTypeManager.Create("Bool", "isObjectPlayer", cr2w, this);
				}
				return _isObjectPlayer;
			}
			set
			{
				if (_isObjectPlayer == value)
				{
					return;
				}
				_isObjectPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
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

		[Ordinal(4)] 
		[RED("managerName")] 
		public CString ManagerName
		{
			get
			{
				if (_managerName == null)
				{
					_managerName = (CString) CR2WTypeManager.Create("String", "managerName", cr2w, this);
				}
				return _managerName;
			}
			set
			{
				if (_managerName == value)
				{
					return;
				}
				_managerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("event")] 
		public CHandle<IScriptable> Event
		{
			get
			{
				if (_event == null)
				{
					_event = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("PSClassName")] 
		public CName PSClassName
		{
			get
			{
				if (_pSClassName == null)
				{
					_pSClassName = (CName) CR2WTypeManager.Create("CName", "PSClassName", cr2w, this);
				}
				return _pSClassName;
			}
			set
			{
				if (_pSClassName == value)
				{
					return;
				}
				_pSClassName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		public questEventManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
