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
			get => GetProperty(ref _inputViewRef);
			set => SetProperty(ref _inputViewRef, value);
		}

		[Ordinal(2)] 
		[RED("VerticalLineWidget")] 
		public inkWidgetReference VerticalLineWidget
		{
			get => GetProperty(ref _verticalLineWidget);
			set => SetProperty(ref _verticalLineWidget, value);
		}

		[Ordinal(3)] 
		[RED("ActiveTextRef")] 
		public inkTextWidgetReference ActiveTextRef
		{
			get => GetProperty(ref _activeTextRef);
			set => SetProperty(ref _activeTextRef, value);
		}

		[Ordinal(4)] 
		[RED("InActiveTextRef")] 
		public inkTextWidgetReference InActiveTextRef
		{
			get => GetProperty(ref _inActiveTextRef);
			set => SetProperty(ref _inActiveTextRef, value);
		}

		[Ordinal(5)] 
		[RED("InActiveTextRootRef")] 
		public inkWidgetReference InActiveTextRootRef
		{
			get => GetProperty(ref _inActiveTextRootRef);
			set => SetProperty(ref _inActiveTextRootRef, value);
		}

		[Ordinal(6)] 
		[RED("TextFlexRef")] 
		public inkWidgetReference TextFlexRef
		{
			get => GetProperty(ref _textFlexRef);
			set => SetProperty(ref _textFlexRef, value);
		}

		[Ordinal(7)] 
		[RED("SelectedBgRef")] 
		public inkWidgetReference SelectedBgRef
		{
			get => GetProperty(ref _selectedBgRef);
			set => SetProperty(ref _selectedBgRef, value);
		}

		[Ordinal(8)] 
		[RED("SelectedBgRefJohnny")] 
		public inkWidgetReference SelectedBgRefJohnny
		{
			get => GetProperty(ref _selectedBgRefJohnny);
			set => SetProperty(ref _selectedBgRefJohnny, value);
		}

		[Ordinal(9)] 
		[RED("CaptionHolder")] 
		public inkCompoundWidgetReference CaptionHolder
		{
			get => GetProperty(ref _captionHolder);
			set => SetProperty(ref _captionHolder, value);
		}

		[Ordinal(10)] 
		[RED("SecondaryCaptionHolder")] 
		public inkCompoundWidgetReference SecondaryCaptionHolder
		{
			get => GetProperty(ref _secondaryCaptionHolder);
			set => SetProperty(ref _secondaryCaptionHolder, value);
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(12)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		[Ordinal(13)] 
		[RED("AnimationSpeed")] 
		public CFloat AnimationSpeed
		{
			get => GetProperty(ref _animationSpeed);
			set => SetProperty(ref _animationSpeed, value);
		}

		[Ordinal(14)] 
		[RED("UseConstantSpeed")] 
		public CBool UseConstantSpeed
		{
			get => GetProperty(ref _useConstantSpeed);
			set => SetProperty(ref _useConstantSpeed, value);
		}

		[Ordinal(15)] 
		[RED("phoneIcon")] 
		public inkWidgetReference PhoneIcon
		{
			get => GetProperty(ref _phoneIcon);
			set => SetProperty(ref _phoneIcon, value);
		}

		[Ordinal(16)] 
		[RED("TextFlex")] 
		public wCHandle<inkWidget> TextFlex
		{
			get => GetProperty(ref _textFlex);
			set => SetProperty(ref _textFlex, value);
		}

		[Ordinal(17)] 
		[RED("InActiveTextRoot")] 
		public wCHandle<inkWidget> InActiveTextRoot
		{
			get => GetProperty(ref _inActiveTextRoot);
			set => SetProperty(ref _inActiveTextRoot, value);
		}

		[Ordinal(18)] 
		[RED("SelectedBg")] 
		public wCHandle<inkWidget> SelectedBg
		{
			get => GetProperty(ref _selectedBg);
			set => SetProperty(ref _selectedBg, value);
		}

		[Ordinal(19)] 
		[RED("SelectedBgJohnny")] 
		public wCHandle<inkWidget> SelectedBgJohnny
		{
			get => GetProperty(ref _selectedBgJohnny);
			set => SetProperty(ref _selectedBgJohnny, value);
		}

		[Ordinal(20)] 
		[RED("InputView")] 
		public wCHandle<InteractionsInputView> InputView
		{
			get => GetProperty(ref _inputView);
			set => SetProperty(ref _inputView, value);
		}

		[Ordinal(21)] 
		[RED("CaptionControllers")] 
		public CArray<wCHandle<CaptionImageIconsLogicController>> CaptionControllers
		{
			get => GetProperty(ref _captionControllers);
			set => SetProperty(ref _captionControllers, value);
		}

		[Ordinal(22)] 
		[RED("SecondaryCaptionControllers")] 
		public CArray<wCHandle<CaptionImageIconsLogicController>> SecondaryCaptionControllers
		{
			get => GetProperty(ref _secondaryCaptionControllers);
			set => SetProperty(ref _secondaryCaptionControllers, value);
		}

		[Ordinal(23)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(24)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(25)] 
		[RED("prevIsSelected")] 
		public CBool PrevIsSelected
		{
			get => GetProperty(ref _prevIsSelected);
			set => SetProperty(ref _prevIsSelected, value);
		}

		[Ordinal(26)] 
		[RED("hasDedicatedInput")] 
		public CBool HasDedicatedInput
		{
			get => GetProperty(ref _hasDedicatedInput);
			set => SetProperty(ref _hasDedicatedInput, value);
		}

		[Ordinal(27)] 
		[RED("overriddenInput")] 
		public CBool OverriddenInput
		{
			get => GetProperty(ref _overriddenInput);
			set => SetProperty(ref _overriddenInput, value);
		}

		[Ordinal(28)] 
		[RED("isPreserveSelectionFadeOut")] 
		public CBool IsPreserveSelectionFadeOut
		{
			get => GetProperty(ref _isPreserveSelectionFadeOut);
			set => SetProperty(ref _isPreserveSelectionFadeOut, value);
		}

		[Ordinal(29)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get => GetProperty(ref _isPhoneLockActive);
			set => SetProperty(ref _isPhoneLockActive, value);
		}

		[Ordinal(30)] 
		[RED("dedicatedInputName")] 
		public CName DedicatedInputName
		{
			get => GetProperty(ref _dedicatedInputName);
			set => SetProperty(ref _dedicatedInputName, value);
		}

		[Ordinal(31)] 
		[RED("Active")] 
		public CName Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(32)] 
		[RED("Inactive")] 
		public CName Inactive
		{
			get => GetProperty(ref _inactive);
			set => SetProperty(ref _inactive, value);
		}

		[Ordinal(33)] 
		[RED("Black")] 
		public CName Black
		{
			get => GetProperty(ref _black);
			set => SetProperty(ref _black, value);
		}

		[Ordinal(34)] 
		[RED("questColor")] 
		public CName QuestColor
		{
			get => GetProperty(ref _questColor);
			set => SetProperty(ref _questColor, value);
		}

		[Ordinal(35)] 
		[RED("possessedDialog")] 
		public CName PossessedDialog
		{
			get => GetProperty(ref _possessedDialog);
			set => SetProperty(ref _possessedDialog, value);
		}

		[Ordinal(36)] 
		[RED("ControllerPromptLimit")] 
		public CInt32 ControllerPromptLimit
		{
			get => GetProperty(ref _controllerPromptLimit);
			set => SetProperty(ref _controllerPromptLimit, value);
		}

		[Ordinal(37)] 
		[RED("fadingOptionEndTransparency")] 
		public CFloat FadingOptionEndTransparency
		{
			get => GetProperty(ref _fadingOptionEndTransparency);
			set => SetProperty(ref _fadingOptionEndTransparency, value);
		}

		[Ordinal(38)] 
		[RED("animSelectedBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedBgProxy
		{
			get => GetProperty(ref _animSelectedBgProxy);
			set => SetProperty(ref _animSelectedBgProxy, value);
		}

		[Ordinal(39)] 
		[RED("animSelectedJohnnyBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedJohnnyBgProxy
		{
			get => GetProperty(ref _animSelectedJohnnyBgProxy);
			set => SetProperty(ref _animSelectedJohnnyBgProxy, value);
		}

		[Ordinal(40)] 
		[RED("animActiveTextProxy")] 
		public CHandle<inkanimProxy> AnimActiveTextProxy
		{
			get => GetProperty(ref _animActiveTextProxy);
			set => SetProperty(ref _animActiveTextProxy, value);
		}

		[Ordinal(41)] 
		[RED("animfFadingOutProxy")] 
		public CHandle<inkanimProxy> AnimfFadingOutProxy
		{
			get => GetProperty(ref _animfFadingOutProxy);
			set => SetProperty(ref _animfFadingOutProxy, value);
		}

		[Ordinal(42)] 
		[RED("animIntroProxy")] 
		public CHandle<inkanimProxy> AnimIntroProxy
		{
			get => GetProperty(ref _animIntroProxy);
			set => SetProperty(ref _animIntroProxy, value);
		}

		public DialogChoiceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
