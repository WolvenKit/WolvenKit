using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneCrowdFragment : CVariable
	{
		private CStatic<worldDesiredSlotsCountInfo> _desiredSlotCountsPerTimePeriod;
		private CUInt32 _crowdCreationDataIndex;
		private CFloat _laneX1;
		private CFloat _laneX2;

		[Ordinal(0)] 
		[RED("desiredSlotCountsPerTimePeriod", 4)] 
		public CStatic<worldDesiredSlotsCountInfo> DesiredSlotCountsPerTimePeriod
		{
			get => GetProperty(ref _desiredSlotCountsPerTimePeriod);
			set => SetProperty(ref _desiredSlotCountsPerTimePeriod, value);
		}

		[Ordinal(1)] 
		[RED("crowdCreationDataIndex")] 
		public CUInt32 CrowdCreationDataIndex
		{
			get => GetProperty(ref _crowdCreationDataIndex);
			set => SetProperty(ref _crowdCreationDataIndex, value);
		}

		[Ordinal(2)] 
		[RED("laneX1")] 
		public CFloat LaneX1
		{
			get => GetProperty(ref _laneX1);
			set => SetProperty(ref _laneX1, value);
		}

		[Ordinal(3)] 
		[RED("laneX2")] 
		public CFloat LaneX2
		{
			get => GetProperty(ref _laneX2);
			set => SetProperty(ref _laneX2, value);
		}

		public worldTrafficLaneCrowdFragment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
