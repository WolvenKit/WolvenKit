using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTrafficLaneSpanInfo : CVariable
	{
		private worldTrafficLaneUID _laneId;
		private CFloat _laneX1;
		private CFloat _laneX2;

		[Ordinal(0)] 
		[RED("laneId")] 
		public worldTrafficLaneUID LaneId
		{
			get
			{
				if (_laneId == null)
				{
					_laneId = (worldTrafficLaneUID) CR2WTypeManager.Create("worldTrafficLaneUID", "laneId", cr2w, this);
				}
				return _laneId;
			}
			set
			{
				if (_laneId == value)
				{
					return;
				}
				_laneId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public gameTrafficLaneSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
