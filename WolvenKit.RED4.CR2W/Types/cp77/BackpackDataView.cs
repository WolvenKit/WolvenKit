using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackDataView : inkScriptableDataViewWrapper
	{
		private CEnum<ItemSortMode> _itemSortMode;
		private CArray<CEnum<gamedataItemType>> _attachmentsList;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CEnum<ItemFilterCategory> _itemFilterType;

		[Ordinal(0)] 
		[RED("itemSortMode")] 
		public CEnum<ItemSortMode> ItemSortMode
		{
			get => GetProperty(ref _itemSortMode);
			set => SetProperty(ref _itemSortMode, value);
		}

		[Ordinal(1)] 
		[RED("attachmentsList")] 
		public CArray<CEnum<gamedataItemType>> AttachmentsList
		{
			get => GetProperty(ref _attachmentsList);
			set => SetProperty(ref _attachmentsList, value);
		}

		[Ordinal(2)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(3)] 
		[RED("itemFilterType")] 
		public CEnum<ItemFilterCategory> ItemFilterType
		{
			get => GetProperty(ref _itemFilterType);
			set => SetProperty(ref _itemFilterType, value);
		}

		public BackpackDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
