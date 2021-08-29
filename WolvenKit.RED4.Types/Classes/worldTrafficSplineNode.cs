using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficSplineNode : worldTrafficSourceNode
	{
		private CEnum<worldTrafficSplineNodeUsage> _usage;
		private CFloat _maxSlotMaxSpeed;
		private CFloat _width;
		private CFloat _pathSamplingDistance;
		private CBool _bidirectional;
		private CFloat _autoConnectionRange;
		private CArray<CName> _markings;
		private CArray<worldTrafficLaneExitDefinition> _outLanes;
		private CArray<worldTrafficLightDefinition> _lights;
		private CBool _neverDeadEnd;
		private CBool _trafficDisabled;
		private CFloat _laneSamplingAngle;

		[Ordinal(9)] 
		[RED("usage")] 
		public CEnum<worldTrafficSplineNodeUsage> Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(10)] 
		[RED("maxSlotMaxSpeed")] 
		public CFloat MaxSlotMaxSpeed
		{
			get => GetProperty(ref _maxSlotMaxSpeed);
			set => SetProperty(ref _maxSlotMaxSpeed, value);
		}

		[Ordinal(11)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(12)] 
		[RED("pathSamplingDistance")] 
		public CFloat PathSamplingDistance
		{
			get => GetProperty(ref _pathSamplingDistance);
			set => SetProperty(ref _pathSamplingDistance, value);
		}

		[Ordinal(13)] 
		[RED("bidirectional")] 
		public CBool Bidirectional
		{
			get => GetProperty(ref _bidirectional);
			set => SetProperty(ref _bidirectional, value);
		}

		[Ordinal(14)] 
		[RED("autoConnectionRange")] 
		public CFloat AutoConnectionRange
		{
			get => GetProperty(ref _autoConnectionRange);
			set => SetProperty(ref _autoConnectionRange, value);
		}

		[Ordinal(15)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetProperty(ref _markings);
			set => SetProperty(ref _markings, value);
		}

		[Ordinal(16)] 
		[RED("outLanes")] 
		public CArray<worldTrafficLaneExitDefinition> OutLanes
		{
			get => GetProperty(ref _outLanes);
			set => SetProperty(ref _outLanes, value);
		}

		[Ordinal(17)] 
		[RED("lights")] 
		public CArray<worldTrafficLightDefinition> Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}

		[Ordinal(18)] 
		[RED("neverDeadEnd")] 
		public CBool NeverDeadEnd
		{
			get => GetProperty(ref _neverDeadEnd);
			set => SetProperty(ref _neverDeadEnd, value);
		}

		[Ordinal(19)] 
		[RED("trafficDisabled")] 
		public CBool TrafficDisabled
		{
			get => GetProperty(ref _trafficDisabled);
			set => SetProperty(ref _trafficDisabled, value);
		}

		[Ordinal(20)] 
		[RED("laneSamplingAngle")] 
		public CFloat LaneSamplingAngle
		{
			get => GetProperty(ref _laneSamplingAngle);
			set => SetProperty(ref _laneSamplingAngle, value);
		}
	}
}
