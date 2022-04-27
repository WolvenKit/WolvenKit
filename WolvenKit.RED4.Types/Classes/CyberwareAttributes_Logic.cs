using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareAttributes_Logic : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textValue")] 
		public inkTextWidgetReference TextValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tooltipRef")] 
		public inkWidgetReference TooltipRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("connectorRef")] 
		public inkWidgetReference ConnectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public CyberwareAttributes_Logic()
		{
			TextValue = new();
			ButtonRef = new();
			TooltipRef = new();
			ConnectorRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
