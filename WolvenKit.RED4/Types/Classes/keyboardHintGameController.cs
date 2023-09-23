using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class keyboardHintGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("TopElementName")] 
		public CName TopElementName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("BottomElementName")] 
		public CName BottomElementName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("Layout")] 
		public inkBasePanelWidgetReference Layout
		{
			get => GetPropertyValue<inkBasePanelWidgetReference>();
			set => SetPropertyValue<inkBasePanelWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("UIItems")] 
		public CArray<CWeakHandle<KeyboardHintItemController>> UIItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<KeyboardHintItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<KeyboardHintItemController>>>(value);
		}

		[Ordinal(13)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(14)] 
		[RED("QuickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CWeakHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CWeakHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(15)] 
		[RED("UiQuickItemsBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("KeyboardCommandBBID")] 
		public CHandle<redCallbackObject> KeyboardCommandBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public keyboardHintGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
