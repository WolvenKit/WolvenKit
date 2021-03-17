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
			get => GetProperty(ref _trafficLightStatus);
			set => SetProperty(ref _trafficLightStatus, value);
		}

		public TrafficIntersectionManagerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
