using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class dialogWidgetGameController : InteractionUIBase
	{
		[Ordinal(23)] 
		[RED("root")] 
		public CWeakHandle<inkCanvasWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("hubsContainer")] 
		public inkBasePanelWidgetReference HubsContainer
		{
			get => GetPropertyValue<inkBasePanelWidgetReference>();
			set => SetPropertyValue<inkBasePanelWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("hubControllers")] 
		public CArray<CWeakHandle<DialogHubLogicController>> HubControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<DialogHubLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DialogHubLogicController>>>(value);
		}

		[Ordinal(26)] 
		[RED("activeHubController")] 
		public CWeakHandle<DialogHubLogicController> ActiveHubController
		{
			get => GetPropertyValue<CWeakHandle<DialogHubLogicController>>();
			set => SetPropertyValue<CWeakHandle<DialogHubLogicController>>(value);
		}

		[Ordinal(27)] 
		[RED("data")] 
		public gameinteractionsvisDialogChoiceHubs Data
		{
			get => GetPropertyValue<gameinteractionsvisDialogChoiceHubs>();
			set => SetPropertyValue<gameinteractionsvisDialogChoiceHubs>(value);
		}

		[Ordinal(28)] 
		[RED("activeHubID")] 
		public CInt32 ActiveHubID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("prevActiveHubID")] 
		public CInt32 PrevActiveHubID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("fadeAnimTime")] 
		public CFloat FadeAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("fadeDelay")] 
		public CFloat FadeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("dialogFocusInputHintShown")] 
		public CBool DialogFocusInputHintShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("hubAvailable")] 
		public CBool HubAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("animCloseHudProxy")] 
		public CHandle<inkanimProxy> AnimCloseHudProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("currentFadeItem")] 
		public CWeakHandle<DialogHubLogicController> CurrentFadeItem
		{
			get => GetPropertyValue<CWeakHandle<DialogHubLogicController>>();
			set => SetPropertyValue<CWeakHandle<DialogHubLogicController>>(value);
		}

		[Ordinal(37)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(39)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public dialogWidgetGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
