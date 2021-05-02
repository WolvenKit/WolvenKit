using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCrosswalkEvent : redEvent
	{
		private CEnum<worldTrafficLightColor> _trafficLightColor;
		private CEnum<worldTrafficLightColor> _oldTrafficLightColor;
		private CFloat _totalDistance;
		private CFloat _distanceLeft;

		[Ordinal(0)] 
		[RED("trafficLightColor")] 
		public CEnum<worldTrafficLightColor> TrafficLightColor
		{
			get => GetProperty(ref _trafficLightColor);
			set => SetProperty(ref _trafficLightColor, value);
		}

		[Ordinal(1)] 
		[RED("oldTrafficLightColor")] 
		public CEnum<worldTrafficLightColor> OldTrafficLightColor
		{
			get => GetProperty(ref _oldTrafficLightColor);
			set => SetProperty(ref _oldTrafficLightColor, value);
		}

		[Ordinal(2)] 
		[RED("totalDistance")] 
		public CFloat TotalDistance
		{
			get => GetProperty(ref _totalDistance);
			set => SetProperty(ref _totalDistance, value);
		}

		[Ordinal(3)] 
		[RED("distanceLeft")] 
		public CFloat DistanceLeft
		{
			get => GetProperty(ref _distanceLeft);
			set => SetProperty(ref _distanceLeft, value);
		}

		public gameinteractionsCrosswalkEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
