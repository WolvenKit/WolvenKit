using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipStatBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonBar")] 
		public inkWidgetReference ComparisonBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("overflow")] 
		public inkTextWidgetReference Overflow
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("comparisonArrow")] 
		public inkWidgetReference ComparisonArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("separators")] 
		public inkWidgetReference Separators
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("barAnimProxy")] 
		public CHandle<inkanimProxy> BarAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("diffBarAnimProxy")] 
		public CHandle<inkanimProxy> DiffBarAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("betterColor")] 
		public HDRColor BetterColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(12)] 
		[RED("worseColor")] 
		public HDRColor WorseColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(13)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public NewItemTooltipStatBarController()
		{
			Background = new inkWidgetReference();
			Bar = new inkWidgetReference();
			ComparisonBar = new inkWidgetReference();
			StatName = new inkTextWidgetReference();
			Overflow = new inkTextWidgetReference();
			StatValue = new inkTextWidgetReference();
			ComparisonArrow = new inkWidgetReference();
			Separators = new inkWidgetReference();
			BetterColor = new HDRColor();
			WorseColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
