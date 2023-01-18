using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DialogChoiceLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("InputViewRef")] 
		public inkWidgetReference InputViewRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("VerticalLineWidget")] 
		public inkWidgetReference VerticalLineWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ActiveTextRef")] 
		public inkTextWidgetReference ActiveTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("InActiveTextRef")] 
		public inkTextWidgetReference InActiveTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("InActiveTextRootRef")] 
		public inkWidgetReference InActiveTextRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("TextFlexRef")] 
		public inkWidgetReference TextFlexRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("SelectedBgRef")] 
		public inkWidgetReference SelectedBgRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("SelectedBgRefJohnny")] 
		public inkWidgetReference SelectedBgRefJohnny
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("CaptionHolder")] 
		public inkCompoundWidgetReference CaptionHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("SecondaryCaptionHolder")] 
		public inkCompoundWidgetReference SecondaryCaptionHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("AnimationSpeed")] 
		public CFloat AnimationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("UseConstantSpeed")] 
		public CBool UseConstantSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("phoneIcon")] 
		public inkWidgetReference PhoneIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("TextFlex")] 
		public CWeakHandle<inkWidget> TextFlex
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("InActiveTextRoot")] 
		public CWeakHandle<inkWidget> InActiveTextRoot
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("SelectedBg")] 
		public CWeakHandle<inkWidget> SelectedBg
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("SelectedBgJohnny")] 
		public CWeakHandle<inkWidget> SelectedBgJohnny
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("InputView")] 
		public CWeakHandle<InteractionsInputView> InputView
		{
			get => GetPropertyValue<CWeakHandle<InteractionsInputView>>();
			set => SetPropertyValue<CWeakHandle<InteractionsInputView>>(value);
		}

		[Ordinal(21)] 
		[RED("CaptionControllers")] 
		public CArray<CWeakHandle<CaptionImageIconsLogicController>> CaptionControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<CaptionImageIconsLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CaptionImageIconsLogicController>>>(value);
		}

		[Ordinal(22)] 
		[RED("SecondaryCaptionControllers")] 
		public CArray<CWeakHandle<CaptionImageIconsLogicController>> SecondaryCaptionControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<CaptionImageIconsLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CaptionImageIconsLogicController>>>(value);
		}

		[Ordinal(23)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		[Ordinal(24)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("prevIsSelected")] 
		public CBool PrevIsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("hasDedicatedInput")] 
		public CBool HasDedicatedInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("overriddenInput")] 
		public CBool OverriddenInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isPreserveSelectionFadeOut")] 
		public CBool IsPreserveSelectionFadeOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("dedicatedInputName")] 
		public CName DedicatedInputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("Active")] 
		public CName Active
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("Inactive")] 
		public CName Inactive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("Black")] 
		public CName Black
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("questColor")] 
		public CName QuestColor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("possessedDialog")] 
		public CName PossessedDialog
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("ControllerPromptLimit")] 
		public CInt32 ControllerPromptLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("fadingOptionEndTransparency")] 
		public CFloat FadingOptionEndTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("animSelectedBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedBgProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("animSelectedJohnnyBgProxy")] 
		public CHandle<inkanimProxy> AnimSelectedJohnnyBgProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("animActiveTextProxy")] 
		public CHandle<inkanimProxy> AnimActiveTextProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("animfFadingOutProxy")] 
		public CHandle<inkanimProxy> AnimfFadingOutProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("animIntroProxy")] 
		public CHandle<inkanimProxy> AnimIntroProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public DialogChoiceLogicController()
		{
			InputViewRef = new();
			VerticalLineWidget = new();
			ActiveTextRef = new();
			InActiveTextRef = new();
			InActiveTextRootRef = new();
			TextFlexRef = new();
			SelectedBgRef = new();
			SelectedBgRefJohnny = new();
			CaptionHolder = new();
			SecondaryCaptionHolder = new();
			AnimationTime = 0.150000F;
			AnimationSpeed = 500.000000F;
			PhoneIcon = new();
			CaptionControllers = new();
			SecondaryCaptionControllers = new();
			Type = new();
			ControllerPromptLimit = 3;
			FadingOptionEndTransparency = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
