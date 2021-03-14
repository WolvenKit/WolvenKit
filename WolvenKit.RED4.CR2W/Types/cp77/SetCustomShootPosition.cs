using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCustomShootPosition : AIbehaviortaskScript
	{
		private Vector3 _offset;
		private Vector3 _fxOffset;
		private CFloat _lockTimer;
		private gameFxResource _landIndicatorFX;
		private CBool _keepsAcquiring;
		private CBool _shootToTheGround;
		private CFloat _predictionTime;
		private wCHandle<gamedataAIActionTarget_Record> _refOwner;
		private wCHandle<gamedataAIActionTarget_Record> _refAIActionTarget;
		private wCHandle<gamedataAIActionTarget_Record> _refCustomWorldPositionTarget;
		private Vector4 _ownerPosition;
		private Vector4 _targetPosition;
		private Vector4 _fxPosition;
		private wCHandle<gameObject> _target;
		private wCHandle<gameObject> _owner;
		private CHandle<gameFxInstance> _fxInstance;
		private CBool _targetAcquired;
		private CFloat _startTime;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fxOffset")] 
		public Vector3 FxOffset
		{
			get
			{
				if (_fxOffset == null)
				{
					_fxOffset = (Vector3) CR2WTypeManager.Create("Vector3", "fxOffset", cr2w, this);
				}
				return _fxOffset;
			}
			set
			{
				if (_fxOffset == value)
				{
					return;
				}
				_fxOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lockTimer")] 
		public CFloat LockTimer
		{
			get
			{
				if (_lockTimer == null)
				{
					_lockTimer = (CFloat) CR2WTypeManager.Create("Float", "lockTimer", cr2w, this);
				}
				return _lockTimer;
			}
			set
			{
				if (_lockTimer == value)
				{
					return;
				}
				_lockTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get
			{
				if (_landIndicatorFX == null)
				{
					_landIndicatorFX = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "landIndicatorFX", cr2w, this);
				}
				return _landIndicatorFX;
			}
			set
			{
				if (_landIndicatorFX == value)
				{
					return;
				}
				_landIndicatorFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("keepsAcquiring")] 
		public CBool KeepsAcquiring
		{
			get
			{
				if (_keepsAcquiring == null)
				{
					_keepsAcquiring = (CBool) CR2WTypeManager.Create("Bool", "keepsAcquiring", cr2w, this);
				}
				return _keepsAcquiring;
			}
			set
			{
				if (_keepsAcquiring == value)
				{
					return;
				}
				_keepsAcquiring = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shootToTheGround")] 
		public CBool ShootToTheGround
		{
			get
			{
				if (_shootToTheGround == null)
				{
					_shootToTheGround = (CBool) CR2WTypeManager.Create("Bool", "shootToTheGround", cr2w, this);
				}
				return _shootToTheGround;
			}
			set
			{
				if (_shootToTheGround == value)
				{
					return;
				}
				_shootToTheGround = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get
			{
				if (_predictionTime == null)
				{
					_predictionTime = (CFloat) CR2WTypeManager.Create("Float", "predictionTime", cr2w, this);
				}
				return _predictionTime;
			}
			set
			{
				if (_predictionTime == value)
				{
					return;
				}
				_predictionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("refOwner")] 
		public wCHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get
			{
				if (_refOwner == null)
				{
					_refOwner = (wCHandle<gamedataAIActionTarget_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionTarget_Record", "refOwner", cr2w, this);
				}
				return _refOwner;
			}
			set
			{
				if (_refOwner == value)
				{
					return;
				}
				_refOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("refAIActionTarget")] 
		public wCHandle<gamedataAIActionTarget_Record> RefAIActionTarget
		{
			get
			{
				if (_refAIActionTarget == null)
				{
					_refAIActionTarget = (wCHandle<gamedataAIActionTarget_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionTarget_Record", "refAIActionTarget", cr2w, this);
				}
				return _refAIActionTarget;
			}
			set
			{
				if (_refAIActionTarget == value)
				{
					return;
				}
				_refAIActionTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("refCustomWorldPositionTarget")] 
		public wCHandle<gamedataAIActionTarget_Record> RefCustomWorldPositionTarget
		{
			get
			{
				if (_refCustomWorldPositionTarget == null)
				{
					_refCustomWorldPositionTarget = (wCHandle<gamedataAIActionTarget_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionTarget_Record", "refCustomWorldPositionTarget", cr2w, this);
				}
				return _refCustomWorldPositionTarget;
			}
			set
			{
				if (_refCustomWorldPositionTarget == value)
				{
					return;
				}
				_refCustomWorldPositionTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get
			{
				if (_ownerPosition == null)
				{
					_ownerPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ownerPosition", cr2w, this);
				}
				return _ownerPosition;
			}
			set
			{
				if (_ownerPosition == value)
				{
					return;
				}
				_ownerPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fxPosition")] 
		public Vector4 FxPosition
		{
			get
			{
				if (_fxPosition == null)
				{
					_fxPosition = (Vector4) CR2WTypeManager.Create("Vector4", "fxPosition", cr2w, this);
				}
				return _fxPosition;
			}
			set
			{
				if (_fxPosition == value)
				{
					return;
				}
				_fxPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get
			{
				if (_fxInstance == null)
				{
					_fxInstance = (CHandle<gameFxInstance>) CR2WTypeManager.Create("handle:gameFxInstance", "fxInstance", cr2w, this);
				}
				return _fxInstance;
			}
			set
			{
				if (_fxInstance == value)
				{
					return;
				}
				_fxInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get
			{
				if (_targetAcquired == null)
				{
					_targetAcquired = (CBool) CR2WTypeManager.Create("Bool", "targetAcquired", cr2w, this);
				}
				return _targetAcquired;
			}
			set
			{
				if (_targetAcquired == value)
				{
					return;
				}
				_targetAcquired = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		public SetCustomShootPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
