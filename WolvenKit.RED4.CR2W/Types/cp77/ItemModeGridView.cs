using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridView : inkScriptableDataViewWrapper
	{
		private CEnum<ItemFilterCategory> _itemFilterType;
		private CEnum<ItemSortMode> _itemSortMode;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(0)] 
		[RED("itemFilterType")] 
		public CEnum<ItemFilterCategory> ItemFilterType
		{
			get => GetProperty(ref _itemFilterType);
			set => SetProperty(ref _itemFilterType, value);
		}

		[Ordinal(1)] 
		[RED("itemSortMode")] 
		public CEnum<ItemSortMode> ItemSortMode
		{
			get => GetProperty(ref _itemSortMode);
			set => SetProperty(ref _itemSortMode, value);
		}

		[Ordinal(2)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		public ItemModeGridView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
