using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IngredientListItemLogicController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("inventoryQuantity")] 
		public inkTextWidgetReference InventoryQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("ingredientQuantity")] 
		public inkTextWidgetReference IngredientQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("availability")] 
		public inkTextWidgetReference Availability
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("emptyIcon")] 
		public inkImageWidgetReference EmptyIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("availableBgElements")] 
		public CArray<inkWidgetReference> AvailableBgElements
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(17)] 
		[RED("unavailableBgElements")] 
		public CArray<inkWidgetReference> UnavailableBgElements
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("countWrapper")] 
		public inkWidgetReference CountWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public IngredientData Data
		{
			get => GetPropertyValue<IngredientData>();
			set => SetPropertyValue<IngredientData>(value);
		}

		[Ordinal(22)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(24)] 
		[RED("itemAmount")] 
		public CInt32 ItemAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public IngredientListItemLogicController()
		{
			ItemName = new inkTextWidgetReference();
			InventoryQuantity = new inkTextWidgetReference();
			IngredientQuantity = new inkTextWidgetReference();
			Availability = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			EmptyIcon = new inkImageWidgetReference();
			AvailableBgElements = new();
			UnavailableBgElements = new();
			BuyButton = new inkWidgetReference();
			CountWrapper = new inkWidgetReference();
			ItemRarity = new inkWidgetReference();
			Data = new IngredientData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
