using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceLinkEstablished : redEvent
	{
		private CWeakHandle<DeviceLinkComponentPS> _deviceLinkPS;

		[Ordinal(0)] 
		[RED("deviceLinkPS")] 
		public CWeakHandle<DeviceLinkComponentPS> DeviceLinkPS
		{
			get => GetProperty(ref _deviceLinkPS);
			set => SetProperty(ref _deviceLinkPS, value);
		}
	}
}
