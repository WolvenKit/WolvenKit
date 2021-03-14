using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintCone : animIDyngConstraint
	{
		private animTransformIndex _constrainedBone;
		private animTransformIndex _coneAttachmentBone;
		private QsTransform _coneTransformLS;
		private CEnum<animPendulumConstraintType> _constraintType;
		private CFloat _halfOfMaxApertureAngle;
		private CEnum<animPendulumProjectionType> _projectionType;
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;

		[Ordinal(1)] 
		[RED("constrainedBone")] 
		public animTransformIndex ConstrainedBone
		{
			get
			{
				if (_constrainedBone == null)
				{
					_constrainedBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedBone", cr2w, this);
				}
				return _constrainedBone;
			}
			set
			{
				if (_constrainedBone == value)
				{
					return;
				}
				_constrainedBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coneAttachmentBone")] 
		public animTransformIndex ConeAttachmentBone
		{
			get
			{
				if (_coneAttachmentBone == null)
				{
					_coneAttachmentBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "coneAttachmentBone", cr2w, this);
				}
				return _coneAttachmentBone;
			}
			set
			{
				if (_coneAttachmentBone == value)
				{
					return;
				}
				_coneAttachmentBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("coneTransformLS")] 
		public QsTransform ConeTransformLS
		{
			get
			{
				if (_coneTransformLS == null)
				{
					_coneTransformLS = (QsTransform) CR2WTypeManager.Create("QsTransform", "coneTransformLS", cr2w, this);
				}
				return _coneTransformLS;
			}
			set
			{
				if (_coneTransformLS == value)
				{
					return;
				}
				_coneTransformLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get
			{
				if (_constraintType == null)
				{
					_constraintType = (CEnum<animPendulumConstraintType>) CR2WTypeManager.Create("animPendulumConstraintType", "constraintType", cr2w, this);
				}
				return _constraintType;
			}
			set
			{
				if (_constraintType == value)
				{
					return;
				}
				_constraintType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get
			{
				if (_halfOfMaxApertureAngle == null)
				{
					_halfOfMaxApertureAngle = (CFloat) CR2WTypeManager.Create("Float", "halfOfMaxApertureAngle", cr2w, this);
				}
				return _halfOfMaxApertureAngle;
			}
			set
			{
				if (_halfOfMaxApertureAngle == value)
				{
					return;
				}
				_halfOfMaxApertureAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get
			{
				if (_projectionType == null)
				{
					_projectionType = (CEnum<animPendulumProjectionType>) CR2WTypeManager.Create("animPendulumProjectionType", "projectionType", cr2w, this);
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		public animDyngConstraintCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
