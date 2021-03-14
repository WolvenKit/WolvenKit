using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactionsData : animAnimFeature
	{
		private CInt32 _hitIntensity;
		private CInt32 _hitSource;
		private CInt32 _hitType;
		private CInt32 _hitBodyPart;
		private CInt32 _npcMovementSpeed;
		private CInt32 _hitDirection;
		private CInt32 _npcMovementDirection;
		private CInt32 _stance;
		private CInt32 _animVariation;
		private CBool _useInitialRotation;
		private Vector4 _hitDirectionWs;
		private CFloat _angleToAttack;
		private CFloat _initialRotationDuration;

		[Ordinal(0)] 
		[RED("hitIntensity")] 
		public CInt32 HitIntensity
		{
			get
			{
				if (_hitIntensity == null)
				{
					_hitIntensity = (CInt32) CR2WTypeManager.Create("Int32", "hitIntensity", cr2w, this);
				}
				return _hitIntensity;
			}
			set
			{
				if (_hitIntensity == value)
				{
					return;
				}
				_hitIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitSource")] 
		public CInt32 HitSource
		{
			get
			{
				if (_hitSource == null)
				{
					_hitSource = (CInt32) CR2WTypeManager.Create("Int32", "hitSource", cr2w, this);
				}
				return _hitSource;
			}
			set
			{
				if (_hitSource == value)
				{
					return;
				}
				_hitSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CInt32) CR2WTypeManager.Create("Int32", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get
			{
				if (_hitBodyPart == null)
				{
					_hitBodyPart = (CInt32) CR2WTypeManager.Create("Int32", "hitBodyPart", cr2w, this);
				}
				return _hitBodyPart;
			}
			set
			{
				if (_hitBodyPart == value)
				{
					return;
				}
				_hitBodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("npcMovementSpeed")] 
		public CInt32 NpcMovementSpeed
		{
			get
			{
				if (_npcMovementSpeed == null)
				{
					_npcMovementSpeed = (CInt32) CR2WTypeManager.Create("Int32", "npcMovementSpeed", cr2w, this);
				}
				return _npcMovementSpeed;
			}
			set
			{
				if (_npcMovementSpeed == value)
				{
					return;
				}
				_npcMovementSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hitDirection")] 
		public CInt32 HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (CInt32) CR2WTypeManager.Create("Int32", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("npcMovementDirection")] 
		public CInt32 NpcMovementDirection
		{
			get
			{
				if (_npcMovementDirection == null)
				{
					_npcMovementDirection = (CInt32) CR2WTypeManager.Create("Int32", "npcMovementDirection", cr2w, this);
				}
				return _npcMovementDirection;
			}
			set
			{
				if (_npcMovementDirection == value)
				{
					return;
				}
				_npcMovementDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get
			{
				if (_stance == null)
				{
					_stance = (CInt32) CR2WTypeManager.Create("Int32", "stance", cr2w, this);
				}
				return _stance;
			}
			set
			{
				if (_stance == value)
				{
					return;
				}
				_stance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CInt32) CR2WTypeManager.Create("Int32", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("useInitialRotation")] 
		public CBool UseInitialRotation
		{
			get
			{
				if (_useInitialRotation == null)
				{
					_useInitialRotation = (CBool) CR2WTypeManager.Create("Bool", "useInitialRotation", cr2w, this);
				}
				return _useInitialRotation;
			}
			set
			{
				if (_useInitialRotation == value)
				{
					return;
				}
				_useInitialRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hitDirectionWs")] 
		public Vector4 HitDirectionWs
		{
			get
			{
				if (_hitDirectionWs == null)
				{
					_hitDirectionWs = (Vector4) CR2WTypeManager.Create("Vector4", "hitDirectionWs", cr2w, this);
				}
				return _hitDirectionWs;
			}
			set
			{
				if (_hitDirectionWs == value)
				{
					return;
				}
				_hitDirectionWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("angleToAttack")] 
		public CFloat AngleToAttack
		{
			get
			{
				if (_angleToAttack == null)
				{
					_angleToAttack = (CFloat) CR2WTypeManager.Create("Float", "angleToAttack", cr2w, this);
				}
				return _angleToAttack;
			}
			set
			{
				if (_angleToAttack == value)
				{
					return;
				}
				_angleToAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("initialRotationDuration")] 
		public CFloat InitialRotationDuration
		{
			get
			{
				if (_initialRotationDuration == null)
				{
					_initialRotationDuration = (CFloat) CR2WTypeManager.Create("Float", "initialRotationDuration", cr2w, this);
				}
				return _initialRotationDuration;
			}
			set
			{
				if (_initialRotationDuration == value)
				{
					return;
				}
				_initialRotationDuration = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_HitReactionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
