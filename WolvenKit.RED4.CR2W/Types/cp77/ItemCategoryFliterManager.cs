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
		private CArray<CEnum<ItemFilterCategory>> _sharedFiltersToCheck;
		private CBool _isOrderDirty;

		[Ordinal(0)] 
		[RED("filtersToCheck")] 
		public CArray<CEnum<ItemFilterCategory>> FiltersToCheck
		{
			get => GetProperty(ref _filtersToCheck);
			set => SetProperty(ref _filtersToCheck, value);
		}

		[Ordinal(1)] 
		[RED("filters")] 
		public CArray<CEnum<ItemFilterCategory>> Filters
		{
			get => GetProperty(ref _filters);
			set => SetProperty(ref _filters, value);
		}

		[Ordinal(2)] 
		[RED("sharedFiltersToCheck")] 
		public CArray<CEnum<ItemFilterCategory>> SharedFiltersToCheck
		{
			get => GetProperty(ref _sharedFiltersToCheck);
			set => SetProperty(ref _sharedFiltersToCheck, value);
		}

		[Ordinal(3)] 
		[RED("isOrderDirty")] 
		public CBool IsOrderDirty
		{
			get => GetProperty(ref _isOrderDirty);
			set => SetProperty(ref _isOrderDirty, value);
		}

		public ItemCategoryFliterManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
