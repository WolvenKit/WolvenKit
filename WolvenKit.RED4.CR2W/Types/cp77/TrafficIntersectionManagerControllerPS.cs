using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficIntersectionManagerControllerPS : MasterControllerPS
	{
		private CEnum<worldTrafficLightColor> _trafficLightStatus;

		[Ordinal(104)] 
		[RED("trafficLightStatus")] 
		public CEnum<worldTrafficLightColor> TrafficLightStatus
		{
			get
			{
				if (_trafficLightStatus == null)
				{
					_trafficLightStatus = (CEnum<worldTrafficLightColor>) CR2WTypeManager.Create("worldTrafficLightColor", "trafficLightStatus", cr2w, this);
				}
				return _trafficLightStatus;
			}
			set
			{
				if (_trafficLightStatus == value)
				{
					return;
				}
				_trafficLightStatus = value;
				PropertySet(this);
			}
		}

		public TrafficIntersectionManagerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
