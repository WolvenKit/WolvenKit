using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisassembleManager : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("listRef")] 
		public inkCompoundWidgetReference ListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("initialPopupDelay")] 
		public CFloat InitialPopupDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("popupList")] 
		public CArray<CWeakHandle<DisassemblePopupLogicController>> PopupList
		{
			get => GetPropertyValue<CArray<CWeakHandle<DisassemblePopupLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DisassemblePopupLogicController>>>(value);
		}

		[Ordinal(6)] 
		[RED("listOfAddedInventoryItems")] 
		public CArray<gameInventoryItemData> ListOfAddedInventoryItems
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(9)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(13)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(14)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(15)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("CraftingBBID")] 
		public CHandle<redCallbackObject> CraftingBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DisassembleManager()
		{
			ListRef = new inkCompoundWidgetReference();
			InitialPopupDelay = 1.000000F;
			PopupList = new();
			ListOfAddedInventoryItems = new();
			AnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
