using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialogHubLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _progressBarHolder;
		private inkWidgetReference _selectionSizeProviderRef;
		private inkWidgetReference _selectionRoot;
		private CFloat _moveAnimTime;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _possessedDialogFluff;
		private wCHandle<inkTextWidget> _titleWidget;
		private wCHandle<inkWidget> _titleBorder;
		private wCHandle<inkCompoundWidget> _titleContainer;
		private wCHandle<inkCompoundWidget> _mainVert;
		private CInt32 _id;
		private CBool _isSelected;
		private gameinteractionsvisListChoiceHubData _data;
		private CArray<CHandle<DialogChoiceLogicController>> _itemControllers;
		private CHandle<DialogChoiceTimerController> _progressBar;
		private CBool _hasProgressBar;
		private CBool _wasTimmed;
		private CBool _isClosingDelayed;
		private CInt32 _lastSelectedIdx;
		private CFloat _inActiveTransparency;
		private CHandle<inkanimProxy> _animSelectMarginProxy;
		private CHandle<inkanimProxy> _animSelectSizeProxy;
		private CHandle<inkanimDefinition> _animSelectMargin;
		private CHandle<inkanimDefinition> _animSelectSize;
		private CHandle<inkanimProxy> _animfFadingOutProxy;
		private CHandle<inkanimSizeInterpolator> _selectBgSizeInterp;
		private CHandle<inkanimMarginInterpolator> _selectBgMarginInterp;

		[Ordinal(1)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get => GetProperty(ref _progressBarHolder);
			set => SetProperty(ref _progressBarHolder, value);
		}

		[Ordinal(2)] 
		[RED("selectionSizeProviderRef")] 
		public inkWidgetReference SelectionSizeProviderRef
		{
			get => GetProperty(ref _selectionSizeProviderRef);
			set => SetProperty(ref _selectionSizeProviderRef, value);
		}

		[Ordinal(3)] 
		[RED("selectionRoot")] 
		public inkWidgetReference SelectionRoot
		{
			get => GetProperty(ref _selectionRoot);
			set => SetProperty(ref _selectionRoot, value);
		}

		[Ordinal(4)] 
		[RED("moveAnimTime")] 
		public CFloat MoveAnimTime
		{
			get => GetProperty(ref _moveAnimTime);
			set => SetProperty(ref _moveAnimTime, value);
		}

		[Ordinal(5)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(6)] 
		[RED("possessedDialogFluff")] 
		public wCHandle<inkWidget> PossessedDialogFluff
		{
			get => GetProperty(ref _possessedDialogFluff);
			set => SetProperty(ref _possessedDialogFluff, value);
		}

		[Ordinal(7)] 
		[RED("titleWidget")] 
		public wCHandle<inkTextWidget> TitleWidget
		{
			get => GetProperty(ref _titleWidget);
			set => SetProperty(ref _titleWidget, value);
		}

		[Ordinal(8)] 
		[RED("titleBorder")] 
		public wCHandle<inkWidget> TitleBorder
		{
			get => GetProperty(ref _titleBorder);
			set => SetProperty(ref _titleBorder, value);
		}

		[Ordinal(9)] 
		[RED("titleContainer")] 
		public wCHandle<inkCompoundWidget> TitleContainer
		{
			get => GetProperty(ref _titleContainer);
			set => SetProperty(ref _titleContainer, value);
		}

		[Ordinal(10)] 
		[RED("mainVert")] 
		public wCHandle<inkCompoundWidget> MainVert
		{
			get => GetProperty(ref _mainVert);
			set => SetProperty(ref _mainVert, value);
		}

		[Ordinal(11)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(12)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public gameinteractionsvisListChoiceHubData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(14)] 
		[RED("itemControllers")] 
		public CArray<CHandle<DialogChoiceLogicController>> ItemControllers
		{
			get => GetProperty(ref _itemControllers);
			set => SetProperty(ref _itemControllers, value);
		}

		[Ordinal(15)] 
		[RED("progressBar")] 
		public CHandle<DialogChoiceTimerController> ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(16)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get => GetProperty(ref _hasProgressBar);
			set => SetProperty(ref _hasProgressBar, value);
		}

		[Ordinal(17)] 
		[RED("wasTimmed")] 
		public CBool WasTimmed
		{
			get => GetProperty(ref _wasTimmed);
			set => SetProperty(ref _wasTimmed, value);
		}

		[Ordinal(18)] 
		[RED("isClosingDelayed")] 
		public CBool IsClosingDelayed
		{
			get => GetProperty(ref _isClosingDelayed);
			set => SetProperty(ref _isClosingDelayed, value);
		}

		[Ordinal(19)] 
		[RED("lastSelectedIdx")] 
		public CInt32 LastSelectedIdx
		{
			get => GetProperty(ref _lastSelectedIdx);
			set => SetProperty(ref _lastSelectedIdx, value);
		}

		[Ordinal(20)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get => GetProperty(ref _inActiveTransparency);
			set => SetProperty(ref _inActiveTransparency, value);
		}

		[Ordinal(21)] 
		[RED("animSelectMarginProxy")] 
		public CHandle<inkanimProxy> AnimSelectMarginProxy
		{
			get => GetProperty(ref _animSelectMarginProxy);
			set => SetProperty(ref _animSelectMarginProxy, value);
		}

		[Ordinal(22)] 
		[RED("animSelectSizeProxy")] 
		public CHandle<inkanimProxy> AnimSelectSizeProxy
		{
			get => GetProperty(ref _animSelectSizeProxy);
			set => SetProperty(ref _animSelectSizeProxy, value);
		}

		[Ordinal(23)] 
		[RED("animSelectMargin")] 
		public CHandle<inkanimDefinition> AnimSelectMargin
		{
			get => GetProperty(ref _animSelectMargin);
			set => SetProperty(ref _animSelectMargin, value);
		}

		[Ordinal(24)] 
		[RED("animSelectSize")] 
		public CHandle<inkanimDefinition> AnimSelectSize
		{
			get => GetProperty(ref _animSelectSize);
			set => SetProperty(ref _animSelectSize, value);
		}

		[Ordinal(25)] 
		[RED("animfFadingOutProxy")] 
		public CHandle<inkanimProxy> AnimfFadingOutProxy
		{
			get => GetProperty(ref _animfFadingOutProxy);
			set => SetProperty(ref _animfFadingOutProxy, value);
		}

		[Ordinal(26)] 
		[RED("selectBgSizeInterp")] 
		public CHandle<inkanimSizeInterpolator> SelectBgSizeInterp
		{
			get => GetProperty(ref _selectBgSizeInterp);
			set => SetProperty(ref _selectBgSizeInterp, value);
		}

		[Ordinal(27)] 
		[RED("selectBgMarginInterp")] 
		public CHandle<inkanimMarginInterpolator> SelectBgMarginInterp
		{
			get => GetProperty(ref _selectBgMarginInterp);
			set => SetProperty(ref _selectBgMarginInterp, value);
		}

		public DialogHubLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
