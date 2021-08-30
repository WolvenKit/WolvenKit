using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationBodyMorphMenu : gameuiBaseCharacterCreationController
	{
		private CName _defaultPreviewSlot;
		private inkCompoundWidgetReference _optionsList;
		private inkWidgetReference _colorPicker;
		private inkWidgetReference _colorPickerBG;
		private inkWidgetReference _colorPickerClose;
		private inkScrollAreaWidgetReference _scrollArea;
		private CWeakHandle<inkCompoundWidget> _optionList;
		private inkWidgetReference _previousPageBtn;
		private inkImageWidgetReference _previousPageBtnBg;
		private inkImageWidgetReference _nextPageBtnBg;
		private inkWidgetReference _backConfirmation;
		private inkWidgetReference _backConfirmationWidget;
		private inkWidgetReference _confirmationConfirmBtn;
		private inkWidgetReference _confirmationCloseBtn;
		private inkWidgetReference _preset1;
		private inkWidgetReference _preset2;
		private inkWidgetReference _preset3;
		private inkWidgetReference _randomize;
		private inkImageWidgetReference _preset1Thumbnail;
		private inkImageWidgetReference _preset2Thumbnail;
		private inkImageWidgetReference _preset3Thumbnail;
		private inkImageWidgetReference _randomizThumbnail;
		private inkImageWidgetReference _preset1Bg;
		private inkImageWidgetReference _preset2Bg;
		private inkImageWidgetReference _preset3Bg;
		private inkImageWidgetReference _randomizBg;
		private inkWidgetReference _navigationButtons;
		private CBool _hideColorPickerNextFrame;
		private CWeakHandle<inkWidget> _colorPickerOwner;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _confirmAnimationProxy;
		private CHandle<inkanimProxy> _optionListAnimationProxy;
		private CBool _optionsListInitialized;
		private CBool _introPlayed;
		private CWeakHandle<inkListController> _menuListController;
		private CWeakHandle<inkWidget> _cachedCursor;

		[Ordinal(6)] 
		[RED("defaultPreviewSlot")] 
		public CName DefaultPreviewSlot
		{
			get => GetProperty(ref _defaultPreviewSlot);
			set => SetProperty(ref _defaultPreviewSlot, value);
		}

		[Ordinal(7)] 
		[RED("optionsList")] 
		public inkCompoundWidgetReference OptionsList
		{
			get => GetProperty(ref _optionsList);
			set => SetProperty(ref _optionsList, value);
		}

		[Ordinal(8)] 
		[RED("colorPicker")] 
		public inkWidgetReference ColorPicker
		{
			get => GetProperty(ref _colorPicker);
			set => SetProperty(ref _colorPicker, value);
		}

		[Ordinal(9)] 
		[RED("colorPickerBG")] 
		public inkWidgetReference ColorPickerBG
		{
			get => GetProperty(ref _colorPickerBG);
			set => SetProperty(ref _colorPickerBG, value);
		}

		[Ordinal(10)] 
		[RED("colorPickerClose")] 
		public inkWidgetReference ColorPickerClose
		{
			get => GetProperty(ref _colorPickerClose);
			set => SetProperty(ref _colorPickerClose, value);
		}

		[Ordinal(11)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(12)] 
		[RED("optionList")] 
		public CWeakHandle<inkCompoundWidget> OptionList
		{
			get => GetProperty(ref _optionList);
			set => SetProperty(ref _optionList, value);
		}

		[Ordinal(13)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetProperty(ref _previousPageBtn);
			set => SetProperty(ref _previousPageBtn, value);
		}

		[Ordinal(14)] 
		[RED("previousPageBtnBg")] 
		public inkImageWidgetReference PreviousPageBtnBg
		{
			get => GetProperty(ref _previousPageBtnBg);
			set => SetProperty(ref _previousPageBtnBg, value);
		}

		[Ordinal(15)] 
		[RED("nextPageBtnBg")] 
		public inkImageWidgetReference NextPageBtnBg
		{
			get => GetProperty(ref _nextPageBtnBg);
			set => SetProperty(ref _nextPageBtnBg, value);
		}

		[Ordinal(16)] 
		[RED("backConfirmation")] 
		public inkWidgetReference BackConfirmation
		{
			get => GetProperty(ref _backConfirmation);
			set => SetProperty(ref _backConfirmation, value);
		}

		[Ordinal(17)] 
		[RED("backConfirmationWidget")] 
		public inkWidgetReference BackConfirmationWidget
		{
			get => GetProperty(ref _backConfirmationWidget);
			set => SetProperty(ref _backConfirmationWidget, value);
		}

		[Ordinal(18)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetProperty(ref _confirmationConfirmBtn);
			set => SetProperty(ref _confirmationConfirmBtn, value);
		}

		[Ordinal(19)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetProperty(ref _confirmationCloseBtn);
			set => SetProperty(ref _confirmationCloseBtn, value);
		}

		[Ordinal(20)] 
		[RED("preset1")] 
		public inkWidgetReference Preset1
		{
			get => GetProperty(ref _preset1);
			set => SetProperty(ref _preset1, value);
		}

		[Ordinal(21)] 
		[RED("preset2")] 
		public inkWidgetReference Preset2
		{
			get => GetProperty(ref _preset2);
			set => SetProperty(ref _preset2, value);
		}

		[Ordinal(22)] 
		[RED("preset3")] 
		public inkWidgetReference Preset3
		{
			get => GetProperty(ref _preset3);
			set => SetProperty(ref _preset3, value);
		}

		[Ordinal(23)] 
		[RED("randomize")] 
		public inkWidgetReference Randomize
		{
			get => GetProperty(ref _randomize);
			set => SetProperty(ref _randomize, value);
		}

		[Ordinal(24)] 
		[RED("preset1Thumbnail")] 
		public inkImageWidgetReference Preset1Thumbnail
		{
			get => GetProperty(ref _preset1Thumbnail);
			set => SetProperty(ref _preset1Thumbnail, value);
		}

		[Ordinal(25)] 
		[RED("preset2Thumbnail")] 
		public inkImageWidgetReference Preset2Thumbnail
		{
			get => GetProperty(ref _preset2Thumbnail);
			set => SetProperty(ref _preset2Thumbnail, value);
		}

		[Ordinal(26)] 
		[RED("preset3Thumbnail")] 
		public inkImageWidgetReference Preset3Thumbnail
		{
			get => GetProperty(ref _preset3Thumbnail);
			set => SetProperty(ref _preset3Thumbnail, value);
		}

		[Ordinal(27)] 
		[RED("randomizThumbnail")] 
		public inkImageWidgetReference RandomizThumbnail
		{
			get => GetProperty(ref _randomizThumbnail);
			set => SetProperty(ref _randomizThumbnail, value);
		}

		[Ordinal(28)] 
		[RED("preset1Bg")] 
		public inkImageWidgetReference Preset1Bg
		{
			get => GetProperty(ref _preset1Bg);
			set => SetProperty(ref _preset1Bg, value);
		}

		[Ordinal(29)] 
		[RED("preset2Bg")] 
		public inkImageWidgetReference Preset2Bg
		{
			get => GetProperty(ref _preset2Bg);
			set => SetProperty(ref _preset2Bg, value);
		}

		[Ordinal(30)] 
		[RED("preset3Bg")] 
		public inkImageWidgetReference Preset3Bg
		{
			get => GetProperty(ref _preset3Bg);
			set => SetProperty(ref _preset3Bg, value);
		}

		[Ordinal(31)] 
		[RED("randomizBg")] 
		public inkImageWidgetReference RandomizBg
		{
			get => GetProperty(ref _randomizBg);
			set => SetProperty(ref _randomizBg, value);
		}

		[Ordinal(32)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetProperty(ref _navigationButtons);
			set => SetProperty(ref _navigationButtons, value);
		}

		[Ordinal(33)] 
		[RED("hideColorPickerNextFrame")] 
		public CBool HideColorPickerNextFrame
		{
			get => GetProperty(ref _hideColorPickerNextFrame);
			set => SetProperty(ref _hideColorPickerNextFrame, value);
		}

		[Ordinal(34)] 
		[RED("colorPickerOwner")] 
		public CWeakHandle<inkWidget> ColorPickerOwner
		{
			get => GetProperty(ref _colorPickerOwner);
			set => SetProperty(ref _colorPickerOwner, value);
		}

		[Ordinal(35)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(36)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetProperty(ref _confirmAnimationProxy);
			set => SetProperty(ref _confirmAnimationProxy, value);
		}

		[Ordinal(37)] 
		[RED("optionListAnimationProxy")] 
		public CHandle<inkanimProxy> OptionListAnimationProxy
		{
			get => GetProperty(ref _optionListAnimationProxy);
			set => SetProperty(ref _optionListAnimationProxy, value);
		}

		[Ordinal(38)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetProperty(ref _optionsListInitialized);
			set => SetProperty(ref _optionsListInitialized, value);
		}

		[Ordinal(39)] 
		[RED("introPlayed")] 
		public CBool IntroPlayed
		{
			get => GetProperty(ref _introPlayed);
			set => SetProperty(ref _introPlayed, value);
		}

		[Ordinal(40)] 
		[RED("menuListController")] 
		public CWeakHandle<inkListController> MenuListController
		{
			get => GetProperty(ref _menuListController);
			set => SetProperty(ref _menuListController, value);
		}

		[Ordinal(41)] 
		[RED("cachedCursor")] 
		public CWeakHandle<inkWidget> CachedCursor
		{
			get => GetProperty(ref _cachedCursor);
			set => SetProperty(ref _cachedCursor, value);
		}

		public characterCreationBodyMorphMenu()
		{
			_defaultPreviewSlot = "UI_Hairs";
		}
	}
}
