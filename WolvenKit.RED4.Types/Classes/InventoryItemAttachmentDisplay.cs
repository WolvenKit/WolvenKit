using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemAttachmentDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("QualityRootRef")] 
		public inkWidgetReference QualityRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ShapeRef")] 
		public inkWidgetReference ShapeRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("BorderRef")] 
		public inkWidgetReference BorderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public InventoryItemAttachmentDisplay()
		{
			QualityRootRef = new();
			ShapeRef = new();
			BorderRef = new();
			MarkedStateName = "Marked";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
