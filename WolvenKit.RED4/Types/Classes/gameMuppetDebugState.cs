using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetDebugState : ISerializable
	{
		[Ordinal(0)] 
		[RED("comparisonReports")] 
		public CArray<gameMuppetStateComparisonReport> ComparisonReports
		{
			get => GetPropertyValue<CArray<gameMuppetStateComparisonReport>>();
			set => SetPropertyValue<CArray<gameMuppetStateComparisonReport>>(value);
		}

		[Ordinal(1)] 
		[RED("comparisonReportIndex")] 
		public CUInt32 ComparisonReportIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("subStepsData")] 
		public CArray<gameMuppetSubStepData> SubStepsData
		{
			get => GetPropertyValue<CArray<gameMuppetSubStepData>>();
			set => SetPropertyValue<CArray<gameMuppetSubStepData>>(value);
		}

		public gameMuppetDebugState()
		{
			ComparisonReports = new();
			SubStepsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
