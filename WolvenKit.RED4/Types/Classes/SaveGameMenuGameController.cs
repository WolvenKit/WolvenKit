using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveGameMenuGameController : gameuiSaveHandlingController
	{
		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("gogContainer")] 
		public inkWidgetReference GogContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("scrollbar")] 
		public inkWidgetReference Scrollbar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(9)] 
		[RED("handler")] 
		public CWeakHandle<inkISystemRequestsHandler> Handler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(11)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(12)] 
		[RED("saves")] 
		public CArray<CString> Saves
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(13)] 
		[RED("pendingRegistration")] 
		public CBool PendingRegistration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("hasEmptySlot")] 
		public CBool HasEmptySlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("saveInProgress")] 
		public CBool SaveInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("saveFilesReady")] 
		public CBool SaveFilesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("cloudSynced")] 
		public CBool CloudSynced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("emptySlotController")] 
		public CWeakHandle<LoadListItem> EmptySlotController
		{
			get => GetPropertyValue<CWeakHandle<LoadListItem>>();
			set => SetPropertyValue<CWeakHandle<LoadListItem>>(value);
		}

		[Ordinal(20)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SaveGameMenuGameController()
		{
			List = new inkCompoundWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			GogButtonWidgetRef = new inkWidgetReference();
			GogContainer = new inkWidgetReference();
			Scrollbar = new inkWidgetReference();
			Saves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
