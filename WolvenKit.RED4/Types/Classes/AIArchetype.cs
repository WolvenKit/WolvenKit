using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArchetype : CResource
	{
		[Ordinal(1)] 
		[RED("behaviorDefinition")] 
		public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition
		{
			get => GetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>();
			set => SetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>(value);
		}

		[Ordinal(2)] 
		[RED("movementParameters", 5)] 
		public CStatic<moveMovementParameters> MovementParameters
		{
			get => GetPropertyValue<CStatic<moveMovementParameters>>();
			set => SetPropertyValue<CStatic<moveMovementParameters>>(value);
		}

		public AIArchetype()
		{
			MovementParameters = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
