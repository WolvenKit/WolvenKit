using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJoinTrafficNPCContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startPosition")] 
		public Vector3 StartPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("threatPosition")] 
		public Vector3 ThreatPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CFloat ThreatRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("checkRoadIntersection")] 
		public CBool CheckRoadIntersection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("usePreviousPosition")] 
		public CBool UsePreviousPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJoinTrafficNPCContext()
		{
			StartPosition = new Vector3 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			ThreatPosition = new Vector3 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			CheckRoadIntersection = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
