using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadGameMenuGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _buttonHintsManagerRef;
		private CName _transitToLoadingAnimName;
		private CName _transitToLoadingSlotAnimName;
		private CFloat _animDelayBetweenSlots;
		private CFloat _animDelayForMainSlot;
		private CBool _enableLoadingTransition;
		private wCHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CBool _loadComplete;
		private CHandle<inkSaveMetadataInfo> _saveInfo;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CInt32 _saveToLoadIndex;
		private CBool _isInputDisabled;

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
		[RED("transitToLoadingAnimName")] 
		public CName TransitToLoadingAnimName
		{
			get => GetProperty(ref _transitToLoadingAnimName);
			set => SetProperty(ref _transitToLoadingAnimName, value);
		}

		[Ordinal(6)] 
		[RED("transitToLoadingSlotAnimName")] 
		public CName TransitToLoadingSlotAnimName
		{
			get => GetProperty(ref _transitToLoadingSlotAnimName);
			set => SetProperty(ref _transitToLoadingSlotAnimName, value);
		}

		[Ordinal(7)] 
		[RED("animDelayBetweenSlots")] 
		public CFloat AnimDelayBetweenSlots
		{
			get => GetProperty(ref _animDelayBetweenSlots);
			set => SetProperty(ref _animDelayBetweenSlots, value);
		}

		[Ordinal(8)] 
		[RED("animDelayForMainSlot")] 
		public CFloat AnimDelayForMainSlot
		{
			get => GetProperty(ref _animDelayForMainSlot);
			set => SetProperty(ref _animDelayForMainSlot, value);
		}

		[Ordinal(9)] 
		[RED("enableLoadingTransition")] 
		public CBool EnableLoadingTransition
		{
			get => GetProperty(ref _enableLoadingTransition);
			set => SetProperty(ref _enableLoadingTransition, value);
		}

		[Ordinal(10)] 
		[RED("eventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(11)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetProperty(ref _loadComplete);
			set => SetProperty(ref _loadComplete, value);
		}

		[Ordinal(12)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetProperty(ref _saveInfo);
			set => SetProperty(ref _saveInfo, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(14)] 
		[RED("saveToLoadIndex")] 
		public CInt32 SaveToLoadIndex
		{
			get => GetProperty(ref _saveToLoadIndex);
			set => SetProperty(ref _saveToLoadIndex, value);
		}

		[Ordinal(15)] 
		[RED("isInputDisabled")] 
		public CBool IsInputDisabled
		{
			get => GetProperty(ref _isInputDisabled);
			set => SetProperty(ref _isInputDisabled, value);
		}

		public LoadGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
