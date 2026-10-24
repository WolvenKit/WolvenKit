using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cyberwareCustomColorWheelDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parent")] 
		public inkWidgetReference Parent
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("wheelRadius")] 
		public CFloat WheelRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("selectionMargin")] 
		public CFloat SelectionMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("selectionFrame")] 
		public inkWidgetReference SelectionFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hoverFrame")] 
		public inkWidgetReference HoverFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("swipeRotationGroup")] 
		public inkWidgetReference SwipeRotationGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("swipeAnimationMask")] 
		public inkWidgetReference SwipeAnimationMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("color1Part")] 
		public inkWidgetReference Color1Part
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("color2Part")] 
		public inkWidgetReference Color2Part
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("color3Part")] 
		public inkWidgetReference Color3Part
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("color4Part")] 
		public inkWidgetReference Color4Part
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("color5Part")] 
		public inkWidgetReference Color5Part
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public cyberwareCustomColorWheelDef()
		{
			Parent = new inkWidgetReference();
			SelectionFrame = new inkWidgetReference();
			HoverFrame = new inkWidgetReference();
			SwipeRotationGroup = new inkWidgetReference();
			SwipeAnimationMask = new inkWidgetReference();
			Color1Part = new inkWidgetReference();
			Color2Part = new inkWidgetReference();
			Color3Part = new inkWidgetReference();
			Color4Part = new inkWidgetReference();
			Color5Part = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
