using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("descText")] 
		public inkTextWidgetReference DescText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("additionalDescText")] 
		public inkTextWidgetReference AdditionalDescText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("lineBreak")] 
		public inkWidgetReference LineBreak
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ep1Icon")] 
		public inkImageWidgetReference Ep1Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("inputOpenJournalContainer")] 
		public inkCompoundWidgetReference InputOpenJournalContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("inputInteractContainer")] 
		public inkCompoundWidgetReference InputInteractContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("inputMoreInfoContainer")] 
		public inkCompoundWidgetReference InputMoreInfoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("threatLevelPanel")] 
		public inkWidgetReference ThreatLevelPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("threatLevelValue")] 
		public inkTextWidgetReference ThreatLevelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("fixerPanel")] 
		public inkWidgetReference FixerPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("linkImage")] 
		public inkImageWidgetReference LinkImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("gigProgress")] 
		public CFloat GigProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("barAnimationProxy")] 
		public CHandle<inkanimProxy> BarAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("gigBarCompletedText")] 
		public inkTextWidgetReference GigBarCompletedText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("gigBarTotalText")] 
		public inkTextWidgetReference GigBarTotalText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public WorldMapTooltipController()
		{
			TitleText = new inkTextWidgetReference();
			DescText = new inkTextWidgetReference();
			AdditionalDescText = new inkTextWidgetReference();
			LineBreak = new inkWidgetReference();
			Icon = new inkImageWidgetReference();
			Ep1Icon = new inkImageWidgetReference();
			InputOpenJournalContainer = new inkCompoundWidgetReference();
			InputInteractContainer = new inkCompoundWidgetReference();
			InputMoreInfoContainer = new inkCompoundWidgetReference();
			ThreatLevelPanel = new inkWidgetReference();
			ThreatLevelValue = new inkTextWidgetReference();
			FixerPanel = new inkWidgetReference();
			LinkImage = new inkImageWidgetReference();
			Bar = new inkWidgetReference();
			GigBarCompletedText = new inkTextWidgetReference();
			GigBarTotalText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
