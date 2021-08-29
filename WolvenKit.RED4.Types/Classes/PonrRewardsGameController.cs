using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PonrRewardsGameController : BaseModalListPopupGameController
	{
		private ScriptGameInstance _gameInstance;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkWidgetReference _rewardListInventoryItemGrid;
		private inkWidgetReference _rewardListInventoryWeaponGrid;
		private inkWidgetReference _rewardListRipperdocGrid;
		private inkWidgetReference _rewardListInventoryItemHolder;
		private inkWidgetReference _rewardListRipperdocHolder;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _okayButton;
		private inkImageWidgetReference _endingAchievementArt;
		private CWeakHandle<gameIBlackboard> _pointOfNoReturnBB;
		private CHandle<UI_PointOfNoReturnRewardScreenDef> _pointOfNoReturnRewardScreenDef;

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(14)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(15)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(16)] 
		[RED("rewardListInventoryItemGrid")] 
		public inkWidgetReference RewardListInventoryItemGrid
		{
			get => GetProperty(ref _rewardListInventoryItemGrid);
			set => SetProperty(ref _rewardListInventoryItemGrid, value);
		}

		[Ordinal(17)] 
		[RED("rewardListInventoryWeaponGrid")] 
		public inkWidgetReference RewardListInventoryWeaponGrid
		{
			get => GetProperty(ref _rewardListInventoryWeaponGrid);
			set => SetProperty(ref _rewardListInventoryWeaponGrid, value);
		}

		[Ordinal(18)] 
		[RED("rewardListRipperdocGrid")] 
		public inkWidgetReference RewardListRipperdocGrid
		{
			get => GetProperty(ref _rewardListRipperdocGrid);
			set => SetProperty(ref _rewardListRipperdocGrid, value);
		}

		[Ordinal(19)] 
		[RED("rewardListInventoryItemHolder")] 
		public inkWidgetReference RewardListInventoryItemHolder
		{
			get => GetProperty(ref _rewardListInventoryItemHolder);
			set => SetProperty(ref _rewardListInventoryItemHolder, value);
		}

		[Ordinal(20)] 
		[RED("rewardListRipperdocHolder")] 
		public inkWidgetReference RewardListRipperdocHolder
		{
			get => GetProperty(ref _rewardListRipperdocHolder);
			set => SetProperty(ref _rewardListRipperdocHolder, value);
		}

		[Ordinal(21)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(22)] 
		[RED("okayButton")] 
		public inkWidgetReference OkayButton
		{
			get => GetProperty(ref _okayButton);
			set => SetProperty(ref _okayButton, value);
		}

		[Ordinal(23)] 
		[RED("endingAchievementArt")] 
		public inkImageWidgetReference EndingAchievementArt
		{
			get => GetProperty(ref _endingAchievementArt);
			set => SetProperty(ref _endingAchievementArt, value);
		}

		[Ordinal(24)] 
		[RED("pointOfNoReturnBB")] 
		public CWeakHandle<gameIBlackboard> PointOfNoReturnBB
		{
			get => GetProperty(ref _pointOfNoReturnBB);
			set => SetProperty(ref _pointOfNoReturnBB, value);
		}

		[Ordinal(25)] 
		[RED("pointOfNoReturnRewardScreenDef")] 
		public CHandle<UI_PointOfNoReturnRewardScreenDef> PointOfNoReturnRewardScreenDef
		{
			get => GetProperty(ref _pointOfNoReturnRewardScreenDef);
			set => SetProperty(ref _pointOfNoReturnRewardScreenDef, value);
		}
	}
}
