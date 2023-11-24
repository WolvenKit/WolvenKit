using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PonrRewardsGameController : BaseModalListPopupGameController
	{
		[Ordinal(15)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(16)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(17)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(18)] 
		[RED("rewardListInventoryItemGrid")] 
		public inkWidgetReference RewardListInventoryItemGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("rewardListInventoryWeaponGrid")] 
		public inkWidgetReference RewardListInventoryWeaponGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("rewardListRipperdocGrid")] 
		public inkWidgetReference RewardListRipperdocGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("rewardListInventoryItemHolder")] 
		public inkWidgetReference RewardListInventoryItemHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("rewardListRipperdocHolder")] 
		public inkWidgetReference RewardListRipperdocHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("okayButton")] 
		public inkWidgetReference OkayButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("endingAchievementArt")] 
		public inkImageWidgetReference EndingAchievementArt
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("pointOfNoReturnBB")] 
		public CWeakHandle<gameIBlackboard> PointOfNoReturnBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("pointOfNoReturnRewardScreenDef")] 
		public CHandle<UI_PointOfNoReturnRewardScreenDef> PointOfNoReturnRewardScreenDef
		{
			get => GetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>();
			set => SetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>(value);
		}

		public PonrRewardsGameController()
		{
			GameInstance = new ScriptGameInstance();
			RewardListInventoryItemGrid = new inkWidgetReference();
			RewardListInventoryWeaponGrid = new inkWidgetReference();
			RewardListRipperdocGrid = new inkWidgetReference();
			RewardListInventoryItemHolder = new inkWidgetReference();
			RewardListRipperdocHolder = new inkWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			OkayButton = new inkWidgetReference();
			EndingAchievementArt = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
