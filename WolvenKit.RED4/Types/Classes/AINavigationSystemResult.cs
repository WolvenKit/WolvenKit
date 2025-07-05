using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AINavigationSystemResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasFailed")] 
		public CBool HasFailed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hasPath")] 
		public CBool HasPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hasClosestPointOnNavmesh")] 
		public CBool HasClosestPointOnNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasClosestReachablePoint")] 
		public CBool HasClosestReachablePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("lastSourcePosition")] 
		public WorldPosition LastSourcePosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(5)] 
		[RED("lastTargetPosition")] 
		public WorldPosition LastTargetPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(6)] 
		[RED("adjustedTargetPosition")] 
		public WorldPosition AdjustedTargetPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(7)] 
		[RED("closestPointOnNavmesh")] 
		public WorldPosition ClosestPointOnNavmesh
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(8)] 
		[RED("closestReachablePoint")] 
		public WorldPosition ClosestReachablePoint
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		public AINavigationSystemResult()
		{
			LastSourcePosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			LastTargetPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			AdjustedTargetPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			ClosestPointOnNavmesh = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			ClosestReachablePoint = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
