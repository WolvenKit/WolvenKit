using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workExitAnim : workIEntry
	{
		private CName _animName;
		private CName _idleAnim;
		private CEnum<moveMovementType> _movementType;
		private CBool _isSynchronized;
		private CBool _stayOnNavmesh;
		private CBool _snapZToNavmesh;
		private CName _slotName;
		private Transform _syncOffset;
		private CBool _disableRandomExit;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get => GetProperty(ref _idleAnim);
			set => SetProperty(ref _idleAnim, value);
		}

		[Ordinal(4)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(5)] 
		[RED("isSynchronized")] 
		public CBool IsSynchronized
		{
			get => GetProperty(ref _isSynchronized);
			set => SetProperty(ref _isSynchronized, value);
		}

		[Ordinal(6)] 
		[RED("stayOnNavmesh")] 
		public CBool StayOnNavmesh
		{
			get => GetProperty(ref _stayOnNavmesh);
			set => SetProperty(ref _stayOnNavmesh, value);
		}

		[Ordinal(7)] 
		[RED("snapZToNavmesh")] 
		public CBool SnapZToNavmesh
		{
			get => GetProperty(ref _snapZToNavmesh);
			set => SetProperty(ref _snapZToNavmesh, value);
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(9)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get => GetProperty(ref _syncOffset);
			set => SetProperty(ref _syncOffset, value);
		}

		[Ordinal(10)] 
		[RED("disableRandomExit")] 
		public CBool DisableRandomExit
		{
			get => GetProperty(ref _disableRandomExit);
			set => SetProperty(ref _disableRandomExit, value);
		}

		public workExitAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
