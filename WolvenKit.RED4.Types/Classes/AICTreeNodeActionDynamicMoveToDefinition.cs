using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeActionDynamicMoveToDefinition : AICTreeNodeActionDefinition
	{
		private CEnum<moveMovementType> _moveType;
		private CFloat _tolerance;
		private CName _target;
		private CBool _keepDistance;

		[Ordinal(1)] 
		[RED("moveType")] 
		public CEnum<moveMovementType> MoveType
		{
			get => GetProperty(ref _moveType);
			set => SetProperty(ref _moveType, value);
		}

		[Ordinal(2)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetProperty(ref _tolerance);
			set => SetProperty(ref _tolerance, value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CName Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(4)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get => GetProperty(ref _keepDistance);
			set => SetProperty(ref _keepDistance, value);
		}
	}
}
