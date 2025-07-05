using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ControlledDeviceLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("deviceIcon")] 
		public CWeakHandle<inkImageWidget> DeviceIcon
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("nestIcon")] 
		public CWeakHandle<inkImageWidget> NestIcon
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("activeBg")] 
		public CWeakHandle<inkRectangleWidget> ActiveBg
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		public ControlledDeviceLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
