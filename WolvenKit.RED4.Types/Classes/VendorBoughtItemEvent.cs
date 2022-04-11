using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorBoughtItemEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameItemID> Items
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public VendorBoughtItemEvent()
		{
			Items = new();
		}
	}
}
