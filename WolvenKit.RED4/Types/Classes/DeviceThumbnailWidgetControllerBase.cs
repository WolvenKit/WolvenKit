using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceThumbnailWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(29)] 
		[RED("deviceIconRef")] 
		public inkImageWidgetReference DeviceIconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("thumbnailAction")] 
		public CWeakHandle<ThumbnailUI> ThumbnailAction
		{
			get => GetPropertyValue<CWeakHandle<ThumbnailUI>>();
			set => SetPropertyValue<CWeakHandle<ThumbnailUI>>(value);
		}

		public DeviceThumbnailWidgetControllerBase()
		{
			DeviceIconRef = new inkImageWidgetReference();
			StatusNameWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
