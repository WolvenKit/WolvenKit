using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCurrencyUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		private CInt32 _diff;
		private CUInt32 _total;

		[Ordinal(5)] 
		[RED("diff")] 
		public CInt32 Diff
		{
			get => GetProperty(ref _diff);
			set => SetProperty(ref _diff, value);
		}

		[Ordinal(6)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get => GetProperty(ref _total);
			set => SetProperty(ref _total, value);
		}
	}
}
