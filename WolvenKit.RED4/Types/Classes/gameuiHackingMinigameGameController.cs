using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHackingMinigameGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("symbolsRecordTDBID")] 
		public TweakDBID SymbolsRecordTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("minigameDefaultsTDBID")] 
		public TweakDBID MinigameDefaultsTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("deviceMode")] 
		public CBool DeviceMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isAlternativeVariant")] 
		public CBool IsAlternativeVariant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("helpInputHintRef")] 
		public inkWidgetReference HelpInputHintRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("miniGameRecord")] 
		public CWeakHandle<gamedataMinigame_Def_Record> MiniGameRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataMinigame_Def_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataMinigame_Def_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("isTutorialActive")] 
		public CBool IsTutorialActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("numberAttempts")] 
		public CInt32 NumberAttempts
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(16)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(17)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("bbMinigame")] 
		public CWeakHandle<gameIBlackboard> BbMinigame
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(19)] 
		[RED("bbMinigameStateListener")] 
		public CHandle<redCallbackObject> BbMinigameStateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("bbUiData")] 
		public CWeakHandle<gameIBlackboard> BbUiData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("bbControllerStateListener")] 
		public CHandle<redCallbackObject> BbControllerStateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public gameuiHackingMinigameGameController()
		{
			HelpInputHintRef = new inkWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
