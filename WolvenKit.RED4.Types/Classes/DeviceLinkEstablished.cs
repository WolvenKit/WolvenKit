using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceLinkEstablished : redEvent
	{
		[Ordinal(0)] 
		[RED("deviceLinkPS")] 
		public CWeakHandle<DeviceLinkComponentPS> DeviceLinkPS
		{
			get => GetPropertyValue<CWeakHandle<DeviceLinkComponentPS>>();
			set => SetPropertyValue<CWeakHandle<DeviceLinkComponentPS>>(value);
		}

		public DeviceLinkEstablished()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
