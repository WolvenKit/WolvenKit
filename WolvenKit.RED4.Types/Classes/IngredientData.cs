using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IngredientData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("baseQuantity")] 
		public CInt32 BaseQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("itemAmount")] 
		public CInt32 ItemAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("inventoryQuantity")] 
		public CInt32 InventoryQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get => GetPropertyValue<CHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(6)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		[Ordinal(8)] 
		[RED("playerSelectableIngredient")] 
		public CBool PlayerSelectableIngredient
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("buyableIngredient")] 
		public CBool BuyableIngredient
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("hasEnoughQuantity")] 
		public CBool HasEnoughQuantity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IngredientData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
