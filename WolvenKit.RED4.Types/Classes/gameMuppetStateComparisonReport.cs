using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetStateComparisonReport : RedBaseClass
	{
		private CUInt32 _frameID;
		private CArray<gameMuppetComparisonReportItem> _items;

		[Ordinal(0)] 
		[RED("frameID")] 
		public CUInt32 FrameID
		{
			get => GetProperty(ref _frameID);
			set => SetProperty(ref _frameID, value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameMuppetComparisonReportItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
