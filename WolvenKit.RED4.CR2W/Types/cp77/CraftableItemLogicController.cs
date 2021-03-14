using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftableItemLogicController : inkVirtualCompoundItemController
	{
		private inkCompoundWidgetReference _normalAppearence;
		private wCHandle<InventoryItemDisplayController> _controller;
		private CBool _isSelected;
		private CName _displayToCreate;

		[Ordinal(15)] 
		[RED("normalAppearence")] 
		public inkCompoundWidgetReference NormalAppearence
		{
			get
			{
				if (_normalAppearence == null)
				{
					_normalAppearence = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "normalAppearence", cr2w, this);
				}
				return _normalAppearence;
			}
			set
			{
				if (_normalAppearence == value)
				{
					return;
				}
				_normalAppearence = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("controller")] 
		public wCHandle<InventoryItemDisplayController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get
			{
				if (_isSelected == null)
				{
					_isSelected = (CBool) CR2WTypeManager.Create("Bool", "isSelected", cr2w, this);
				}
				return _isSelected;
			}
			set
			{
				if (_isSelected == value)
				{
					return;
				}
				_isSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("displayToCreate")] 
		public CName DisplayToCreate
		{
			get
			{
				if (_displayToCreate == null)
				{
					_displayToCreate = (CName) CR2WTypeManager.Create("CName", "displayToCreate", cr2w, this);
				}
				return _displayToCreate;
			}
			set
			{
				if (_displayToCreate == value)
				{
					return;
				}
				_displayToCreate = value;
				PropertySet(this);
			}
		}

		public CraftableItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
