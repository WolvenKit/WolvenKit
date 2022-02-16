using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorInventoryItemData : WrappedInventoryItemData
	{
		[Ordinal(5)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("IsDLCAddedActiveItem")] 
		public CBool IsDLCAddedActiveItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
