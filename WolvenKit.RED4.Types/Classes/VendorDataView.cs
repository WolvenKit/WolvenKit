using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorDataView : BackpackDataView
	{
		private CBool _isVendorGrid;
		private GameTime _openTime;

		[Ordinal(4)] 
		[RED("isVendorGrid")] 
		public CBool IsVendorGrid
		{
			get => GetProperty(ref _isVendorGrid);
			set => SetProperty(ref _isVendorGrid, value);
		}

		[Ordinal(5)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetProperty(ref _openTime);
			set => SetProperty(ref _openTime, value);
		}
	}
}
