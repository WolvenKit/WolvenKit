using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkMenuTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("titleContainer")] 
		public inkWidgetReference TitleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("typeContainer")] 
		public inkWidgetReference TypeContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("typeText")] 
		public inkTextWidgetReference TypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("desc1Container")] 
		public inkWidgetReference Desc1Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("desc2Container")] 
		public inkWidgetReference Desc2Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("desc2TextNextLevel")] 
		public inkTextWidgetReference Desc2TextNextLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("desc2TextNextLevelDesc")] 
		public inkTextWidgetReference Desc2TextNextLevelDesc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("holdToUpgrade")] 
		public inkWidgetReference HoldToUpgrade
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("openPerkScreen")] 
		public inkWidgetReference OpenPerkScreen
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("videoContainerWidget")] 
		public inkWidgetReference VideoContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get => GetPropertyValue<CHandle<BasePerksMenuTooltipData>>();
			set => SetPropertyValue<CHandle<BasePerksMenuTooltipData>>(value);
		}

		[Ordinal(17)] 
		[RED("maxProficiencyLevel")] 
		public CInt32 MaxProficiencyLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PerkMenuTooltipController()
		{
			TitleContainer = new();
			TitleText = new();
			TypeContainer = new();
			TypeText = new();
			Desc1Container = new();
			Desc1Text = new();
			Desc2Container = new();
			Desc2Text = new();
			Desc2TextNextLevel = new();
			Desc2TextNextLevelDesc = new();
			HoldToUpgrade = new();
			OpenPerkScreen = new();
			VideoContainerWidget = new();
			VideoWidget = new();
			MaxProficiencyLevel = 20;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
