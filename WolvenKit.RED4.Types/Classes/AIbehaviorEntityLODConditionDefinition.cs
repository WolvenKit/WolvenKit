using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("any")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> Any
		{
			get => GetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>();
			set => SetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>(value);
		}

		[Ordinal(2)] 
		[RED("all")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> All
		{
			get => GetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>();
			set => SetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>(value);
		}

		[Ordinal(3)] 
		[RED("none")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> None
		{
			get => GetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>();
			set => SetPropertyValue<CArray<CEnum<AIbehaviorEntityLODConditions>>>(value);
		}

		public AIbehaviorEntityLODConditionDefinition()
		{
			Any = new();
			All = new();
			None = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
