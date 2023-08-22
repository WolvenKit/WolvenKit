using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorLineOfSightClearConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("collisionFilters")] 
		public CArray<CName> CollisionFilters
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorLineOfSightClearConditionDefinition()
		{
			CollisionFilters = new();
			Offset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
