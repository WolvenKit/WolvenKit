using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("activeBg")] 
		public CWeakHandle<inkRectangleWidget> ActiveBg
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}
	}
}
