using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialogChoiceLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _inputViewRef;
		private inkWidgetReference _verticalLineWidget;
		private inkTextWidgetReference _activeTextRef;
		private inkTextWidgetReference _inActiveTextRef;
		private inkWidgetReference _inActiveTextRootRef;
		private inkWidgetReference _textFlexRef;
		private inkWidgetReference _selectedBgRef;
		private inkWidgetReference _selectedBgRefJohnny;
		private inkCompoundWidgetReference _captionHolder;
		private inkCompoundWidgetReference _secondaryCaptionHolder;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private CFloat _animationTime;
		private CFloat _animationSpeed;
		private CBool _useConstantSpeed;
		private inkWidgetReference _phoneIcon;
		private wCHandle<inkWidget> _textFlex;
		private wCHandle<inkWidget> _inActiveTextRoot;
		private wCHandle<inkWidget> _selectedBg;
		private wCHandle<inkWidget> _selectedBgJohnny;
		private wCHandle<InteractionsInputView> _inputView;
		private CArray<wCHandle<CaptionImageIconsLogicController>> _captionControllers;
		private CArray<wCHandle<CaptionImageIconsLogicController>> _secondaryCaptionControllers;
		private gameinteractionsChoiceTypeWrapper _type;
		private CBool _isSelected;
		private CBool _prevIsSelected;
		private CBool _hasDedicatedInput;
		private CBool _overriddenInput;
		private CBool _isPreserveSelectionFadeOut;
		private CBool _isPhoneLockActive;
		private CName _dedicatedInputName;
		private CName _active;
		private CName _inactive;
		private CName _black;
		private CName _questColor;
		private CName _possessedDialog;
		private CInt32 _controllerPromptLimit;
		private CFloat _fadingOptionEndTransparency;
		private CHandle<inkanimProxy> _animSelectedBgProxy;
		private CHandle<inkanimProxy> _animSelectedJohnnyBgProxy;
		private CHandle<inkanimProxy> _animActiveTextProxy;
		private CHandle<inkanimProxy> _animfFadingOutProxy;
		private CHandle<inkanimProxy> _animIntroProxy;

		[Ordinal(1)] 
		[RED("InputViewRef")] 
		public inkWidgetReference InputViewRef
		{
			get
			{
				if (_inputViewRef == null)
				{
					_inputViewRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "InputViewRef", cr2w, this);
				}
				return _inputViewRef;
			}
			set
			{
				if (_inputViewRef == value)
				{
					return;
				}
				_inputViewRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("VerticalLineWidget")] 
		public inkWidgetReference VerticalLineWidget
		{
			get
			{
				if (_verticalLineWidget == null)
				{
					_verticalLineWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "VerticalLineWidget", cr2w, this);
				}
				return _verticalLineWidget;
			}
			set
			{
				if (_verticalLineWidget == value)
				{
					return;
				}
				_verticalLineWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ActiveTextRef")] 
		public inkTextWidgetReference ActiveTextRef
		{
			get
			{
				if (_activeTextRef == null)
				{
					_activeTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ActiveTextRef", cr2w, this);
				}
				return _activeTextRef;
			}
			set
			{
				if (_activeTextRef == value)
				{
					return;
				}
				_activeTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("InActiveTextRef")] 
		public inkTextWidgetReference InActiveTextRef
		{
			get
			{
				if (_inActiveTextRef == null)
				{
					_inActiveTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "InActiveTextRef", cr2w, this);
				}
				return _inActiveTextRef;
			}
			set
			{
				if (_inActiveTextRef == value)
				{
					return;
				}
				_inActiveTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("InActiveTextRootRef")] 
		public inkWidgetReference InActiveTextRootRef
		{
			get
			{
				if (_inActiveTextRootRef == null)
				{
					_inActiveTextRootRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "InActiveTextRootRef", cr2w, this);
				}
				return _inActiveTextRootRef;
			}
			set
			{
				if (_inActiveTextRootRef == value)
				{
					return;
				}
				_inActiveTextRootRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("TextFlexRef")] 
		public inkWidgetReference TextFlexRef
		{
			get
			{
				if (_textFlexRef == null)
				{
					_textFlexRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TextFlexRef", cr2w, this);
				}
				return _textFlexRef;
			}
			set
			{
				if (_textFlexRef == value)
				{
					return;
				}
				_textFlexRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("SelectedBgRef")] 
		public inkWidgetReference SelectedBgRef
		{
			get
			{
				if (_selectedBgRef == null)
				{
					_selectedBgRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SelectedBgRef", cr2w, this);
				}
				return _selectedBgRef;
			}
			set
			{
				if (_selectedBgRef == value)
				{
					return;
				}
				_selectedBgRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("SelectedBgRefJohnny")] 
		public inkWidgetReference SelectedBgRefJohnny
		{
			get
			{
				if (_selectedBgRefJohnny == null)
				{
					_selectedBgRefJohnny = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SelectedBgRefJohnny", cr2w, this);
				}
				return _selectedBgRefJohnny;
			}
			set
			{
				if (_selectedBgRefJohnny == value)
				{
					return;
				}
				_selectedBgRefJohnny = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("CaptionHolder")] 
		public inkCompoundWidgetReference CaptionHolder
		{
			get
			{
				if (_captionHolder == null)
				{
					_captionHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CaptionHolder", cr2w, this);
				}
				return _captionHolder;
			}
			set
			{
				if (_captionHolder == value)
				{
					return;
				}
				_captionHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("SecondaryCaptionHolder")] 
		public inkCompoundWidgetReference SecondaryCaptionHolder
		{
			get
			{
				if (_secondaryCaptionHolder == null)
				{
					_secondaryCaptionHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "SecondaryCaptionHolder", cr2w, this);
				}
				return _secondaryCaptionHolder;
			}
			set
			{
				if (_secondaryCaptionHolder == value)
				{
					return;
				}
				_secondaryCaptionHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "RootWidget", cr2w, this);
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

		[Ordinal(12)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get
			{
				if (_animationTime == null)
				{
					_animationTime = (CFloat) CR2WTypeManager.Create("Float", "AnimationTime", cr2w, this);
				}
				return _animationTime;
			}
			set
			{
				if (_animationTime == value)
				{
					return;
				}
				_animationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("AnimationSpeed")] 
		public CFloat AnimationSpeed
		{
			get
			{
				if (_animationSpeed == null)
				{
					_animationSpeed = (CFloat) CR2WTypeManager.Create("Float", "AnimationSpeed", cr2w, this);
				}
				return _animationSpeed;
			}
			set
			{
				if (_animationSpeed == value)
				{
					return;
				}
				_animationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("UseConstantSpeed")] 
		public CBool UseConstantSpeed
		{
			get
			{
				if (_useConstantSpeed == null)
				{
					_useConstantSpeed = (CBool) CR2WTypeManager.Create("Bool", "UseConstantSpeed", cr2w, this);
				}
				return _useConstantSpeed;
			}
			set
			{
				if (_useConstantSpeed == value)
				{
					return;
				}
				_useConstantSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("phoneIcon")] 
		public inkWidgetReference PhoneIcon
		{
			get
			{
				if (_phoneIcon == null)
				{
					_phoneIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "phoneIcon", cr2w, this);
				}
				return _phoneIcon;
			}
			set
			{
				if (_phoneIcon == value)
				{
					return;
				}
				_phoneIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("TextFlex")] 
		public wCHandle<inkWidget> TextFlex
		{
			get
			{
				if (_textFlex == null)
				{
					_textFlex = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "TextFlex", cr2w, this);
				}
				return _textFlex;
			}
			set
			{
				if (_textFlex == value)
				{
					return;
				}
				_textFlex = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("InActiveTextRoot")] 
		public wCHandle<inkWidget> InActiveTextRoot
		{
			get
			{
				if (_inActiveTextRoot == null)
				{
					_inActiveTextRoot = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "InActiveTextRoot", cr2w, this);
				}
				return _inActiveTextRoot;
			}
			set
			{
				if (_inActiveTextRoot == value)
				{
					return;
				}
				_inActiveTextRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("SelectedBg")] 
		public wCHandle<inkWidget> SelectedBg
		{
			get
			{
				if (_selectedBg == null)
				{
					_selectedBg = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "SelectedBg", cr2w, this);
				}
				return _selectedBg;
			}
			set
			{
				if (_selectedBg == value)
				{
					return;
				}
				_selectedBg = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("SelectedBgJohnny")] 
		public wCHandle<inkWidget> SelectedBgJohnny
		{
			get
			{
				if (_selectedBgJohnny == null)
				{
					_selectedBgJohnny = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "SelectedBgJohnny", cr2w, this);
				}
				return _selectedBgJohnny;
			}
			set
			{
				if (_selectedBgJohnny == value)
				{
					return;
				}
				_selectedBgJohnny = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("InputView")] 
		public wCHandle<InteractionsInputView> InputView
		{
			get
			{
				if (_inputView == null)
				{
					_inputView = (wCHandle<InteractionsInputView>) CR2WTypeManager.Create("whandle:InteractionsInputView", "InputView", cr2w, this);
				}
				return _inputView;
			}
			set
			{
				if (_inputView == value)
				{
					return;
				}
				_inputView = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("CaptionControllers")] 
		public CArray<wCHandle<CaptionImageIconsLogicController>> CaptionControllers
		{
			get
			{
				if (_captionControllers == null)
				{
					_captionControllers = (CArray<wCHandle<CaptionImageIconsLogicController>>) CR2WTypeManager.Create("array:whandle:CaptionImageIconsLogicController", "CaptionControllers", cr2w, this);
				}
				return _captionControllers;
			}
			set
			{
				if (_captionControllers == value)
				{
					return;
				}
				_captionControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("SecondaryCaptionControllers")] 
		public CArray<wCHandle<CaptionImageIconsLogicController>> SecondaryCaptionControllers
		{
			get
			{
				if (_secondaryCaptionControllers == null)
				{
					_secondaryCaptionControllers = (CArray<wCHandle<CaptionImageIconsLogicController>>) CR2WTypeManager.Create("array:whandle:CaptionImageIconsLogicController", "SecondaryCaptionControllers", cr2w, this);
				}
				return _secondaryCaptionControllers;
			}
			set
			{
				if (_secondaryCaptionControllers == value)
				{
					return;
				}
				_secondaryCaptionControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get
			{
				if (_type == null)
				{
					_type = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("prevIsSelected")] 
		public CBool PrevIsSelected
		{
			get
			{
				if (_prevIsSelected == null)
				{
					_prevIsSelected = (CBool) CR2WTypeManager.Create("Bool", "prevIsSelected", cr2w, this);
				}
				return _prevIsSelected;
			}
			set
			{
				if (_prevIsSelected == value)
				{
					return;
				}
				_prevIsSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("hasDedicatedInput")] 
		public CBool HasDedicatedInput
		{
			get
			{
				if (_hasDedicatedInput == null)
				{
					_hasDedicatedInput = (CBool) CR2WTypeManager.Create("Bool", "hasDedicatedInput", cr2w, this);
				}
				return _hasDedicatedInput;
			}
			set
			{
				if (_hasDedicatedInput == value)
				{
					return;
				}
				_hasDedicatedInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("overriddenInput")] 
		public CBool OverriddenInput
		{
			get
			{
				if (_overriddenInput == null)
				{
					_overriddenInput = (CBool) CR2WTypeManager.Create("Bool", "overriddenInput", cr2w, this);
				}
				return _overriddenInput;
			}
			set
			{
				if (_overriddenInput == value)
				{
					return;
				}
				_overriddenInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isPreserveSelectionFadeOut")] 
		public CBool IsPreserveSelectionFadeOut
		{
			get
			{
				if (_isPreserveSelectionFadeOut == null)
				{
					_isPreserveSelectionFadeOut = (CBool) CR2WTypeManager.Create("Bool", "isPreserveSelectionFadeOut", cr2w, this);
				}
				return _isPreserveSelectionFadeOut;
			}
			set
			{
				if (_isPreserveSelectionFadeOut == value)
				{
					return;
				}
				_isPreserveSelectionFadeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get
			{
				if (_isPhoneLockActive == null)
				{
					_isPhoneLockActive = (CBool) CR2WTypeManager.Create("Bool", "isPhoneLockActive", cr2w, this);
				}
				return _isPhoneLockActive;
			}
			set
			{
				if (_isPhoneLockActive == value)
				{
					return;
				}
				_isPhoneLockActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("dedicatedInputName")] 
		public CName DedicatedInputName
		{
			get
			{
				if (_dedicatedInputName == null)
				{
					_dedicatedInputName = (CName) CR2WTypeManager.Create("CName", "dedicatedInputName", cr2w, this);
				}
				return _dedicatedInputName;
			}
			set
			{
				if (_dedicatedInputName == value)
				{
					return;
				}
				_dedicatedInputName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("Active")] 
		public CName Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CName) CR2WTypeManager.Create("CName", "Active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("Inactive")] 
		public CName Inactive
		{
			get
			{
				if (_inactive == null)
				{
					_inactive = (CName) CR2WTypeManager.Create("CName", "Inactive", cr2w, this);
				}
				return _inactive;
			}
			set
			{
				if (_inactive == value)
				{
					return;
				}
				_inactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("Black")] 
		public CName Black
		{
			get
			{
				if (_black == null)
				{
					_black = (CName) CR2WTypeManager.Create("CName", "Black", cr2w, this);
				}
				return _black;
			}
			set
			{
				if (_black == value)
				{
					return;
				}
				_black = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("questColor")] 
		public CName QuestColor
		{
			get
			{
				if (_questColor == null)
				{
					_questColor = (CName) CR2WTypeManager.Create("CName", "questColor", cr2w, this);
				}
				return _questColor;
			}
			set
			{
				if (_questColor == value)
				{
					return;
				}
				_questColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("possessedDialog")] 
		public CName PossessedDialog
		{
			get
			{
				if (_possessedDialog == null)
				{
					_possessedDialog = (CName) CR2WTypeManager.Create("CName", "possessedDialog", cr2w, this);
				}
				return _possessedDialog;
			}
			set
			{
				if (_possessedDialog == value)
				{
					return;
				}
				_possessedDialog = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("ControllerPromptLimit")] 
		public CInt32 ControllerPromptLimit
		{
			get
			{
				if (_controllerPromptLimit == null)
				{
					_controllerPromptLimit = (CInt32) CR2WTypeManager.Create("Int32", "ControllerPromptLimit", cr2w, this);
				}
				return _controllerPromptLimit;
			}
			set
			{
				if (_controllerPromptLimit == value)
				{
					return;
				}
				_controllerPromptLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("fadingOptionEndTransparency")] 
		public CFloat FadingOptionEndTransparency
		{
			get
			{
				if (_fadingOptionEndTransparency == null)
				{
					_fadingOptionEndTransparency = (CFloat) CR2WTypeManager.Create("Float", "fadingOptionEndTransparency", cr2w, this);
				}
				return _fadingOptionEndTransparency;
			}
			set
			{
				if (_fadingOptionEndTransparency == value)
				{
					return;
				}
				_fadingOptionEndTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("animSelectedBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedBgProxy
		{
			get
			{
				if (_animSelectedBgProxy == null)
				{
					_animSelectedBgProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectedBgProxy", cr2w, this);
				}
				return _animSelectedBgProxy;
			}
			set
			{
				if (_animSelectedBgProxy == value)
				{
					return;
				}
				_animSelectedBgProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("animSelectedJohnnyBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedJohnnyBgProxy
		{
			get
			{
				if (_animSelectedJohnnyBgProxy == null)
				{
					_animSelectedJohnnyBgProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectedJohnnyBgProxy", cr2w, this);
				}
				return _animSelectedJohnnyBgProxy;
			}
			set
			{
				if (_animSelectedJohnnyBgProxy == value)
				{
					return;
				}
				_animSelectedJohnnyBgProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("animActiveTextProxy")] 
		public CHandle<inkanimProxy> AnimActiveTextProxy
		{
			get
			{
				if (_animActiveTextProxy == null)
				{
					_animActiveTextProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animActiveTextProxy", cr2w, this);
				}
				return _animActiveTextProxy;
			}
			set
			{
				if (_animActiveTextProxy == value)
				{
					return;
				}
				_animActiveTextProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
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

		[Ordinal(42)] 
		[RED("animIntroProxy")] 
		public CHandle<inkanimProxy> AnimIntroProxy
		{
			get
			{
				if (_animIntroProxy == null)
				{
					_animIntroProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animIntroProxy", cr2w, this);
				}
				return _animIntroProxy;
			}
			set
			{
				if (_animIntroProxy == value)
				{
					return;
				}
				_animIntroProxy = value;
				PropertySet(this);
			}
		}

		public DialogChoiceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
