using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationBodyMorphColorOption : inkWidgetLogicController
	{
		private inkTextWidgetReference _optionLabel;
		private inkWidgetReference _colorPickerBtn;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private CWeakHandle<gameuiCharacterCustomizationOption> _colorPickerOption;
		private CWeakHandle<gameuiAppearanceInfo> _appearanceInfo;
		private CInt32 _currColorIndex;
		private CWeakHandle<inkWidget> _selector;

		[Ordinal(1)] 
		[RED("optionLabel")] 
		public inkTextWidgetReference OptionLabel
		{
			get => GetProperty(ref _optionLabel);
			set => SetProperty(ref _optionLabel, value);
		}

		[Ordinal(2)] 
		[RED("colorPickerBtn")] 
		public inkWidgetReference ColorPickerBtn
		{
			get => GetProperty(ref _colorPickerBtn);
			set => SetProperty(ref _colorPickerBtn, value);
		}

		[Ordinal(3)] 
		[RED("selectorNextBtn")] 
		public inkWidgetReference SelectorNextBtn
		{
			get => GetProperty(ref _selectorNextBtn);
			set => SetProperty(ref _selectorNextBtn, value);
		}

		[Ordinal(4)] 
		[RED("selectorPrevBtn")] 
		public inkWidgetReference SelectorPrevBtn
		{
			get => GetProperty(ref _selectorPrevBtn);
			set => SetProperty(ref _selectorPrevBtn, value);
		}

		[Ordinal(5)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get => GetProperty(ref _selectorTexture);
			set => SetProperty(ref _selectorTexture, value);
		}

		[Ordinal(6)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get => GetProperty(ref _arrowsTexture);
			set => SetProperty(ref _arrowsTexture, value);
		}

		[Ordinal(7)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetProperty(ref _optionSwitchHint);
			set => SetProperty(ref _optionSwitchHint, value);
		}

		[Ordinal(8)] 
		[RED("colorPickerOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> ColorPickerOption
		{
			get => GetProperty(ref _colorPickerOption);
			set => SetProperty(ref _colorPickerOption, value);
		}

		[Ordinal(9)] 
		[RED("appearanceInfo")] 
		public CWeakHandle<gameuiAppearanceInfo> AppearanceInfo
		{
			get => GetProperty(ref _appearanceInfo);
			set => SetProperty(ref _appearanceInfo, value);
		}

		[Ordinal(10)] 
		[RED("currColorIndex")] 
		public CInt32 CurrColorIndex
		{
			get => GetProperty(ref _currColorIndex);
			set => SetProperty(ref _currColorIndex, value);
		}

		[Ordinal(11)] 
		[RED("selector")] 
		public CWeakHandle<inkWidget> Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}
	}
}
