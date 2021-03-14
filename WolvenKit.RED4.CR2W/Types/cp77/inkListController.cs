using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkListController : inkWidgetLogicController
	{
		private CName _itemLibraryID;
		private CBool _cycledNavigation;
		private CBool _beginToggled;
		private inkListControllerCallback _itemSelected;
		private inkListControllerCallback _itemActivated;

		[Ordinal(1)] 
		[RED("itemLibraryID")] 
		public CName ItemLibraryID
		{
			get
			{
				if (_itemLibraryID == null)
				{
					_itemLibraryID = (CName) CR2WTypeManager.Create("CName", "itemLibraryID", cr2w, this);
				}
				return _itemLibraryID;
			}
			set
			{
				if (_itemLibraryID == value)
				{
					return;
				}
				_itemLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get
			{
				if (_cycledNavigation == null)
				{
					_cycledNavigation = (CBool) CR2WTypeManager.Create("Bool", "cycledNavigation", cr2w, this);
				}
				return _cycledNavigation;
			}
			set
			{
				if (_cycledNavigation == value)
				{
					return;
				}
				_cycledNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("beginToggled")] 
		public CBool BeginToggled
		{
			get
			{
				if (_beginToggled == null)
				{
					_beginToggled = (CBool) CR2WTypeManager.Create("Bool", "beginToggled", cr2w, this);
				}
				return _beginToggled;
			}
			set
			{
				if (_beginToggled == value)
				{
					return;
				}
				_beginToggled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkListControllerCallback ItemSelected
		{
			get
			{
				if (_itemSelected == null)
				{
					_itemSelected = (inkListControllerCallback) CR2WTypeManager.Create("inkListControllerCallback", "ItemSelected", cr2w, this);
				}
				return _itemSelected;
			}
			set
			{
				if (_itemSelected == value)
				{
					return;
				}
				_itemSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkListControllerCallback ItemActivated
		{
			get
			{
				if (_itemActivated == null)
				{
					_itemActivated = (inkListControllerCallback) CR2WTypeManager.Create("inkListControllerCallback", "ItemActivated", cr2w, this);
				}
				return _itemActivated;
			}
			set
			{
				if (_itemActivated == value)
				{
					return;
				}
				_itemActivated = value;
				PropertySet(this);
			}
		}

		public inkListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
