using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCategoryFliterManager : IScriptable
	{
		private CArray<CEnum<ItemFilterCategory>> _filtersToCheck;
		private CArray<CEnum<ItemFilterCategory>> _filters;
		private CBool _isOrderDirty;

		[Ordinal(0)] 
		[RED("filtersToCheck")] 
		public CArray<CEnum<ItemFilterCategory>> FiltersToCheck
		{
			get
			{
				if (_filtersToCheck == null)
				{
					_filtersToCheck = (CArray<CEnum<ItemFilterCategory>>) CR2WTypeManager.Create("array:ItemFilterCategory", "filtersToCheck", cr2w, this);
				}
				return _filtersToCheck;
			}
			set
			{
				if (_filtersToCheck == value)
				{
					return;
				}
				_filtersToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("filters")] 
		public CArray<CEnum<ItemFilterCategory>> Filters
		{
			get
			{
				if (_filters == null)
				{
					_filters = (CArray<CEnum<ItemFilterCategory>>) CR2WTypeManager.Create("array:ItemFilterCategory", "filters", cr2w, this);
				}
				return _filters;
			}
			set
			{
				if (_filters == value)
				{
					return;
				}
				_filters = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isOrderDirty")] 
		public CBool IsOrderDirty
		{
			get
			{
				if (_isOrderDirty == null)
				{
					_isOrderDirty = (CBool) CR2WTypeManager.Create("Bool", "isOrderDirty", cr2w, this);
				}
				return _isOrderDirty;
			}
			set
			{
				if (_isOrderDirty == value)
				{
					return;
				}
				_isOrderDirty = value;
				PropertySet(this);
			}
		}

		public ItemCategoryFliterManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
