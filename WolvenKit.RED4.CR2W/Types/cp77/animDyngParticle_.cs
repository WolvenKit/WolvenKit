using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngParticle_ : CVariable
	{
		private CFloat _mass;
		private CFloat _damping;
		private CFloat _pullForceFactor;
		private CBool _isFree;
		private animTransformIndex _bone;
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;
		private Vector3 _collisionCapsuleAxisLS;
		private CEnum<animDyngParticleProjectionType> _projectionType;

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get
			{
				if (_damping == null)
				{
					_damping = (CFloat) CR2WTypeManager.Create("Float", "damping", cr2w, this);
				}
				return _damping;
			}
			set
			{
				if (_damping == value)
				{
					return;
				}
				_damping = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get
			{
				if (_pullForceFactor == null)
				{
					_pullForceFactor = (CFloat) CR2WTypeManager.Create("Float", "pullForceFactor", cr2w, this);
				}
				return _pullForceFactor;
			}
			set
			{
				if (_pullForceFactor == value)
				{
					return;
				}
				_pullForceFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get
			{
				if (_isFree == null)
				{
					_isFree = (CBool) CR2WTypeManager.Create("Bool", "isFree", cr2w, this);
				}
				return _isFree;
			}
			set
			{
				if (_isFree == value)
				{
					return;
				}
				_isFree = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone", cr2w, this);
				}
				return _bone;
			}
			set
			{
				if (_bone == value)
				{
					return;
				}
				_bone = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get
			{
				if (_collisionCapsuleRadius == null)
				{
					_collisionCapsuleRadius = (CFloat) CR2WTypeManager.Create("Float", "collisionCapsuleRadius", cr2w, this);
				}
				return _collisionCapsuleRadius;
			}
			set
			{
				if (_collisionCapsuleRadius == value)
				{
					return;
				}
				_collisionCapsuleRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get
			{
				if (_collisionCapsuleHeightExtent == null)
				{
					_collisionCapsuleHeightExtent = (CFloat) CR2WTypeManager.Create("Float", "collisionCapsuleHeightExtent", cr2w, this);
				}
				return _collisionCapsuleHeightExtent;
			}
			set
			{
				if (_collisionCapsuleHeightExtent == value)
				{
					return;
				}
				_collisionCapsuleHeightExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get
			{
				if (_collisionCapsuleAxisLS == null)
				{
					_collisionCapsuleAxisLS = (Vector3) CR2WTypeManager.Create("Vector3", "collisionCapsuleAxisLS", cr2w, this);
				}
				return _collisionCapsuleAxisLS;
			}
			set
			{
				if (_collisionCapsuleAxisLS == value)
				{
					return;
				}
				_collisionCapsuleAxisLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("projectionType")] 
		public CEnum<animDyngParticleProjectionType> ProjectionType
		{
			get
			{
				if (_projectionType == null)
				{
					_projectionType = (CEnum<animDyngParticleProjectionType>) CR2WTypeManager.Create("animDyngParticleProjectionType", "projectionType", cr2w, this);
				}
				return _projectionType;
			}
			set
			{
				if (_projectionType == value)
				{
					return;
				}
				_projectionType = value;
				PropertySet(this);
			}
		}

		public animDyngParticle_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
