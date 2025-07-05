using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMovementTypeSpec : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("useNPCMovementParams")] 
		public CBool UseNPCMovementParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		public AIMovementTypeSpec()
		{
			UseNPCMovementParams = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
