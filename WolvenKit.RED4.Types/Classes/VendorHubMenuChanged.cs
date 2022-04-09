using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorHubMenuChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CEnum<HubVendorMenuItems> Item
		{
			get => GetPropertyValue<CEnum<HubVendorMenuItems>>();
			set => SetPropertyValue<CEnum<HubVendorMenuItems>>(value);
		}

		public VendorHubMenuChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
