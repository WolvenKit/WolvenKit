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
			get
			{
				if (_desiredSlotCountsPerTimePeriod == null)
				{
					_desiredSlotCountsPerTimePeriod = (CStatic<worldDesiredSlotsCountInfo>) CR2WTypeManager.Create("static:4,worldDesiredSlotsCountInfo", "desiredSlotCountsPerTimePeriod", cr2w, this);
				}
				return _desiredSlotCountsPerTimePeriod;
			}
			set
			{
				if (_desiredSlotCountsPerTimePeriod == value)
				{
					return;
				}
				_desiredSlotCountsPerTimePeriod = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("crowdCreationDataIndex")] 
		public CUInt32 CrowdCreationDataIndex
		{
			get
			{
				if (_crowdCreationDataIndex == null)
				{
					_crowdCreationDataIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "crowdCreationDataIndex", cr2w, this);
				}
				return _crowdCreationDataIndex;
			}
			set
			{
				if (_crowdCreationDataIndex == value)
				{
					return;
				}
				_crowdCreationDataIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("laneX1")] 
		public CFloat LaneX1
		{
			get
			{
				if (_laneX1 == null)
				{
					_laneX1 = (CFloat) CR2WTypeManager.Create("Float", "laneX1", cr2w, this);
				}
				return _laneX1;
			}
			set
			{
				if (_laneX1 == value)
				{
					return;
				}
				_laneX1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("laneX2")] 
		public CFloat LaneX2
		{
			get
			{
				if (_laneX2 == null)
				{
					_laneX2 = (CFloat) CR2WTypeManager.Create("Float", "laneX2", cr2w, this);
				}
				return _laneX2;
			}
			set
			{
				if (_laneX2 == value)
				{
					return;
				}
				_laneX2 = value;
				PropertySet(this);
			}
		}

		public worldTrafficLaneCrowdFragment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
