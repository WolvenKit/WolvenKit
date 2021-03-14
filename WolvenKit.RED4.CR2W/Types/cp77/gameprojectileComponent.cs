using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileComponent : entIPlacedComponent
	{
		private CEnum<gameprojectileOnCollisionAction> _onCollisionAction;
		private CBool _useSweepCollision;
		private CBool _collisionsFilterClosest;
		private CFloat _sweepCollisionRadius;
		private Quaternion _rotationOffset;
		private CBool _deriveOwnerVelocity;
		private gameprojectileVelocityParams _derivedVelocityParams;
		private CHandle<physicsFilterData> _filterData;
		private raRef<worldEffect> _previewEffect;
		private raRef<worldEffect> _bouncePreviewEffect;
		private raRef<worldEffect> _explosionPreviewEffect;
		private CFloat _explosionPreviewTime;
		private gameEffectRef _gameEffectRef;

		[Ordinal(5)] 
		[RED("onCollisionAction")] 
		public CEnum<gameprojectileOnCollisionAction> OnCollisionAction
		{
			get
			{
				if (_onCollisionAction == null)
				{
					_onCollisionAction = (CEnum<gameprojectileOnCollisionAction>) CR2WTypeManager.Create("gameprojectileOnCollisionAction", "onCollisionAction", cr2w, this);
				}
				return _onCollisionAction;
			}
			set
			{
				if (_onCollisionAction == value)
				{
					return;
				}
				_onCollisionAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useSweepCollision")] 
		public CBool UseSweepCollision
		{
			get
			{
				if (_useSweepCollision == null)
				{
					_useSweepCollision = (CBool) CR2WTypeManager.Create("Bool", "useSweepCollision", cr2w, this);
				}
				return _useSweepCollision;
			}
			set
			{
				if (_useSweepCollision == value)
				{
					return;
				}
				_useSweepCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("collisionsFilterClosest")] 
		public CBool CollisionsFilterClosest
		{
			get
			{
				if (_collisionsFilterClosest == null)
				{
					_collisionsFilterClosest = (CBool) CR2WTypeManager.Create("Bool", "collisionsFilterClosest", cr2w, this);
				}
				return _collisionsFilterClosest;
			}
			set
			{
				if (_collisionsFilterClosest == value)
				{
					return;
				}
				_collisionsFilterClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sweepCollisionRadius")] 
		public CFloat SweepCollisionRadius
		{
			get
			{
				if (_sweepCollisionRadius == null)
				{
					_sweepCollisionRadius = (CFloat) CR2WTypeManager.Create("Float", "sweepCollisionRadius", cr2w, this);
				}
				return _sweepCollisionRadius;
			}
			set
			{
				if (_sweepCollisionRadius == value)
				{
					return;
				}
				_sweepCollisionRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get
			{
				if (_rotationOffset == null)
				{
					_rotationOffset = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotationOffset", cr2w, this);
				}
				return _rotationOffset;
			}
			set
			{
				if (_rotationOffset == value)
				{
					return;
				}
				_rotationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("deriveOwnerVelocity")] 
		public CBool DeriveOwnerVelocity
		{
			get
			{
				if (_deriveOwnerVelocity == null)
				{
					_deriveOwnerVelocity = (CBool) CR2WTypeManager.Create("Bool", "deriveOwnerVelocity", cr2w, this);
				}
				return _deriveOwnerVelocity;
			}
			set
			{
				if (_deriveOwnerVelocity == value)
				{
					return;
				}
				_deriveOwnerVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("derivedVelocityParams")] 
		public gameprojectileVelocityParams DerivedVelocityParams
		{
			get
			{
				if (_derivedVelocityParams == null)
				{
					_derivedVelocityParams = (gameprojectileVelocityParams) CR2WTypeManager.Create("gameprojectileVelocityParams", "derivedVelocityParams", cr2w, this);
				}
				return _derivedVelocityParams;
			}
			set
			{
				if (_derivedVelocityParams == value)
				{
					return;
				}
				_derivedVelocityParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("previewEffect")] 
		public raRef<worldEffect> PreviewEffect
		{
			get
			{
				if (_previewEffect == null)
				{
					_previewEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "previewEffect", cr2w, this);
				}
				return _previewEffect;
			}
			set
			{
				if (_previewEffect == value)
				{
					return;
				}
				_previewEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bouncePreviewEffect")] 
		public raRef<worldEffect> BouncePreviewEffect
		{
			get
			{
				if (_bouncePreviewEffect == null)
				{
					_bouncePreviewEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "bouncePreviewEffect", cr2w, this);
				}
				return _bouncePreviewEffect;
			}
			set
			{
				if (_bouncePreviewEffect == value)
				{
					return;
				}
				_bouncePreviewEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("explosionPreviewEffect")] 
		public raRef<worldEffect> ExplosionPreviewEffect
		{
			get
			{
				if (_explosionPreviewEffect == null)
				{
					_explosionPreviewEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "explosionPreviewEffect", cr2w, this);
				}
				return _explosionPreviewEffect;
			}
			set
			{
				if (_explosionPreviewEffect == value)
				{
					return;
				}
				_explosionPreviewEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("explosionPreviewTime")] 
		public CFloat ExplosionPreviewTime
		{
			get
			{
				if (_explosionPreviewTime == null)
				{
					_explosionPreviewTime = (CFloat) CR2WTypeManager.Create("Float", "explosionPreviewTime", cr2w, this);
				}
				return _explosionPreviewTime;
			}
			set
			{
				if (_explosionPreviewTime == value)
				{
					return;
				}
				_explosionPreviewTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get
			{
				if (_gameEffectRef == null)
				{
					_gameEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "gameEffectRef", cr2w, this);
				}
				return _gameEffectRef;
			}
			set
			{
				if (_gameEffectRef == value)
				{
					return;
				}
				_gameEffectRef = value;
				PropertySet(this);
			}
		}

		public gameprojectileComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
