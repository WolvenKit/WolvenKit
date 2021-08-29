using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorHubMenuChanged : redEvent
	{
		private CEnum<HubVendorMenuItems> _item;

		[Ordinal(0)] 
		[RED("item")] 
		public CEnum<HubVendorMenuItems> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}
	}
}
