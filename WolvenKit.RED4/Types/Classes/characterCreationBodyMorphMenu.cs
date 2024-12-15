using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationBodyMorphMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("defaultPreviewSlot")] 
		public CName DefaultPreviewSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("optionsList")] 
		public inkCompoundWidgetReference OptionsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("colorPicker")] 
		public inkWidgetReference ColorPicker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("colorPickerContentWrapper")] 
		public inkWidgetReference ColorPickerContentWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("colorPickerBG")] 
		public inkWidgetReference ColorPickerBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("colorPickerClose")] 
		public inkWidgetReference ColorPickerClose
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("optionList")] 
		public CWeakHandle<inkCompoundWidget> OptionList
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("slider")] 
		public inkWidgetReference Slider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("previousPageBtnBg")] 
		public inkImageWidgetReference PreviousPageBtnBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("previousPageBtnText")] 
		public inkTextWidgetReference PreviousPageBtnText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("nextPageBtnBg")] 
		public inkImageWidgetReference NextPageBtnBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("nextPageBtnText")] 
		public inkTextWidgetReference NextPageBtnText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("backConfirmation")] 
		public inkWidgetReference BackConfirmation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("backConfirmationWidget")] 
		public inkWidgetReference BackConfirmationWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("preset1Group")] 
		public inkWidgetReference Preset1Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("preset2Group")] 
		public inkWidgetReference Preset2Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("preset3Group")] 
		public inkWidgetReference Preset3Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("randomizeGroup")] 
		public inkWidgetReference RandomizeGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("presetsLabel")] 
		public inkWidgetReference PresetsLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("preset1")] 
		public inkWidgetReference Preset1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("preset2")] 
		public inkWidgetReference Preset2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("preset3")] 
		public inkWidgetReference Preset3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("randomize")] 
		public inkWidgetReference Randomize
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("randomizeBg")] 
		public inkImageWidgetReference RandomizeBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("randomizationSettingsButton")] 
		public inkWidgetReference RandomizationSettingsButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("randomizationSettingsWidget")] 
		public inkWidgetReference RandomizationSettingsWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("randomizationSettingsController")] 
		public CWeakHandle<gameuiCharacterRandomizationController> RandomizationSettingsController
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterRandomizationController>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterRandomizationController>>(value);
		}

		[Ordinal(38)] 
		[RED("randomizationSettingsButtonBg")] 
		public inkImageWidgetReference RandomizationSettingsButtonBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("preset1Thumbnail")] 
		public inkImageWidgetReference Preset1Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("preset2Thumbnail")] 
		public inkImageWidgetReference Preset2Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("preset3Thumbnail")] 
		public inkImageWidgetReference Preset3Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("preset1Bg")] 
		public inkImageWidgetReference Preset1Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("preset2Bg")] 
		public inkImageWidgetReference Preset2Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("preset3Bg")] 
		public inkImageWidgetReference Preset3Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("hideColorPickerNextFrame")] 
		public CBool HideColorPickerNextFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("colorPickerOwner")] 
		public CWeakHandle<inkWidget> ColorPickerOwner
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(48)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(50)] 
		[RED("optionListAnimationProxy")] 
		public CHandle<inkanimProxy> OptionListAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(51)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("introPlayed")] 
		public CBool IntroPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("navigationControllers")] 
		public CArray<CWeakHandle<inkDiscreteNavigationController>> NavigationControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>(value);
		}

		[Ordinal(54)] 
		[RED("presetsNavigationControllers")] 
		public CArray<CWeakHandle<inkDiscreteNavigationController>> PresetsNavigationControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>(value);
		}

		[Ordinal(55)] 
		[RED("menuListController")] 
		public CWeakHandle<inkListController> MenuListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(56)] 
		[RED("cachedCursor")] 
		public CWeakHandle<inkWidget> CachedCursor
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(57)] 
		[RED("updatingFinalizedState")] 
		public CBool UpdatingFinalizedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>(value);
		}

		[Ordinal(59)] 
		[RED("busySwitchingAppearance")] 
		public CBool BusySwitchingAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(61)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(62)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("isPresetHoveredOver")] 
		public CBool IsPresetHoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("maxColorPickerHeight")] 
		public CFloat MaxColorPickerHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(65)] 
		[RED("minColorPickerHeight")] 
		public CFloat MinColorPickerHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("colorPickerHeightPerRow")] 
		public CFloat ColorPickerHeightPerRow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public characterCreationBodyMorphMenu()
		{
			DefaultPreviewSlot = "UI_Skin";
			OptionsList = new inkCompoundWidgetReference();
			ColorPicker = new inkWidgetReference();
			ColorPickerContentWrapper = new inkWidgetReference();
			ColorPickerBG = new inkWidgetReference();
			ColorPickerClose = new inkWidgetReference();
			ScrollWidget = new inkWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			Slider = new inkWidgetReference();
			PreviousPageBtn = new inkWidgetReference();
			PreviousPageBtnBg = new inkImageWidgetReference();
			PreviousPageBtnText = new inkTextWidgetReference();
			NextPageBtnBg = new inkImageWidgetReference();
			NextPageBtnText = new inkTextWidgetReference();
			BackConfirmation = new inkWidgetReference();
			BackConfirmationWidget = new inkWidgetReference();
			ConfirmationConfirmBtn = new inkWidgetReference();
			ConfirmationCloseBtn = new inkWidgetReference();
			Preset1Group = new inkWidgetReference();
			Preset2Group = new inkWidgetReference();
			Preset3Group = new inkWidgetReference();
			RandomizeGroup = new inkWidgetReference();
			PresetsLabel = new inkWidgetReference();
			Preset1 = new inkWidgetReference();
			Preset2 = new inkWidgetReference();
			Preset3 = new inkWidgetReference();
			Randomize = new inkWidgetReference();
			RandomizeBg = new inkImageWidgetReference();
			RandomizationSettingsButton = new inkWidgetReference();
			RandomizationSettingsWidget = new inkWidgetReference();
			RandomizationSettingsButtonBg = new inkImageWidgetReference();
			Preset1Thumbnail = new inkImageWidgetReference();
			Preset2Thumbnail = new inkImageWidgetReference();
			Preset3Thumbnail = new inkImageWidgetReference();
			Preset1Bg = new inkImageWidgetReference();
			Preset2Bg = new inkImageWidgetReference();
			Preset3Bg = new inkImageWidgetReference();
			NavigationButtons = new inkWidgetReference();
			NavigationControllers = new();
			PresetsNavigationControllers = new();
			MaxColorPickerHeight = 1400.000000F;
			MinColorPickerHeight = 200.000000F;
			ColorPickerHeightPerRow = 200.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
