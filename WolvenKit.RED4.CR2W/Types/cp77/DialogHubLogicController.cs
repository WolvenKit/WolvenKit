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
			get
			{
				if (_progressBarHolder == null)
				{
					_progressBarHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarHolder", cr2w, this);
				}
				return _progressBarHolder;
			}
			set
			{
				if (_progressBarHolder == value)
				{
					return;
				}
				_progressBarHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectionSizeProviderRef")] 
		public inkWidgetReference SelectionSizeProviderRef
		{
			get
			{
				if (_selectionSizeProviderRef == null)
				{
					_selectionSizeProviderRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectionSizeProviderRef", cr2w, this);
				}
				return _selectionSizeProviderRef;
			}
			set
			{
				if (_selectionSizeProviderRef == value)
				{
					return;
				}
				_selectionSizeProviderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selectionRoot")] 
		public inkWidgetReference SelectionRoot
		{
			get
			{
				if (_selectionRoot == null)
				{
					_selectionRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectionRoot", cr2w, this);
				}
				return _selectionRoot;
			}
			set
			{
				if (_selectionRoot == value)
				{
					return;
				}
				_selectionRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("moveAnimTime")] 
		public CFloat MoveAnimTime
		{
			get
			{
				if (_moveAnimTime == null)
				{
					_moveAnimTime = (CFloat) CR2WTypeManager.Create("Float", "moveAnimTime", cr2w, this);
				}
				return _moveAnimTime;
			}
			set
			{
				if (_moveAnimTime == value)
				{
					return;
				}
				_moveAnimTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("possessedDialogFluff")] 
		public wCHandle<inkWidget> PossessedDialogFluff
		{
			get
			{
				if (_possessedDialogFluff == null)
				{
					_possessedDialogFluff = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "possessedDialogFluff", cr2w, this);
				}
				return _possessedDialogFluff;
			}
			set
			{
				if (_possessedDialogFluff == value)
				{
					return;
				}
				_possessedDialogFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("titleWidget")] 
		public wCHandle<inkTextWidget> TitleWidget
		{
			get
			{
				if (_titleWidget == null)
				{
					_titleWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "titleWidget", cr2w, this);
				}
				return _titleWidget;
			}
			set
			{
				if (_titleWidget == value)
				{
					return;
				}
				_titleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("titleBorder")] 
		public wCHandle<inkWidget> TitleBorder
		{
			get
			{
				if (_titleBorder == null)
				{
					_titleBorder = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "titleBorder", cr2w, this);
				}
				return _titleBorder;
			}
			set
			{
				if (_titleBorder == value)
				{
					return;
				}
				_titleBorder = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("titleContainer")] 
		public wCHandle<inkCompoundWidget> TitleContainer
		{
			get
			{
				if (_titleContainer == null)
				{
					_titleContainer = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "titleContainer", cr2w, this);
				}
				return _titleContainer;
			}
			set
			{
				if (_titleContainer == value)
				{
					return;
				}
				_titleContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mainVert")] 
		public wCHandle<inkCompoundWidget> MainVert
		{
			get
			{
				if (_mainVert == null)
				{
					_mainVert = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "mainVert", cr2w, this);
				}
				return _mainVert;
			}
			set
			{
				if (_mainVert == value)
				{
					return;
				}
				_mainVert = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get
			{
				if (_isSelected == null)
				{
					_isSelected = (CBool) CR2WTypeManager.Create("Bool", "isSelected", cr2w, this);
				}
				return _isSelected;
			}
			set
			{
				if (_isSelected == value)
				{
					return;
				}
				_isSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("data")] 
		public gameinteractionsvisListChoiceHubData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameinteractionsvisListChoiceHubData) CR2WTypeManager.Create("gameinteractionsvisListChoiceHubData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("itemControllers")] 
		public CArray<CHandle<DialogChoiceLogicController>> ItemControllers
		{
			get
			{
				if (_itemControllers == null)
				{
					_itemControllers = (CArray<CHandle<DialogChoiceLogicController>>) CR2WTypeManager.Create("array:handle:DialogChoiceLogicController", "itemControllers", cr2w, this);
				}
				return _itemControllers;
			}
			set
			{
				if (_itemControllers == value)
				{
					return;
				}
				_itemControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("progressBar")] 
		public CHandle<DialogChoiceTimerController> ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (CHandle<DialogChoiceTimerController>) CR2WTypeManager.Create("handle:DialogChoiceTimerController", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get
			{
				if (_hasProgressBar == null)
				{
					_hasProgressBar = (CBool) CR2WTypeManager.Create("Bool", "hasProgressBar", cr2w, this);
				}
				return _hasProgressBar;
			}
			set
			{
				if (_hasProgressBar == value)
				{
					return;
				}
				_hasProgressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("wasTimmed")] 
		public CBool WasTimmed
		{
			get
			{
				if (_wasTimmed == null)
				{
					_wasTimmed = (CBool) CR2WTypeManager.Create("Bool", "wasTimmed", cr2w, this);
				}
				return _wasTimmed;
			}
			set
			{
				if (_wasTimmed == value)
				{
					return;
				}
				_wasTimmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isClosingDelayed")] 
		public CBool IsClosingDelayed
		{
			get
			{
				if (_isClosingDelayed == null)
				{
					_isClosingDelayed = (CBool) CR2WTypeManager.Create("Bool", "isClosingDelayed", cr2w, this);
				}
				return _isClosingDelayed;
			}
			set
			{
				if (_isClosingDelayed == value)
				{
					return;
				}
				_isClosingDelayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lastSelectedIdx")] 
		public CInt32 LastSelectedIdx
		{
			get
			{
				if (_lastSelectedIdx == null)
				{
					_lastSelectedIdx = (CInt32) CR2WTypeManager.Create("Int32", "lastSelectedIdx", cr2w, this);
				}
				return _lastSelectedIdx;
			}
			set
			{
				if (_lastSelectedIdx == value)
				{
					return;
				}
				_lastSelectedIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get
			{
				if (_inActiveTransparency == null)
				{
					_inActiveTransparency = (CFloat) CR2WTypeManager.Create("Float", "inActiveTransparency", cr2w, this);
				}
				return _inActiveTransparency;
			}
			set
			{
				if (_inActiveTransparency == value)
				{
					return;
				}
				_inActiveTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("animSelectMarginProxy")] 
		public CHandle<inkanimProxy> AnimSelectMarginProxy
		{
			get
			{
				if (_animSelectMarginProxy == null)
				{
					_animSelectMarginProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectMarginProxy", cr2w, this);
				}
				return _animSelectMarginProxy;
			}
			set
			{
				if (_animSelectMarginProxy == value)
				{
					return;
				}
				_animSelectMarginProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("animSelectSizeProxy")] 
		public CHandle<inkanimProxy> AnimSelectSizeProxy
		{
			get
			{
				if (_animSelectSizeProxy == null)
				{
					_animSelectSizeProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectSizeProxy", cr2w, this);
				}
				return _animSelectSizeProxy;
			}
			set
			{
				if (_animSelectSizeProxy == value)
				{
					return;
				}
				_animSelectSizeProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("animSelectMargin")] 
		public CHandle<inkanimDefinition> AnimSelectMargin
		{
			get
			{
				if (_animSelectMargin == null)
				{
					_animSelectMargin = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animSelectMargin", cr2w, this);
				}
				return _animSelectMargin;
			}
			set
			{
				if (_animSelectMargin == value)
				{
					return;
				}
				_animSelectMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("animSelectSize")] 
		public CHandle<inkanimDefinition> AnimSelectSize
		{
			get
			{
				if (_animSelectSize == null)
				{
					_animSelectSize = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animSelectSize", cr2w, this);
				}
				return _animSelectSize;
			}
			set
			{
				if (_animSelectSize == value)
				{
					return;
				}
				_animSelectSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("animfFadingOutProxy")] 
		public CHandle<inkanimProxy> AnimfFadingOutProxy
		{
			get
			{
				if (_animfFadingOutProxy == null)
				{
					_animfFadingOutProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animfFadingOutProxy", cr2w, this);
				}
				return _animfFadingOutProxy;
			}
			set
			{
				if (_animfFadingOutProxy == value)
				{
					return;
				}
				_animfFadingOutProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("selectBgSizeInterp")] 
		public CHandle<inkanimSizeInterpolator> SelectBgSizeInterp
		{
			get
			{
				if (_selectBgSizeInterp == null)
				{
					_selectBgSizeInterp = (CHandle<inkanimSizeInterpolator>) CR2WTypeManager.Create("handle:inkanimSizeInterpolator", "selectBgSizeInterp", cr2w, this);
				}
				return _selectBgSizeInterp;
			}
			set
			{
				if (_selectBgSizeInterp == value)
				{
					return;
				}
				_selectBgSizeInterp = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("selectBgMarginInterp")] 
		public CHandle<inkanimMarginInterpolator> SelectBgMarginInterp
		{
			get
			{
				if (_selectBgMarginInterp == null)
				{
					_selectBgMarginInterp = (CHandle<inkanimMarginInterpolator>) CR2WTypeManager.Create("handle:inkanimMarginInterpolator", "selectBgMarginInterp", cr2w, this);
				}
				return _selectBgMarginInterp;
			}
			set
			{
				if (_selectBgMarginInterp == value)
				{
					return;
				}
				_selectBgMarginInterp = value;
				PropertySet(this);
			}
		}

		public DialogHubLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
