using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetStateComparisonReport : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frameID")] 
		public CUInt32 FrameID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameMuppetComparisonReportItem> Items
		{
			get => GetPropertyValue<CArray<gameMuppetComparisonReportItem>>();
			set => SetPropertyValue<CArray<gameMuppetComparisonReportItem>>(value);
		}

		public gameMuppetStateComparisonReport()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
