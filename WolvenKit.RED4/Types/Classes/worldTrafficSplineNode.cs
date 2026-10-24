using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficSplineNode : worldTrafficSourceNode
	{
		[Ordinal(7)] 
		[RED("usage")] 
		public CEnum<worldTrafficSplineNodeUsage> Usage
		{
			get => GetPropertyValue<CEnum<worldTrafficSplineNodeUsage>>();
			set => SetPropertyValue<CEnum<worldTrafficSplineNodeUsage>>(value);
		}

		[Ordinal(8)] 
		[RED("maxSlotMaxSpeed")] 
		public CFloat MaxSlotMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("pathSamplingDistance")] 
		public CFloat PathSamplingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("bidirectional")] 
		public CBool Bidirectional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("autoConnectionRange")] 
		public CFloat AutoConnectionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(14)] 
		[RED("outLanes")] 
		public CArray<worldTrafficLaneExitDefinition> OutLanes
		{
			get => GetPropertyValue<CArray<worldTrafficLaneExitDefinition>>();
			set => SetPropertyValue<CArray<worldTrafficLaneExitDefinition>>(value);
		}

		[Ordinal(15)] 
		[RED("lights")] 
		public CArray<worldTrafficLightDefinition> Lights
		{
			get => GetPropertyValue<CArray<worldTrafficLightDefinition>>();
			set => SetPropertyValue<CArray<worldTrafficLightDefinition>>(value);
		}

		[Ordinal(16)] 
		[RED("neverDeadEnd")] 
		public CBool NeverDeadEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("trafficDisabled")] 
		public CBool TrafficDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("laneSamplingAngle")] 
		public CFloat LaneSamplingAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("noAIDriving")] 
		public CBool NoAIDriving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("noAutodrive")] 
		public CBool NoAutodrive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldTrafficSplineNode()
		{
			MaxSlotMaxSpeed = 10.000000F;
			Width = 2.000000F;
			PathSamplingDistance = 2.000000F;
			AutoConnectionRange = 5.000000F;
			Markings = new();
			OutLanes = new();
			Lights = new();
			LaneSamplingAngle = 15.000000F;
			NoAIDriving = true;
			NoAutodrive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
