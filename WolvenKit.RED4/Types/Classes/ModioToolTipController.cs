using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioToolTipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("TextToDisplay")] 
		public inkTextWidgetReference TextToDisplay
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("widthCanvas")] 
		public inkWidgetReference WidthCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ModioToolTipController()
		{
			TextToDisplay = new inkTextWidgetReference();
			WidthCanvas = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
