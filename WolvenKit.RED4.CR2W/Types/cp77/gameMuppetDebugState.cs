using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetDebugState : ISerializable
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

		public gameMuppetDebugState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
