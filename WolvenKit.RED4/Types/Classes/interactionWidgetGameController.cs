using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interactionWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("titleLabel")] 
		public CWeakHandle<inkTextWidget> TitleLabel
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("titleBorder")] 
		public CWeakHandle<inkWidget> TitleBorder
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("optionsList")] 
		public CWeakHandle<inkHorizontalPanelWidget> OptionsList
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("widgetsPool")] 
		public CArray<CWeakHandle<inkWidget>> WidgetsPool
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(14)] 
		[RED("widgetsCallbacks")] 
		public CArray<CHandle<redCallbackObject>> WidgetsCallbacks
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		[Ordinal(15)] 
		[RED("bbInteraction")] 
		public CWeakHandle<gameIBlackboard> BbInteraction
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("bbPlayerStateMachine")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStateMachine
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(17)] 
		[RED("bbInteractionDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionDefinition
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(18)] 
		[RED("updateInteractionId")] 
		public CHandle<redCallbackObject> UpdateInteractionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("contactsActiveListenerId")] 
		public CHandle<redCallbackObject> ContactsActiveListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("areContactsOpen")] 
		public CBool AreContactsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("dataActive")] 
		public CBool DataActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("progressBar")] 
		public CWeakHandle<DialogChoiceTimerController> ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<DialogChoiceTimerController>>();
			set => SetPropertyValue<CWeakHandle<DialogChoiceTimerController>>(value);
		}

		[Ordinal(27)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(29)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(30)] 
		[RED("bbLastAttemptedChoiceCallbackId")] 
		public CHandle<redCallbackObject> BbLastAttemptedChoiceCallbackId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("OnZoneChangeCallback")] 
		public CHandle<redCallbackObject> OnZoneChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(33)] 
		[RED("spawnTokens")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(34)] 
		[RED("currentOptions")] 
		public CArray<gameinteractionsvisInteractionChoiceData> CurrentOptions
		{
			get => GetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>();
			set => SetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>(value);
		}

		public interactionWidgetGameController()
		{
			WidgetsPool = new();
			WidgetsCallbacks = new();
			ProgressBarHolder = new inkWidgetReference();
			SpawnTokens = new();
			CurrentOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
