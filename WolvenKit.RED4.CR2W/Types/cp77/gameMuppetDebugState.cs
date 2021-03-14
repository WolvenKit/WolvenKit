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
			get
			{
				if (_comparisonReports == null)
				{
					_comparisonReports = (CArray<gameMuppetStateComparisonReport>) CR2WTypeManager.Create("array:gameMuppetStateComparisonReport", "comparisonReports", cr2w, this);
				}
				return _comparisonReports;
			}
			set
			{
				if (_comparisonReports == value)
				{
					return;
				}
				_comparisonReports = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comparisonReportIndex")] 
		public CUInt32 ComparisonReportIndex
		{
			get
			{
				if (_comparisonReportIndex == null)
				{
					_comparisonReportIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "comparisonReportIndex", cr2w, this);
				}
				return _comparisonReportIndex;
			}
			set
			{
				if (_comparisonReportIndex == value)
				{
					return;
				}
				_comparisonReportIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("subStepsData")] 
		public CArray<gameMuppetSubStepData> SubStepsData
		{
			get
			{
				if (_subStepsData == null)
				{
					_subStepsData = (CArray<gameMuppetSubStepData>) CR2WTypeManager.Create("array:gameMuppetSubStepData", "subStepsData", cr2w, this);
				}
				return _subStepsData;
			}
			set
			{
				if (_subStepsData == value)
				{
					return;
				}
				_subStepsData = value;
				PropertySet(this);
			}
		}

		public gameMuppetDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
