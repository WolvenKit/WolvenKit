using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftableItemLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("normalAppearence")] 
		public inkCompoundWidgetReference NormalAppearence
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("controller")] 
		public CWeakHandle<InventoryItemDisplayController> Controller
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(17)] 
		[RED("itemData")] 
		public CHandle<ItemCraftingData> ItemData
		{
			get => GetPropertyValue<CHandle<ItemCraftingData>>();
			set => SetPropertyValue<CHandle<ItemCraftingData>>(value);
		}

		[Ordinal(18)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetPropertyValue<CHandle<RecipeData>>();
			set => SetPropertyValue<CHandle<RecipeData>>(value);
		}

		[Ordinal(19)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("displayToCreate")] 
		public CName DisplayToCreate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CraftableItemLogicController()
		{
			NormalAppearence = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
