using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFSMTransitionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		[Ordinal(0)] 
		[RED("inState")] 
		public CUInt16 InState
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("outState")] 
		public CUInt16 OutState
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("evaluationOrder")] 
		public CInt32 EvaluationOrder
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("instantConditions")] 
		public CArray<CHandle<AIbehaviorInstantConditionDefinition>> InstantConditions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorInstantConditionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorInstantConditionDefinition>>>(value);
		}

		[Ordinal(4)] 
		[RED("monitorConditions")] 
		public CArray<CHandle<AIbehaviorMonitorConditionDefinition>> MonitorConditions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorMonitorConditionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorMonitorConditionDefinition>>>(value);
		}

		[Ordinal(5)] 
		[RED("eventConditions")] 
		public CArray<CHandle<AIbehaviorEventConditionDefinition>> EventConditions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorEventConditionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorEventConditionDefinition>>>(value);
		}

		[Ordinal(6)] 
		[RED("passiveConditions")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> PassiveConditions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorExpressionSocket>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorExpressionSocket>>>(value);
		}

		public AIbehaviorFSMTransitionDefinition()
		{
			InstantConditions = new();
			MonitorConditions = new();
			EventConditions = new();
			PassiveConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
