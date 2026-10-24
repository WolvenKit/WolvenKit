using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioUpdateModsPopupController : gameuiUpdateModsPopupController
	{
		[Ordinal(3)] 
		[RED("missingModsText")] 
		public inkTextWidgetReference MissingModsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("actionsPossibleText")] 
		public inkTextWidgetReference ActionsPossibleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("removedModText")] 
		public inkTextWidgetReference RemovedModText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("tooManyModsInSaveText")] 
		public inkTextWidgetReference TooManyModsInSaveText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("popupTitleText")] 
		public inkTextWidgetReference PopupTitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("proceedWarningText")] 
		public inkTextWidgetReference ProceedWarningText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("disableButtonRef")] 
		public inkWidgetReference DisableButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("disableButtonTextRef")] 
		public inkTextWidgetReference DisableButtonTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("openModioBrowserRef")] 
		public inkWidgetReference OpenModioBrowserRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("confirmButtonRef")] 
		public inkWidgetReference ConfirmButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("updateModSpawnerMoreThanThreeWidget")] 
		public inkWidgetReference UpdateModSpawnerMoreThanThreeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("SpawnerMoreThanThreeCanvas")] 
		public inkWidgetReference SpawnerMoreThanThreeCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("updateModSpawnerLessThanThreeWidget")] 
		public inkWidgetReference UpdateModSpawnerLessThanThreeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("ModMenuButtonText")] 
		public inkTextWidgetReference ModMenuButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(21)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(22)] 
		[RED("data")] 
		public CHandle<UpdateModsPopupData2> Data
		{
			get => GetPropertyValue<CHandle<UpdateModsPopupData2>>();
			set => SetPropertyValue<CHandle<UpdateModsPopupData2>>(value);
		}

		[Ordinal(23)] 
		[RED("outdatedModsPanelList")] 
		public CArray<CWeakHandle<inkWidget>> OutdatedModsPanelList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(24)] 
		[RED("listOfDisplayedPanels")] 
		public CArray<CWeakHandle<OutdatedModPanel>> ListOfDisplayedPanels
		{
			get => GetPropertyValue<CArray<CWeakHandle<OutdatedModPanel>>>();
			set => SetPropertyValue<CArray<CWeakHandle<OutdatedModPanel>>>(value);
		}

		[Ordinal(25)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("clickedConfirm")] 
		public CBool ClickedConfirm
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("disableButtonController")] 
		public CWeakHandle<inkButtonController> DisableButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(28)] 
		[RED("closeButtonController")] 
		public CWeakHandle<inkButtonController> CloseButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(29)] 
		[RED("confirmButtonController")] 
		public CWeakHandle<inkButtonController> ConfirmButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(30)] 
		[RED("openModioBrowserController")] 
		public CWeakHandle<inkButtonController> OpenModioBrowserController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(31)] 
		[RED("currentlyHoveredWidget")] 
		public CWeakHandle<inkWidget> CurrentlyHoveredWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ModioUpdateModsPopupController()
		{
			MissingModsText = new inkTextWidgetReference();
			ActionsPossibleText = new inkTextWidgetReference();
			RemovedModText = new inkTextWidgetReference();
			TooManyModsInSaveText = new inkTextWidgetReference();
			PopupTitleText = new inkTextWidgetReference();
			ProceedWarningText = new inkTextWidgetReference();
			DisableButtonRef = new inkWidgetReference();
			DisableButtonTextRef = new inkTextWidgetReference();
			OpenModioBrowserRef = new inkWidgetReference();
			ConfirmButtonRef = new inkWidgetReference();
			CloseButtonRef = new inkWidgetReference();
			UpdateModSpawnerMoreThanThreeWidget = new inkWidgetReference();
			SpawnerMoreThanThreeCanvas = new inkWidgetReference();
			UpdateModSpawnerLessThanThreeWidget = new inkWidgetReference();
			IntroAnimationName = "popup_fade_in";
			OutroAnimationName = "popup_fade_out";
			ModMenuButtonText = new inkTextWidgetReference();
			OutdatedModsPanelList = new();
			ListOfDisplayedPanels = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
