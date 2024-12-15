using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleColorSelectorPointerDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pointerRoot")] 
		public inkWidgetReference PointerRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("pointerCircleRadius")] 
		public CFloat PointerCircleRadius
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
		[RED("paintOnSelection")] 
		public CBool PaintOnSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("partToPaint")] 
		public inkWidgetReference PartToPaint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public vehicleColorSelectorPointerDef()
		{
			PointerRoot = new inkWidgetReference();
			PartToPaint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
