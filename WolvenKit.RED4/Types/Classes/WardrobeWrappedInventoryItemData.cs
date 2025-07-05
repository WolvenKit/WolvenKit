using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeWrappedInventoryItemData : WrappedInventoryItemData
	{
		[Ordinal(11)] 
		[RED("AppearanceName")] 
		public CString AppearanceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public WardrobeWrappedInventoryItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
