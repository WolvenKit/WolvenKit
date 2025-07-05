using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLayout : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("padding")] 
		public inkMargin Padding
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(1)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(2)] 
		[RED("HAlign")] 
		public CEnum<inkEHorizontalAlign> HAlign
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(3)] 
		[RED("VAlign")] 
		public CEnum<inkEVerticalAlign> VAlign
		{
			get => GetPropertyValue<CEnum<inkEVerticalAlign>>();
			set => SetPropertyValue<CEnum<inkEVerticalAlign>>(value);
		}

		[Ordinal(4)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		[Ordinal(5)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(6)] 
		[RED("sizeRule")] 
		public CEnum<inkESizeRule> SizeRule
		{
			get => GetPropertyValue<CEnum<inkESizeRule>>();
			set => SetPropertyValue<CEnum<inkESizeRule>>(value);
		}

		[Ordinal(7)] 
		[RED("sizeCoefficient")] 
		public CFloat SizeCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkWidgetLayout()
		{
			Padding = new inkMargin();
			Margin = new inkMargin();
			AnchorPoint = new Vector2();
			SizeCoefficient = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
