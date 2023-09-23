using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerMapGameController : StatusScreenGameController
	{
		[Ordinal(10)] 
		[RED("mapPosition01")] 
		public inkWidgetReference MapPosition01
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("mapPosition02")] 
		public inkWidgetReference MapPosition02
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("mapPosition03")] 
		public inkWidgetReference MapPosition03
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public BunkerMapGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
