using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTokenPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("optionRef", 4)] 
		public CArrayFixedSize<inkWidgetReference> OptionRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("optionTooltipParent", 4)] 
		public CArrayFixedSize<inkWidgetReference> OptionTooltipParent
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(4)] 
		[RED("option1ProgressBarRef")] 
		public inkWidgetReference Option1ProgressBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("option2ProgressBarRef")] 
		public inkWidgetReference Option2ProgressBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("option3ProgressBarRef")] 
		public inkWidgetReference Option3ProgressBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("option1HoverZone")] 
		public inkWidgetReference Option1HoverZone
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("option2HoverZone")] 
		public inkWidgetReference Option2HoverZone
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("option3HoverZone")] 
		public inkWidgetReference Option3HoverZone
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("progressEffectName")] 
		public CName ProgressEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("option1UpgradeBtnAnchor")] 
		public inkWidgetReference Option1UpgradeBtnAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("option2UpgradeBtnAnchor")] 
		public inkWidgetReference Option2UpgradeBtnAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("option3UpgradeBtnAnchor")] 
		public inkWidgetReference Option3UpgradeBtnAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("upgradeBtnContainerRef")] 
		public inkWidgetReference UpgradeBtnContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("upgradeButtonLabelKey")] 
		public CString UpgradeButtonLabelKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(16)] 
		[RED("upgradeButtonAnimDuration")] 
		public CFloat UpgradeButtonAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("upgradeButtonResRef")] 
		public redResourceReferenceScriptToken UpgradeButtonResRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(18)] 
		[RED("upgradeButtonResName")] 
		public CName UpgradeButtonResName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("noChoiceIntroAnimName")] 
		public CName NoChoiceIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("twoChoiceIntroAnimName")] 
		public CName TwoChoiceIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("threeChoiceIntroAnimName")] 
		public CName ThreeChoiceIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("noChoiceOutroAnimName")] 
		public CName NoChoiceOutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("twoChoice1OutroAnimName")] 
		public CName TwoChoice1OutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("twoChoice2OutroAnimName")] 
		public CName TwoChoice2OutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("threeChoice1OutroAnimName")] 
		public CName ThreeChoice1OutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("threeChoice2OutroAnimName")] 
		public CName ThreeChoice2OutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("threeChoice3OutroAnimName")] 
		public CName ThreeChoice3OutroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("holdInputName")] 
		public CName HoldInputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("exitInputName")] 
		public CName ExitInputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("itemToolitpResRef")] 
		public redResourceReferenceScriptToken ItemToolitpResRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(32)] 
		[RED("itemTooltipName")] 
		public CName ItemTooltipName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("cyberdeckToolitpResRef")] 
		public redResourceReferenceScriptToken CyberdeckToolitpResRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(34)] 
		[RED("cyberdeckTooltipName")] 
		public CName CyberdeckTooltipName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("toolitpWidgetRef")] 
		public redResourceReferenceScriptToken ToolitpWidgetRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(36)] 
		[RED("tooltipName")] 
		public CName TooltipName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("itemTooltipController0")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController0
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(38)] 
		[RED("itemTooltipController1")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController1
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(39)] 
		[RED("itemTooltipController2")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController2
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(40)] 
		[RED("itemTooltipController3")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController3
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(41)] 
		[RED("itemTooltipCyberwareUpgrade")] 
		public CWeakHandle<ItemTooltipCyberwareUpgradeController> ItemTooltipCyberwareUpgrade
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipCyberwareUpgradeController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipCyberwareUpgradeController>>(value);
		}

		[Ordinal(42)] 
		[RED("option1ProgressBar")] 
		public CWeakHandle<inkWidget> Option1ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(43)] 
		[RED("option2ProgressBar")] 
		public CWeakHandle<inkWidget> Option2ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(44)] 
		[RED("option3ProgressBar")] 
		public CWeakHandle<inkWidget> Option3ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(45)] 
		[RED("audioSystem")] 
		public CWeakHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetPropertyValue<CWeakHandle<gameGameAudioSystem>>();
			set => SetPropertyValue<CWeakHandle<gameGameAudioSystem>>(value);
		}

		[Ordinal(46)] 
		[RED("data")] 
		public CHandle<RipperdocTokenPopupData> Data
		{
			get => GetPropertyValue<CHandle<RipperdocTokenPopupData>>();
			set => SetPropertyValue<CHandle<RipperdocTokenPopupData>>(value);
		}

		[Ordinal(47)] 
		[RED("multichoice")] 
		public CBool Multichoice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("thirdChoiceAvailable")] 
		public CBool ThirdChoiceAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("progressStarted")] 
		public CBool ProgressStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("introAnimationPlaying")] 
		public CBool IntroAnimationPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("choicesAnimProxy")] 
		public CHandle<inkanimProxy> ChoicesAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(52)] 
		[RED("buttonAnimProxy")] 
		public CHandle<inkanimProxy> ButtonAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(53)] 
		[RED("currentOption")] 
		public CInt32 CurrentOption
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(54)] 
		[RED("choice")] 
		public CInt32 Choice
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(55)] 
		[RED("result")] 
		public CBool Result
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("inputListenersRegistered")] 
		public CBool InputListenersRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocTokenPopup()
		{
			OptionRef = new(4);
			OptionTooltipParent = new(4);
			Option1ProgressBarRef = new inkWidgetReference();
			Option2ProgressBarRef = new inkWidgetReference();
			Option3ProgressBarRef = new inkWidgetReference();
			Option1HoverZone = new inkWidgetReference();
			Option2HoverZone = new inkWidgetReference();
			Option3HoverZone = new inkWidgetReference();
			ProgressEffectName = "progress";
			Option1UpgradeBtnAnchor = new inkWidgetReference();
			Option2UpgradeBtnAnchor = new inkWidgetReference();
			Option3UpgradeBtnAnchor = new inkWidgetReference();
			UpgradeBtnContainerRef = new inkWidgetReference();
			UpgradeButtonAnimDuration = 0.300000F;
			UpgradeButtonResRef = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\common\tooltip\cyberware_tooltip_modules.inkwidget") };
			UpgradeButtonResName = "itemCyberwareUpgrade";
			ExitInputName = "close_popup";
			ButtonHintsRoot = new inkWidgetReference();
			ItemToolitpResRef = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\common\tooltip\itemtooltip.inkwidget") };
			ItemTooltipName = "itemTooltip";
			CyberdeckToolitpResRef = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\common\tooltip\cyberdecktooltip.inkwidget") };
			CyberdeckTooltipName = "cyberdeckTooltip";
			ToolitpWidgetRef = new redResourceReferenceScriptToken();
			Choice = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
