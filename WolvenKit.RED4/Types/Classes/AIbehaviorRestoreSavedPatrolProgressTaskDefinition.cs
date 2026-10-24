using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorRestoreSavedPatrolProgressTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("savedState")] 
		public CHandle<AIArgumentMapping> SavedState
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("destinationTangent")] 
		public CHandle<AIArgumentMapping> DestinationTangent
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorRestoreSavedPatrolProgressTaskDefinition()
		{
			Path = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolPathParameters" };
			SavedState = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gameSavedPatrolProgressState" };
			PatrolProgress = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gamePatrolSplineProgress" };
			DestinationPosition = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			DestinationTangent = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
