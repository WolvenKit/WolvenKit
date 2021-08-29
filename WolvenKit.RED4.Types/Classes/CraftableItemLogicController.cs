using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftableItemLogicController : inkVirtualCompoundItemController
	{
		private inkCompoundWidgetReference _normalAppearence;
		private CWeakHandle<InventoryItemDisplayController> _controller;
		private CHandle<ItemCraftingData> _itemData;
		private CHandle<RecipeData> _recipeData;
		private CBool _isSpawnInProgress;
		private CName _displayToCreate;

		[Ordinal(15)] 
		[RED("normalAppearence")] 
		public inkCompoundWidgetReference NormalAppearence
		{
			get => GetProperty(ref _normalAppearence);
			set => SetProperty(ref _normalAppearence, value);
		}

		[Ordinal(16)] 
		[RED("controller")] 
		public CWeakHandle<InventoryItemDisplayController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(17)] 
		[RED("itemData")] 
		public CHandle<ItemCraftingData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(18)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetProperty(ref _recipeData);
			set => SetProperty(ref _recipeData, value);
		}

		[Ordinal(19)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetProperty(ref _isSpawnInProgress);
			set => SetProperty(ref _isSpawnInProgress, value);
		}

		[Ordinal(20)] 
		[RED("displayToCreate")] 
		public CName DisplayToCreate
		{
			get => GetProperty(ref _displayToCreate);
			set => SetProperty(ref _displayToCreate, value);
		}
	}
}
