using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIPatrolPathParameters : IScriptable
	{
		private NodeRef _path;
		private CEnum<moveMovementType> _movementType;
		private CBool _enterClosest;
		private CBool _patrolWithWeapon;
		private CBool _isBackAndForth;
		private CBool _isInfinite;
		private CUInt32 _numberOfLoops;
		private CBool _sortPatrolPoints;
		private TweakDBID _patrolAction;

		[Ordinal(0)] 
		[RED("path")] 
		public NodeRef Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(2)] 
		[RED("enterClosest")] 
		public CBool EnterClosest
		{
			get => GetProperty(ref _enterClosest);
			set => SetProperty(ref _enterClosest, value);
		}

		[Ordinal(3)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetProperty(ref _patrolWithWeapon);
			set => SetProperty(ref _patrolWithWeapon, value);
		}

		[Ordinal(4)] 
		[RED("isBackAndForth")] 
		public CBool IsBackAndForth
		{
			get => GetProperty(ref _isBackAndForth);
			set => SetProperty(ref _isBackAndForth, value);
		}

		[Ordinal(5)] 
		[RED("isInfinite")] 
		public CBool IsInfinite
		{
			get => GetProperty(ref _isInfinite);
			set => SetProperty(ref _isInfinite, value);
		}

		[Ordinal(6)] 
		[RED("numberOfLoops")] 
		public CUInt32 NumberOfLoops
		{
			get => GetProperty(ref _numberOfLoops);
			set => SetProperty(ref _numberOfLoops, value);
		}

		[Ordinal(7)] 
		[RED("sortPatrolPoints")] 
		public CBool SortPatrolPoints
		{
			get => GetProperty(ref _sortPatrolPoints);
			set => SetProperty(ref _sortPatrolPoints, value);
		}

		[Ordinal(8)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get => GetProperty(ref _patrolAction);
			set => SetProperty(ref _patrolAction, value);
		}

		public AIPatrolPathParameters()
		{
			_enterClosest = true;
			_isInfinite = true;
			_numberOfLoops = 1;
			_sortPatrolPoints = true;
			_patrolAction = new() { Value = 144011363920 };
		}
	}
}
