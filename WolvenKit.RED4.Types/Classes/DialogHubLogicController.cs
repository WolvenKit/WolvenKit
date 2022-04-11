using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DialogHubLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("selectionSizeProviderRef")] 
		public inkWidgetReference SelectionSizeProviderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("selectionRoot")] 
		public inkWidgetReference SelectionRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("moveAnimTime")] 
		public CFloat MoveAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("possessedDialogFluff")] 
		public CWeakHandle<inkWidget> PossessedDialogFluff
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("titleWidget")] 
		public CWeakHandle<inkTextWidget> TitleWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("titleBorder")] 
		public CWeakHandle<inkWidget> TitleBorder
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("titleContainer")] 
		public CWeakHandle<inkCompoundWidget> TitleContainer
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("mainVert")] 
		public CWeakHandle<inkCompoundWidget> MainVert
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public gameinteractionsvisListChoiceHubData Data
		{
			get => GetPropertyValue<gameinteractionsvisListChoiceHubData>();
			set => SetPropertyValue<gameinteractionsvisListChoiceHubData>(value);
		}

		[Ordinal(14)] 
		[RED("itemControllers")] 
		public CArray<CWeakHandle<DialogChoiceLogicController>> ItemControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<DialogChoiceLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DialogChoiceLogicController>>>(value);
		}

		[Ordinal(15)] 
		[RED("progressBar")] 
		public CWeakHandle<DialogChoiceTimerController> ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<DialogChoiceTimerController>>();
			set => SetPropertyValue<CWeakHandle<DialogChoiceTimerController>>(value);
		}

		[Ordinal(16)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("wasTimmed")] 
		public CBool WasTimmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isClosingDelayed")] 
		public CBool IsClosingDelayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("lastSelectedIdx")] 
		public CInt32 LastSelectedIdx
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("animSelectMarginProxy")] 
		public CHandle<inkanimProxy> AnimSelectMarginProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("animSelectSizeProxy")] 
		public CHandle<inkanimProxy> AnimSelectSizeProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("animSelectMargin")] 
		public CHandle<inkanimDefinition> AnimSelectMargin
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(24)] 
		[RED("animSelectSize")] 
		public CHandle<inkanimDefinition> AnimSelectSize
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(25)] 
		[RED("animfFadingOutProxy")] 
		public CHandle<inkanimProxy> AnimfFadingOutProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("selectBgSizeInterp")] 
		public CHandle<inkanimSizeInterpolator> SelectBgSizeInterp
		{
			get => GetPropertyValue<CHandle<inkanimSizeInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimSizeInterpolator>>(value);
		}

		[Ordinal(27)] 
		[RED("selectBgMarginInterp")] 
		public CHandle<inkanimMarginInterpolator> SelectBgMarginInterp
		{
			get => GetPropertyValue<CHandle<inkanimMarginInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimMarginInterpolator>>(value);
		}

		[Ordinal(28)] 
		[RED("dialogHubData")] 
		public DialogHubData DialogHubData
		{
			get => GetPropertyValue<DialogHubData>();
			set => SetPropertyValue<DialogHubData>(value);
		}

		[Ordinal(29)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("spawnTokens")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		public DialogHubLogicController()
		{
			ProgressBarHolder = new();
			SelectionSizeProviderRef = new();
			SelectionRoot = new();
			MoveAnimTime = 0.090000F;
			Data = new() { Id = -1, Choices = new() };
			ItemControllers = new();
			InActiveTransparency = 0.100000F;
			DialogHubData = new();
			SpawnTokens = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
