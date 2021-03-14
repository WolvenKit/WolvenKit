using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;
		private Vector3 _collisionCapsuleAxisLS;
		private animTransformIndex _directionReferenceBone;
		private CEnum<animPositionProjectionType> _projectionType;

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("directionReferenceBone")] 
		public animTransformIndex DirectionReferenceBone
		{
			get
			{
				if (_directionReferenceBone == null)
				{
					_directionReferenceBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "directionReferenceBone", cr2w, this);
				}
				return _directionReferenceBone;
			}
			set
			{
				if (_directionReferenceBone == value)
				{
					return;
				}
				_directionReferenceBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("projectionType")] 
		public CEnum<animPositionProjectionType> ProjectionType
		{
			get
			{
				if (_projectionType == null)
				{
					_projectionType = (CEnum<animPositionProjectionType>) CR2WTypeManager.Create("animPositionProjectionType", "projectionType", cr2w, this);
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

		public animDangleConstraint_SimulationPositionProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
