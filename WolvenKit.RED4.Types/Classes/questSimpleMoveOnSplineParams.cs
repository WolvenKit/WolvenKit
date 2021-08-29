using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSimpleMoveOnSplineParams : RedBaseClass
	{
		private CEnum<moveMovementType> _movementType;
		private CHandle<questUniversalRef> _facingTargetRef;
		private CBool _rotateEntityTowardsFacingTarget;
		private CBool _snapToTerrain;
		private CBool _useOffMeshLinkReservation;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetProperty(ref _facingTargetRef);
			set => SetProperty(ref _facingTargetRef, value);
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _rotateEntityTowardsFacingTarget);
			set => SetProperty(ref _rotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(3)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetProperty(ref _snapToTerrain);
			set => SetProperty(ref _snapToTerrain, value);
		}

		[Ordinal(4)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get => GetProperty(ref _useOffMeshLinkReservation);
			set => SetProperty(ref _useOffMeshLinkReservation, value);
		}
	}
}
