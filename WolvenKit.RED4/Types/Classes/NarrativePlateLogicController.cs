using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NarrativePlateLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkWidgetReference TextWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("captionWidget")] 
		public inkWidgetReference CaptionWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public NarrativePlateLogicController()
		{
			TextWidget = new inkWidgetReference();
			CaptionWidget = new inkWidgetReference();
			Root = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
