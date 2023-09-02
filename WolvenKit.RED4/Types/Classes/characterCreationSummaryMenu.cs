using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationSummaryMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("backstoryTitle")] 
		public inkTextWidgetReference BackstoryTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("backstoryIcon")] 
		public inkImageWidgetReference BackstoryIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("backstory")] 
		public inkTextWidgetReference Backstory
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("difficulty")] 
		public inkTextWidgetReference Difficulty
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("attributeBodyValue")] 
		public inkTextWidgetReference AttributeBodyValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("attributeIntelligenceValue")] 
		public inkTextWidgetReference AttributeIntelligenceValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("attributeReflexesValue")] 
		public inkTextWidgetReference AttributeReflexesValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("attributeTechnicalAbilityValue")] 
		public inkTextWidgetReference AttributeTechnicalAbilityValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("attributeCoolValue")] 
		public inkTextWidgetReference AttributeCoolValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("glitchBtn")] 
		public inkWidgetReference GlitchBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("loadingAnimationProxy")] 
		public CHandle<inkanimProxy> LoadingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("loadingFinished")] 
		public CBool LoadingFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("glitchClicks")] 
		public CInt32 GlitchClicks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public characterCreationSummaryMenu()
		{
			BackstoryTitle = new inkTextWidgetReference();
			BackstoryIcon = new inkImageWidgetReference();
			Backstory = new inkTextWidgetReference();
			Difficulty = new inkTextWidgetReference();
			AttributeBodyValue = new inkTextWidgetReference();
			AttributeIntelligenceValue = new inkTextWidgetReference();
			AttributeReflexesValue = new inkTextWidgetReference();
			AttributeTechnicalAbilityValue = new inkTextWidgetReference();
			AttributeCoolValue = new inkTextWidgetReference();
			PreviousPageBtn = new inkWidgetReference();
			GlitchBtn = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
