using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledCrowdTrafficData : CVariable
	{
		private CArray<worldTrafficLaneUID> _trafficLaneUIDs;

		[Ordinal(0)] 
		[RED("trafficLaneUIDs")] 
		public CArray<worldTrafficLaneUID> TrafficLaneUIDs
		{
			get
			{
				if (_trafficLaneUIDs == null)
				{
					_trafficLaneUIDs = (CArray<worldTrafficLaneUID>) CR2WTypeManager.Create("array:worldTrafficLaneUID", "trafficLaneUIDs", cr2w, this);
				}
				return _trafficLaneUIDs;
			}
			set
			{
				if (_trafficLaneUIDs == value)
				{
					return;
				}
				_trafficLaneUIDs = value;
				PropertySet(this);
			}
		}

		public gameCompiledCrowdTrafficData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
