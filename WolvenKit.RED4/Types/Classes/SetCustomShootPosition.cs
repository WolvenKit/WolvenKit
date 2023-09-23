using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetCustomShootPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("fxOffset")] 
		public Vector3 FxOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("lockTimer")] 
		public CFloat LockTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(4)] 
		[RED("keepsAcquiring")] 
		public CBool KeepsAcquiring
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("shootToTheGround")] 
		public CBool ShootToTheGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("waypointTag")] 
		public CName WaypointTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("refOwner")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("refAIActionTarget")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefAIActionTarget
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(10)] 
		[RED("refCustomWorldPositionTarget")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefCustomWorldPositionTarget
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(11)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(14)] 
		[RED("fxPosition")] 
		public Vector4 FxPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(15)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(16)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(17)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(18)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("shootPointPosition")] 
		public Vector4 ShootPointPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(21)] 
		[RED("targetsPosition")] 
		public CArray<Vector4> TargetsPosition
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public SetCustomShootPosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
