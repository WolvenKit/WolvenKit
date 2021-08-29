using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficIntersectionManagerControllerPS : MasterControllerPS
	{
		private CEnum<worldTrafficLightColor> _trafficLightStatus;

		[Ordinal(105)] 
		[RED("trafficLightStatus")] 
		public CEnum<worldTrafficLightColor> TrafficLightStatus
		{
			get => GetProperty(ref _trafficLightStatus);
			set => SetProperty(ref _trafficLightStatus, value);
		}
	}
}
