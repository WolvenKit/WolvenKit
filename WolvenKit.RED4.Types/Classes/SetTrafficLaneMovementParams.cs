using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		private CString _movementType;
		private CEnum<gameFearStage> _fearStage;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CString MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("fearStage")] 
		public CEnum<gameFearStage> FearStage
		{
			get => GetProperty(ref _fearStage);
			set => SetProperty(ref _fearStage, value);
		}
	}
}
