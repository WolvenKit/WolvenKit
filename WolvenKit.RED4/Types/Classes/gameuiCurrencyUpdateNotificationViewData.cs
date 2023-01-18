using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCurrencyUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("diff")] 
		public CInt32 Diff
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiCurrencyUpdateNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
