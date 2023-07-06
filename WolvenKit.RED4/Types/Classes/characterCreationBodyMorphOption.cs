using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationBodyMorphOption : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("optionLabel")] 
		public inkTextWidgetReference OptionLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("selectedLabel")] 
		public inkTextWidgetReference SelectedLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("selectorNextBtn")] 
		public inkWidgetReference SelectorNextBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("selectorPrevBtn")] 
		public inkWidgetReference SelectorPrevBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("selectorOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> SelectorOption
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>(value);
		}

		[Ordinal(9)] 
		[RED("morphInfo")] 
		public CWeakHandle<gameuiMorphInfo> MorphInfo
		{
			get => GetPropertyValue<CWeakHandle<gameuiMorphInfo>>();
			set => SetPropertyValue<CWeakHandle<gameuiMorphInfo>>(value);
		}

		[Ordinal(10)] 
		[RED("appearanceInfo")] 
		public CWeakHandle<gameuiAppearanceInfo> AppearanceInfo
		{
			get => GetPropertyValue<CWeakHandle<gameuiAppearanceInfo>>();
			set => SetPropertyValue<CWeakHandle<gameuiAppearanceInfo>>(value);
		}

		[Ordinal(11)] 
		[RED("switcherInfo")] 
		public CWeakHandle<gameuiSwitcherInfo> SwitcherInfo
		{
			get => GetPropertyValue<CWeakHandle<gameuiSwitcherInfo>>();
			set => SetPropertyValue<CWeakHandle<gameuiSwitcherInfo>>(value);
		}

		[Ordinal(12)] 
		[RED("currSelectorIndex")] 
		public CInt32 CurrSelectorIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("selector")] 
		public CWeakHandle<inkWidget> Selector
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("isPrevOrNextBtnHoveredOver")] 
		public CBool IsPrevOrNextBtnHoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public characterCreationBodyMorphOption()
		{
			OptionLabel = new inkTextWidgetReference();
			SelectedLabel = new inkTextWidgetReference();
			SelectorNextBtn = new inkWidgetReference();
			SelectorPrevBtn = new inkWidgetReference();
			SelectorTexture = new inkImageWidgetReference();
			ArrowsTexture = new inkImageWidgetReference();
			OptionSwitchHint = new inkWidgetReference();
			CurrSelectorIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
