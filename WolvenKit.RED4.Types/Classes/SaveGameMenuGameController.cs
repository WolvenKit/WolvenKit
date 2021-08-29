using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SaveGameMenuGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _buttonHintsManagerRef;
		private CWeakHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CBool _loadComplete;
		private CWeakHandle<inkISystemRequestsHandler> _handler;
		private CHandle<inkSaveMetadataInfo> _saveInfo;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CBool _hasEmptySlot;
		private CBool _saveInProgress;

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(6)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetProperty(ref _loadComplete);
			set => SetProperty(ref _loadComplete, value);
		}

		[Ordinal(7)] 
		[RED("handler")] 
		public CWeakHandle<inkISystemRequestsHandler> Handler
		{
			get => GetProperty(ref _handler);
			set => SetProperty(ref _handler, value);
		}

		[Ordinal(8)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetProperty(ref _saveInfo);
			set => SetProperty(ref _saveInfo, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(10)] 
		[RED("hasEmptySlot")] 
		public CBool HasEmptySlot
		{
			get => GetProperty(ref _hasEmptySlot);
			set => SetProperty(ref _hasEmptySlot, value);
		}

		[Ordinal(11)] 
		[RED("saveInProgress")] 
		public CBool SaveInProgress
		{
			get => GetProperty(ref _saveInProgress);
			set => SetProperty(ref _saveInProgress, value);
		}
	}
}
