using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationVoiceOverSwitcher : CharacterCreationBodyMorphBaseOption
	{
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
		[RED("warningLabel")] 
		public inkTextWidgetReference WarningLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("male")] 
		public CString Male
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("female")] 
		public CString Female
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("translationAnimationCtrl")] 
		public CWeakHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>(value);
		}

		[Ordinal(13)] 
		[RED("selector")] 
		public CWeakHandle<inkWidget> Selector
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public characterCreationVoiceOverSwitcher()
		{
			SelectedLabel = new inkTextWidgetReference();
			SelectorNextBtn = new inkWidgetReference();
			SelectorPrevBtn = new inkWidgetReference();
			WarningLabel = new inkTextWidgetReference();
			SelectorTexture = new inkImageWidgetReference();
			ArrowsTexture = new inkImageWidgetReference();
			OptionSwitchHint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
