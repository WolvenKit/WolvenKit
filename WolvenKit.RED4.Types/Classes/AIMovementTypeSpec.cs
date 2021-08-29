using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMovementTypeSpec : RedBaseClass
	{
		private CBool _useNPCMovementParams;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(0)] 
		[RED("useNPCMovementParams")] 
		public CBool UseNPCMovementParams
		{
			get => GetProperty(ref _useNPCMovementParams);
			set => SetProperty(ref _useNPCMovementParams, value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}
	}
}
