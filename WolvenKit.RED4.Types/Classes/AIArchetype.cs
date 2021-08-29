using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArchetype : CResource
	{
		private CHandle<AIbehaviorParameterizedBehavior> _behaviorDefinition;
		private CStatic<moveMovementParameters> _movementParameters;

		[Ordinal(1)] 
		[RED("behaviorDefinition")] 
		public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition
		{
			get => GetProperty(ref _behaviorDefinition);
			set => SetProperty(ref _behaviorDefinition, value);
		}

		[Ordinal(2)] 
		[RED("movementParameters", 5)] 
		public CStatic<moveMovementParameters> MovementParameters
		{
			get => GetProperty(ref _movementParameters);
			set => SetProperty(ref _movementParameters, value);
		}
	}
}
