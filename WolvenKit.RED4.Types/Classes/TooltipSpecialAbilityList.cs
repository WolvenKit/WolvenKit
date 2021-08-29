using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipSpecialAbilityList : inkWidgetLogicController
	{
		private CName _libraryItemName;
		private inkCompoundWidgetReference _container;
		private CArray<CWeakHandle<inkWidget>> _itemsList;
		private CArray<gameInventoryItemAbility> _data;
		private CName _qualityName;

		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetProperty(ref _libraryItemName);
			set => SetProperty(ref _libraryItemName, value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(3)] 
		[RED("itemsList")] 
		public CArray<CWeakHandle<inkWidget>> ItemsList
		{
			get => GetProperty(ref _itemsList);
			set => SetProperty(ref _itemsList, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CArray<gameInventoryItemAbility> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("qualityName")] 
		public CName QualityName
		{
			get => GetProperty(ref _qualityName);
			set => SetProperty(ref _qualityName, value);
		}
	}
}
