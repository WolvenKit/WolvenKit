using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TvDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("globalTVChannelSlot")] 
		public inkBasePanelWidgetReference GlobalTVChannelSlot
		{
			get => GetPropertyValue<inkBasePanelWidgetReference>();
			set => SetPropertyValue<inkBasePanelWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("messageBackgroundWidget")] 
		public inkLeafWidgetReference MessageBackgroundWidget
		{
			get => GetPropertyValue<inkLeafWidgetReference>();
			set => SetPropertyValue<inkLeafWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("globalTVChannel")] 
		public CWeakHandle<inkWidget> GlobalTVChannel
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("activeVideo")] 
		public redResourceReferenceScriptToken ActiveVideo
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public TvDeviceWidgetController()
		{
			VideoWidget = new();
			GlobalTVChannelSlot = new();
			MessegeWidget = new();
			MessageBackgroundWidget = new();
			ActiveVideo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
