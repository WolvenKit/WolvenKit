using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownListController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _listContainer;
		private wCHandle<IScriptable> _ownerController;
		private wCHandle<DropdownButtonController> _triggerButton;
		private CEnum<DropdownDisplayContext> _displayContext;
		private CHandle<DropdownElementController> _activeElement;
		private CBool _listOpened;
		private CArray<CHandle<DropdownItemData>> _data;

		[Ordinal(1)] 
		[RED("listContainer")] 
		public inkCompoundWidgetReference ListContainer
		{
			get
			{
				if (_listContainer == null)
				{
					_listContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "listContainer", cr2w, this);
				}
				return _listContainer;
			}
			set
			{
				if (_listContainer == value)
				{
					return;
				}
				_listContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ownerController")] 
		public wCHandle<IScriptable> OwnerController
		{
			get
			{
				if (_ownerController == null)
				{
					_ownerController = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "ownerController", cr2w, this);
				}
				return _ownerController;
			}
			set
			{
				if (_ownerController == value)
				{
					return;
				}
				_ownerController = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("triggerButton")] 
		public wCHandle<DropdownButtonController> TriggerButton
		{
			get
			{
				if (_triggerButton == null)
				{
					_triggerButton = (wCHandle<DropdownButtonController>) CR2WTypeManager.Create("whandle:DropdownButtonController", "triggerButton", cr2w, this);
				}
				return _triggerButton;
			}
			set
			{
				if (_triggerButton == value)
				{
					return;
				}
				_triggerButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("displayContext")] 
		public CEnum<DropdownDisplayContext> DisplayContext
		{
			get
			{
				if (_displayContext == null)
				{
					_displayContext = (CEnum<DropdownDisplayContext>) CR2WTypeManager.Create("DropdownDisplayContext", "displayContext", cr2w, this);
				}
				return _displayContext;
			}
			set
			{
				if (_displayContext == value)
				{
					return;
				}
				_displayContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("activeElement")] 
		public CHandle<DropdownElementController> ActiveElement
		{
			get
			{
				if (_activeElement == null)
				{
					_activeElement = (CHandle<DropdownElementController>) CR2WTypeManager.Create("handle:DropdownElementController", "activeElement", cr2w, this);
				}
				return _activeElement;
			}
			set
			{
				if (_activeElement == value)
				{
					return;
				}
				_activeElement = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("listOpened")] 
		public CBool ListOpened
		{
			get
			{
				if (_listOpened == null)
				{
					_listOpened = (CBool) CR2WTypeManager.Create("Bool", "listOpened", cr2w, this);
				}
				return _listOpened;
			}
			set
			{
				if (_listOpened == value)
				{
					return;
				}
				_listOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CArray<CHandle<DropdownItemData>> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CHandle<DropdownItemData>>) CR2WTypeManager.Create("array:handle:DropdownItemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public DropdownListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
