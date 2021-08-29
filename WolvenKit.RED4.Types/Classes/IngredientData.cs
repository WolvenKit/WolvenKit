using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IngredientData : RedBaseClass
	{
		private CString _label;
		private CInt32 _quantity;
		private CInt32 _baseQuantity;
		private CInt32 _itemAmount;
		private CInt32 _inventoryQuantity;
		private CHandle<gamedataItem_Record> _id;
		private CString _icon;
		private CEnum<gameItemIconGender> _iconGender;
		private CBool _playerSelectableIngredient;
		private CBool _buyableIngredient;
		private CBool _hasEnoughQuantity;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("baseQuantity")] 
		public CInt32 BaseQuantity
		{
			get => GetProperty(ref _baseQuantity);
			set => SetProperty(ref _baseQuantity, value);
		}

		[Ordinal(3)] 
		[RED("itemAmount")] 
		public CInt32 ItemAmount
		{
			get => GetProperty(ref _itemAmount);
			set => SetProperty(ref _itemAmount, value);
		}

		[Ordinal(4)] 
		[RED("inventoryQuantity")] 
		public CInt32 InventoryQuantity
		{
			get => GetProperty(ref _inventoryQuantity);
			set => SetProperty(ref _inventoryQuantity, value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(6)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(7)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetProperty(ref _iconGender);
			set => SetProperty(ref _iconGender, value);
		}

		[Ordinal(8)] 
		[RED("playerSelectableIngredient")] 
		public CBool PlayerSelectableIngredient
		{
			get => GetProperty(ref _playerSelectableIngredient);
			set => SetProperty(ref _playerSelectableIngredient, value);
		}

		[Ordinal(9)] 
		[RED("buyableIngredient")] 
		public CBool BuyableIngredient
		{
			get => GetProperty(ref _buyableIngredient);
			set => SetProperty(ref _buyableIngredient, value);
		}

		[Ordinal(10)] 
		[RED("hasEnoughQuantity")] 
		public CBool HasEnoughQuantity
		{
			get => GetProperty(ref _hasEnoughQuantity);
			set => SetProperty(ref _hasEnoughQuantity, value);
		}
	}
}
