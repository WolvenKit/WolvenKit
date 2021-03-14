using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayInventoryMiniGrid : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _gridList;
		private inkTextWidgetReference _label;
		private CInt32 _gridWidth;
		private CArray<CHandle<InventoryItemDisplayController>> _gridData;

		[Ordinal(1)] 
		[RED("gridList")] 
		public inkCompoundWidgetReference GridList
		{
			get
			{
				if (_gridList == null)
				{
					_gridList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "gridList", cr2w, this);
				}
				return _gridList;
			}
			set
			{
				if (_gridList == value)
				{
					return;
				}
				_gridList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get
			{
				if (_gridWidth == null)
				{
					_gridWidth = (CInt32) CR2WTypeManager.Create("Int32", "gridWidth", cr2w, this);
				}
				return _gridWidth;
			}
			set
			{
				if (_gridWidth == value)
				{
					return;
				}
				_gridWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gridData")] 
		public CArray<CHandle<InventoryItemDisplayController>> GridData
		{
			get
			{
				if (_gridData == null)
				{
					_gridData = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "gridData", cr2w, this);
				}
				return _gridData;
			}
			set
			{
				if (_gridData == value)
				{
					return;
				}
				_gridData = value;
				PropertySet(this);
			}
		}

		public ItemDisplayInventoryMiniGrid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
