using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemLog : gameuiMenuGameController
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
		[RED("data")] 
		public CHandle<ItemLogUserData> Data
		{
			get => GetPropertyValue<CHandle<ItemLogUserData>>();
			set => SetPropertyValue<CHandle<ItemLogUserData>>(value);
		}

		[Ordinal(10)] 
		[RED("onScreenCount")] 
		public CInt32 OnScreenCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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

		public ItemLog()
		{
			ListRef = new inkCompoundWidgetReference();
			InitialPopupDelay = 1.000000F;
			PopupList = new();
			ListOfAddedInventoryItems = new();
			AnimOptions = new inkanimPlaybackOptions();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
