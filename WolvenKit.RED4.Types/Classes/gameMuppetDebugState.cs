using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetDebugState : ISerializable
	{
		private CArray<gameMuppetStateComparisonReport> _comparisonReports;
		private CUInt32 _comparisonReportIndex;
		private CArray<gameMuppetSubStepData> _subStepsData;

		[Ordinal(0)] 
		[RED("comparisonReports")] 
		public CArray<gameMuppetStateComparisonReport> ComparisonReports
		{
			get => GetProperty(ref _comparisonReports);
			set => SetProperty(ref _comparisonReports, value);
		}

		[Ordinal(1)] 
		[RED("comparisonReportIndex")] 
		public CUInt32 ComparisonReportIndex
		{
			get => GetProperty(ref _comparisonReportIndex);
			set => SetProperty(ref _comparisonReportIndex, value);
		}

		[Ordinal(2)] 
		[RED("subStepsData")] 
		public CArray<gameMuppetSubStepData> SubStepsData
		{
			get => GetProperty(ref _subStepsData);
			set => SetProperty(ref _subStepsData, value);
		}
	}
}
