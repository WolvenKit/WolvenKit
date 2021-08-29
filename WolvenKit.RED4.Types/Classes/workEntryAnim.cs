using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workEntryAnim : workIEntry
	{
		private CName _animName;
		private CName _idleAnim;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _orientationType;
		private CBool _isSynchronized;
		private CName _slotName;
		private Transform _syncOffset;
		private CFloat _blendOutTime;

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
		[RED("orientationType")] 
		public CEnum<moveMovementOrientationType> OrientationType
		{
			get => GetProperty(ref _orientationType);
			set => SetProperty(ref _orientationType, value);
		}

		[Ordinal(6)] 
		[RED("isSynchronized")] 
		public CBool IsSynchronized
		{
			get => GetProperty(ref _isSynchronized);
			set => SetProperty(ref _isSynchronized, value);
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(8)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get => GetProperty(ref _syncOffset);
			set => SetProperty(ref _syncOffset, value);
		}

		[Ordinal(9)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}
	}
}
