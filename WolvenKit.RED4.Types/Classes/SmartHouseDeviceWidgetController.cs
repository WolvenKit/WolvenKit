using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHouseDeviceWidgetController : DeviceWidgetControllerBase
	{
		private CWeakHandle<inkWidget> _interiorManagerSlot;

		[Ordinal(10)] 
		[RED("interiorManagerSlot")] 
		public CWeakHandle<inkWidget> InteriorManagerSlot
		{
			get => GetProperty(ref _interiorManagerSlot);
			set => SetProperty(ref _interiorManagerSlot, value);
		}
	}
}
