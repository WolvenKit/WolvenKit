using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetCustomShootPosition : AIbehaviortaskScript
	{
		private Vector3 _offset;
		private Vector3 _fxOffset;
		private CFloat _lockTimer;
		private gameFxResource _landIndicatorFX;
		private CBool _keepsAcquiring;
		private CBool _shootToTheGround;
		private CFloat _predictionTime;
		private CWeakHandle<gamedataAIActionTarget_Record> _refOwner;
		private CWeakHandle<gamedataAIActionTarget_Record> _refAIActionTarget;
		private CWeakHandle<gamedataAIActionTarget_Record> _refCustomWorldPositionTarget;
		private Vector4 _ownerPosition;
		private Vector4 _targetPosition;
		private Vector4 _fxPosition;
		private CWeakHandle<gameObject> _target;
		private CWeakHandle<gameObject> _owner;
		private CHandle<gameFxInstance> _fxInstance;
		private CBool _targetAcquired;
		private CFloat _startTime;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(1)] 
		[RED("fxOffset")] 
		public Vector3 FxOffset
		{
			get => GetProperty(ref _fxOffset);
			set => SetProperty(ref _fxOffset, value);
		}

		[Ordinal(2)] 
		[RED("lockTimer")] 
		public CFloat LockTimer
		{
			get => GetProperty(ref _lockTimer);
			set => SetProperty(ref _lockTimer, value);
		}

		[Ordinal(3)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetProperty(ref _landIndicatorFX);
			set => SetProperty(ref _landIndicatorFX, value);
		}

		[Ordinal(4)] 
		[RED("keepsAcquiring")] 
		public CBool KeepsAcquiring
		{
			get => GetProperty(ref _keepsAcquiring);
			set => SetProperty(ref _keepsAcquiring, value);
		}

		[Ordinal(5)] 
		[RED("shootToTheGround")] 
		public CBool ShootToTheGround
		{
			get => GetProperty(ref _shootToTheGround);
			set => SetProperty(ref _shootToTheGround, value);
		}

		[Ordinal(6)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get => GetProperty(ref _predictionTime);
			set => SetProperty(ref _predictionTime, value);
		}

		[Ordinal(7)] 
		[RED("refOwner")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get => GetProperty(ref _refOwner);
			set => SetProperty(ref _refOwner, value);
		}

		[Ordinal(8)] 
		[RED("refAIActionTarget")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefAIActionTarget
		{
			get => GetProperty(ref _refAIActionTarget);
			set => SetProperty(ref _refAIActionTarget, value);
		}

		[Ordinal(9)] 
		[RED("refCustomWorldPositionTarget")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefCustomWorldPositionTarget
		{
			get => GetProperty(ref _refCustomWorldPositionTarget);
			set => SetProperty(ref _refCustomWorldPositionTarget, value);
		}

		[Ordinal(10)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get => GetProperty(ref _ownerPosition);
			set => SetProperty(ref _ownerPosition, value);
		}

		[Ordinal(11)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(12)] 
		[RED("fxPosition")] 
		public Vector4 FxPosition
		{
			get => GetProperty(ref _fxPosition);
			set => SetProperty(ref _fxPosition, value);
		}

		[Ordinal(13)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(14)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(15)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetProperty(ref _fxInstance);
			set => SetProperty(ref _fxInstance, value);
		}

		[Ordinal(16)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetProperty(ref _targetAcquired);
			set => SetProperty(ref _targetAcquired, value);
		}

		[Ordinal(17)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}
	}
}
