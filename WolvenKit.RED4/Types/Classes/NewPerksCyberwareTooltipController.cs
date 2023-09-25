using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksCyberwareTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("subTitle")] 
		public inkTextWidgetReference SubTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("subDescription")] 
		public inkTextWidgetReference SubDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("relicCost")] 
		public inkWidgetReference RelicCost
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(10)] 
		[RED("inputHints")] 
		public inkWidgetReference InputHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("buyHint")] 
		public inkWidgetReference BuyHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("sellHint")] 
		public inkWidgetReference SellHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("currentEntry")] 
		public CEnum<NewPerksCyberwareDetailsMenu> CurrentEntry
		{
			get => GetPropertyValue<CEnum<NewPerksCyberwareDetailsMenu>>();
			set => SetPropertyValue<CEnum<NewPerksCyberwareDetailsMenu>>(value);
		}

		[Ordinal(14)] 
		[RED("swipeOutAnim")] 
		public CHandle<inkanimProxy> SwipeOutAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("swipeInAnim")] 
		public CHandle<inkanimProxy> SwipeInAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<NewPerkTooltipData> Data
		{
			get => GetPropertyValue<CHandle<NewPerkTooltipData>>();
			set => SetPropertyValue<CHandle<NewPerkTooltipData>>(value);
		}

		[Ordinal(17)] 
		[RED("c_swipeLeftOut")] 
		public CName C_swipeLeftOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("c_swipeLeftIn")] 
		public CName C_swipeLeftIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("c_swipeRightOut")] 
		public CName C_swipeRightOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("c_swipeRightIn")] 
		public CName C_swipeRightIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NewPerksCyberwareTooltipController()
		{
			Title = new inkTextWidgetReference();
			SubTitle = new inkTextWidgetReference();
			Description = new inkTextWidgetReference();
			SubDescription = new inkTextWidgetReference();
			VideoWidget = new inkVideoWidgetReference();
			CornerContainer = new inkWidgetReference();
			RelicCost = new inkWidgetReference();
			Bars = new();
			InputHints = new inkWidgetReference();
			BuyHint = new inkWidgetReference();
			SellHint = new inkWidgetReference();
			C_swipeLeftOut = "espionage_central_swipe_left_out";
			C_swipeLeftIn = "espionage_central_swipe_left_in";
			C_swipeRightOut = "espionage_central_swipe_right_out";
			C_swipeRightIn = "espionage_central_swipe_right_in";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
