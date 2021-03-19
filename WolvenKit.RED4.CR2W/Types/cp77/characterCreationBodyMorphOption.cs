using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOption : inkWidgetLogicController
	{
		private inkTextWidgetReference _optionLabel;
		private inkTextWidgetReference _selectedLabel;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private wCHandle<gameuiCharacterCustomizationOption> _selectorOption;
		private wCHandle<gameuiMorphInfo> _morphInfo;
		private wCHandle<gameuiAppearanceInfo> _appearanceInfo;
		private wCHandle<gameuiSwitcherInfo> _switcherInfo;
		private CInt32 _currSelectorIndex;
		private wCHandle<inkWidget> _selector;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(1)] 
		[RED("optionLabel")] 
		public inkTextWidgetReference OptionLabel
		{
			get => GetProperty(ref _optionLabel);
			set => SetProperty(ref _optionLabel, value);
		}

		[Ordinal(2)] 
		[RED("selectedLabel")] 
		public inkTextWidgetReference SelectedLabel
		{
			get => GetProperty(ref _selectedLabel);
			set => SetProperty(ref _selectedLabel, value);
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
		[RED("selectorOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> SelectorOption
		{
			get => GetProperty(ref _selectorOption);
			set => SetProperty(ref _selectorOption, value);
		}

		[Ordinal(9)] 
		[RED("morphInfo")] 
		public wCHandle<gameuiMorphInfo> MorphInfo
		{
			get => GetProperty(ref _morphInfo);
			set => SetProperty(ref _morphInfo, value);
		}

		[Ordinal(10)] 
		[RED("appearanceInfo")] 
		public wCHandle<gameuiAppearanceInfo> AppearanceInfo
		{
			get => GetProperty(ref _appearanceInfo);
			set => SetProperty(ref _appearanceInfo, value);
		}

		[Ordinal(11)] 
		[RED("switcherInfo")] 
		public wCHandle<gameuiSwitcherInfo> SwitcherInfo
		{
			get => GetProperty(ref _switcherInfo);
			set => SetProperty(ref _switcherInfo, value);
		}

		[Ordinal(12)] 
		[RED("currSelectorIndex")] 
		public CInt32 CurrSelectorIndex
		{
			get => GetProperty(ref _currSelectorIndex);
			set => SetProperty(ref _currSelectorIndex, value);
		}

		[Ordinal(13)] 
		[RED("selector")] 
		public wCHandle<inkWidget> Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(14)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public characterCreationBodyMorphOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
