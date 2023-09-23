using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PonrRewardsGameController : BaseModalListPopupGameController
	{
		[Ordinal(14)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(15)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(16)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(17)] 
		[RED("rewardListInventoryItemGrid")] 
		public inkWidgetReference RewardListInventoryItemGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("rewardListInventoryWeaponGrid")] 
		public inkWidgetReference RewardListInventoryWeaponGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("rewardListRipperdocGrid")] 
		public inkWidgetReference RewardListRipperdocGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("rewardListInventoryItemHolder")] 
		public inkWidgetReference RewardListInventoryItemHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("rewardListRipperdocHolder")] 
		public inkWidgetReference RewardListRipperdocHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("okayButton")] 
		public inkWidgetReference OkayButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("endingAchievementArt")] 
		public inkImageWidgetReference EndingAchievementArt
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("pointOfNoReturnBB")] 
		public CWeakHandle<gameIBlackboard> PointOfNoReturnBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("pointOfNoReturnRewardScreenDef")] 
		public CHandle<UI_PointOfNoReturnRewardScreenDef> PointOfNoReturnRewardScreenDef
		{
			get => GetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>();
			set => SetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>(value);
		}

		public PonrRewardsGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
