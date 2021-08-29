using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IngredientListItemLogicController : inkButtonController
	{
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _inventoryQuantity;
		private inkTextWidgetReference _ingredientQuantity;
		private inkTextWidgetReference _availability;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _emptyIcon;
		private CArray<inkWidgetReference> _availableBgElements;
		private CArray<inkWidgetReference> _unavailableBgElements;
		private inkWidgetReference _buyButton;
		private inkWidgetReference _countWrapper;
		private inkWidgetReference _itemRarity;
		private IngredientData _data;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private CInt32 _itemAmount;

		[Ordinal(10)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(11)] 
		[RED("inventoryQuantity")] 
		public inkTextWidgetReference InventoryQuantity
		{
			get => GetProperty(ref _inventoryQuantity);
			set => SetProperty(ref _inventoryQuantity, value);
		}

		[Ordinal(12)] 
		[RED("ingredientQuantity")] 
		public inkTextWidgetReference IngredientQuantity
		{
			get => GetProperty(ref _ingredientQuantity);
			set => SetProperty(ref _ingredientQuantity, value);
		}

		[Ordinal(13)] 
		[RED("availability")] 
		public inkTextWidgetReference Availability
		{
			get => GetProperty(ref _availability);
			set => SetProperty(ref _availability, value);
		}

		[Ordinal(14)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(15)] 
		[RED("emptyIcon")] 
		public inkImageWidgetReference EmptyIcon
		{
			get => GetProperty(ref _emptyIcon);
			set => SetProperty(ref _emptyIcon, value);
		}

		[Ordinal(16)] 
		[RED("availableBgElements")] 
		public CArray<inkWidgetReference> AvailableBgElements
		{
			get => GetProperty(ref _availableBgElements);
			set => SetProperty(ref _availableBgElements, value);
		}

		[Ordinal(17)] 
		[RED("unavailableBgElements")] 
		public CArray<inkWidgetReference> UnavailableBgElements
		{
			get => GetProperty(ref _unavailableBgElements);
			set => SetProperty(ref _unavailableBgElements, value);
		}

		[Ordinal(18)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetProperty(ref _buyButton);
			set => SetProperty(ref _buyButton, value);
		}

		[Ordinal(19)] 
		[RED("countWrapper")] 
		public inkWidgetReference CountWrapper
		{
			get => GetProperty(ref _countWrapper);
			set => SetProperty(ref _countWrapper, value);
		}

		[Ordinal(20)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetProperty(ref _itemRarity);
			set => SetProperty(ref _itemRarity, value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public IngredientData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(22)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(23)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(24)] 
		[RED("itemAmount")] 
		public CInt32 ItemAmount
		{
			get => GetProperty(ref _itemAmount);
			set => SetProperty(ref _itemAmount, value);
		}
	}
}
