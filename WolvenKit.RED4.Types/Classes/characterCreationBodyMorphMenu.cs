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
		[RED("colorPickerBG")] 
		public inkWidgetReference ColorPickerBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("colorPickerClose")] 
		public inkWidgetReference ColorPickerClose
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("optionList")] 
		public CWeakHandle<inkCompoundWidget> OptionList
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("slider")] 
		public inkWidgetReference Slider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("previousPageBtnBg")] 
		public inkImageWidgetReference PreviousPageBtnBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("previousPageBtnText")] 
		public inkTextWidgetReference PreviousPageBtnText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("nextPageBtnBg")] 
		public inkImageWidgetReference NextPageBtnBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("nextPageBtnText")] 
		public inkTextWidgetReference NextPageBtnText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("backConfirmation")] 
		public inkWidgetReference BackConfirmation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("backConfirmationWidget")] 
		public inkWidgetReference BackConfirmationWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("preset1Group")] 
		public inkWidgetReference Preset1Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("preset2Group")] 
		public inkWidgetReference Preset2Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("preset3Group")] 
		public inkWidgetReference Preset3Group
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("randomizeGroup")] 
		public inkWidgetReference RandomizeGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("presetsLabel")] 
		public inkWidgetReference PresetsLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("preset1")] 
		public inkWidgetReference Preset1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("preset2")] 
		public inkWidgetReference Preset2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("preset3")] 
		public inkWidgetReference Preset3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("randomize")] 
		public inkWidgetReference Randomize
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("preset1Thumbnail")] 
		public inkImageWidgetReference Preset1Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("preset2Thumbnail")] 
		public inkImageWidgetReference Preset2Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("preset3Thumbnail")] 
		public inkImageWidgetReference Preset3Thumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("randomizThumbnail")] 
		public inkImageWidgetReference RandomizThumbnail
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("preset1Bg")] 
		public inkImageWidgetReference Preset1Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("preset2Bg")] 
		public inkImageWidgetReference Preset2Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("preset3Bg")] 
		public inkImageWidgetReference Preset3Bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("randomizBg")] 
		public inkImageWidgetReference RandomizBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("hideColorPickerNextFrame")] 
		public CBool HideColorPickerNextFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("colorPickerOwner")] 
		public CWeakHandle<inkWidget> ColorPickerOwner
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(44)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(45)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("optionListAnimationProxy")] 
		public CHandle<inkanimProxy> OptionListAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("introPlayed")] 
		public CBool IntroPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("navigationControllers")] 
		public CArray<CWeakHandle<inkDiscreteNavigationController>> NavigationControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkDiscreteNavigationController>>>(value);
		}

		[Ordinal(50)] 
		[RED("menuListController")] 
		public CWeakHandle<inkListController> MenuListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(51)] 
		[RED("cachedCursor")] 
		public CWeakHandle<inkWidget> CachedCursor
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(52)] 
		[RED("updatingFinalizedState")] 
		public CBool UpdatingFinalizedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>(value);
		}

		[Ordinal(54)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(55)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(56)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public characterCreationBodyMorphMenu()
		{
			DefaultPreviewSlot = "UI_Skin";
			OptionsList = new();
			ColorPicker = new();
			ColorPickerBG = new();
			ColorPickerClose = new();
			ScrollWidget = new();
			ScrollArea = new();
			Slider = new();
			PreviousPageBtn = new();
			PreviousPageBtnBg = new();
			PreviousPageBtnText = new();
			NextPageBtnBg = new();
			NextPageBtnText = new();
			BackConfirmation = new();
			BackConfirmationWidget = new();
			ConfirmationConfirmBtn = new();
			ConfirmationCloseBtn = new();
			Preset1Group = new();
			Preset2Group = new();
			Preset3Group = new();
			RandomizeGroup = new();
			PresetsLabel = new();
			Preset1 = new();
			Preset2 = new();
			Preset3 = new();
			Randomize = new();
			Preset1Thumbnail = new();
			Preset2Thumbnail = new();
			Preset3Thumbnail = new();
			RandomizThumbnail = new();
			Preset1Bg = new();
			Preset2Bg = new();
			Preset3Bg = new();
			RandomizBg = new();
			NavigationButtons = new();
			NavigationControllers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
