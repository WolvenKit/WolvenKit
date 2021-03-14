using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityList : inkWidgetLogicController
	{
		private CName _libraryItemName;
		private inkCompoundWidgetReference _container;
		private CArray<wCHandle<inkWidget>> _itemsList;
		private CArray<gameInventoryItemAbility> _data;
		private CName _qualityName;

		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get
			{
				if (_libraryItemName == null)
				{
					_libraryItemName = (CName) CR2WTypeManager.Create("CName", "libraryItemName", cr2w, this);
				}
				return _libraryItemName;
			}
			set
			{
				if (_libraryItemName == value)
				{
					return;
				}
				_libraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemsList")] 
		public CArray<wCHandle<inkWidget>> ItemsList
		{
			get
			{
				if (_itemsList == null)
				{
					_itemsList = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "itemsList", cr2w, this);
				}
				return _itemsList;
			}
			set
			{
				if (_itemsList == value)
				{
					return;
				}
				_itemsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CArray<gameInventoryItemAbility> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<gameInventoryItemAbility>) CR2WTypeManager.Create("array:gameInventoryItemAbility", "data", cr2w, this);
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

		[Ordinal(5)] 
		[RED("qualityName")] 
		public CName QualityName
		{
			get
			{
				if (_qualityName == null)
				{
					_qualityName = (CName) CR2WTypeManager.Create("CName", "qualityName", cr2w, this);
				}
				return _qualityName;
			}
			set
			{
				if (_qualityName == value)
				{
					return;
				}
				_qualityName = value;
				PropertySet(this);
			}
		}

		public TooltipSpecialAbilityList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
