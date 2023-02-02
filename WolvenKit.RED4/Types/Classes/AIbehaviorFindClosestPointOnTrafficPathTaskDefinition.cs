using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("enterClosest")] 
		public CHandle<AIArgumentMapping> EnterClosest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("avoidedPosition")] 
		public CHandle<AIArgumentMapping> AvoidedPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("useThreatPosAsAvoidedPos")] 
		public CHandle<AIArgumentMapping> UseThreatPosAsAvoidedPos
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("avoidedPositionDistance")] 
		public CHandle<AIArgumentMapping> AvoidedPositionDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("usePreviousPosition")] 
		public CHandle<AIArgumentMapping> UsePreviousPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("checkRoadIntersection")] 
		public CHandle<AIArgumentMapping> CheckRoadIntersection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("pathDirection")] 
		public CHandle<AIArgumentMapping> PathDirection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
