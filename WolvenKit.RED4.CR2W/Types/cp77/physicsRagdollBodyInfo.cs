using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyInfo : CVariable
	{
		private CInt32 _parentAnimIndex;
		private CInt32 _childAnimIndex;
		private CInt32 _parentBodyIndex;
		private CEnum<physicsRagdollBodyPartE> _bodyPart;
		private CEnum<physicsRagdollShapeType> _shapeType;
		private CFloat _shapeRadius;
		private CFloat _halfHeight;
		private Vector3 _shapeLocalTranslation;
		private Quaternion _shapeLocalRotation;
		private CBool _isRootDisplacementPart;
		private CArrayFixedSize<CFloat> _swingAnglesY;
		private CArrayFixedSize<CFloat> _swingAnglesZ;
		private CArrayFixedSize<CFloat> _twistAngles;
		private CBool _isStiff;
		private CBool _excludeFromEarlyCollision;
		private CName _filterDataOverride;

		[Ordinal(0)] 
		[RED("ParentAnimIndex")] 
		public CInt32 ParentAnimIndex
		{
			get
			{
				if (_parentAnimIndex == null)
				{
					_parentAnimIndex = (CInt32) CR2WTypeManager.Create("Int32", "ParentAnimIndex", cr2w, this);
				}
				return _parentAnimIndex;
			}
			set
			{
				if (_parentAnimIndex == value)
				{
					return;
				}
				_parentAnimIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ChildAnimIndex")] 
		public CInt32 ChildAnimIndex
		{
			get
			{
				if (_childAnimIndex == null)
				{
					_childAnimIndex = (CInt32) CR2WTypeManager.Create("Int32", "ChildAnimIndex", cr2w, this);
				}
				return _childAnimIndex;
			}
			set
			{
				if (_childAnimIndex == value)
				{
					return;
				}
				_childAnimIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ParentBodyIndex")] 
		public CInt32 ParentBodyIndex
		{
			get
			{
				if (_parentBodyIndex == null)
				{
					_parentBodyIndex = (CInt32) CR2WTypeManager.Create("Int32", "ParentBodyIndex", cr2w, this);
				}
				return _parentBodyIndex;
			}
			set
			{
				if (_parentBodyIndex == value)
				{
					return;
				}
				_parentBodyIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("BodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "BodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ShapeType")] 
		public CEnum<physicsRagdollShapeType> ShapeType
		{
			get
			{
				if (_shapeType == null)
				{
					_shapeType = (CEnum<physicsRagdollShapeType>) CR2WTypeManager.Create("physicsRagdollShapeType", "ShapeType", cr2w, this);
				}
				return _shapeType;
			}
			set
			{
				if (_shapeType == value)
				{
					return;
				}
				_shapeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ShapeRadius")] 
		public CFloat ShapeRadius
		{
			get
			{
				if (_shapeRadius == null)
				{
					_shapeRadius = (CFloat) CR2WTypeManager.Create("Float", "ShapeRadius", cr2w, this);
				}
				return _shapeRadius;
			}
			set
			{
				if (_shapeRadius == value)
				{
					return;
				}
				_shapeRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("HalfHeight")] 
		public CFloat HalfHeight
		{
			get
			{
				if (_halfHeight == null)
				{
					_halfHeight = (CFloat) CR2WTypeManager.Create("Float", "HalfHeight", cr2w, this);
				}
				return _halfHeight;
			}
			set
			{
				if (_halfHeight == value)
				{
					return;
				}
				_halfHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ShapeLocalTranslation")] 
		public Vector3 ShapeLocalTranslation
		{
			get
			{
				if (_shapeLocalTranslation == null)
				{
					_shapeLocalTranslation = (Vector3) CR2WTypeManager.Create("Vector3", "ShapeLocalTranslation", cr2w, this);
				}
				return _shapeLocalTranslation;
			}
			set
			{
				if (_shapeLocalTranslation == value)
				{
					return;
				}
				_shapeLocalTranslation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ShapeLocalRotation")] 
		public Quaternion ShapeLocalRotation
		{
			get
			{
				if (_shapeLocalRotation == null)
				{
					_shapeLocalRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "ShapeLocalRotation", cr2w, this);
				}
				return _shapeLocalRotation;
			}
			set
			{
				if (_shapeLocalRotation == value)
				{
					return;
				}
				_shapeLocalRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("IsRootDisplacementPart")] 
		public CBool IsRootDisplacementPart
		{
			get
			{
				if (_isRootDisplacementPart == null)
				{
					_isRootDisplacementPart = (CBool) CR2WTypeManager.Create("Bool", "IsRootDisplacementPart", cr2w, this);
				}
				return _isRootDisplacementPart;
			}
			set
			{
				if (_isRootDisplacementPart == value)
				{
					return;
				}
				_isRootDisplacementPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("SwingAnglesY", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesY
		{
			get
			{
				if (_swingAnglesY == null)
				{
					_swingAnglesY = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[2]Float", "SwingAnglesY", cr2w, this);
				}
				return _swingAnglesY;
			}
			set
			{
				if (_swingAnglesY == value)
				{
					return;
				}
				_swingAnglesY = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("SwingAnglesZ", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesZ
		{
			get
			{
				if (_swingAnglesZ == null)
				{
					_swingAnglesZ = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[2]Float", "SwingAnglesZ", cr2w, this);
				}
				return _swingAnglesZ;
			}
			set
			{
				if (_swingAnglesZ == value)
				{
					return;
				}
				_swingAnglesZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("TwistAngles", 2)] 
		public CArrayFixedSize<CFloat> TwistAngles
		{
			get
			{
				if (_twistAngles == null)
				{
					_twistAngles = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[2]Float", "TwistAngles", cr2w, this);
				}
				return _twistAngles;
			}
			set
			{
				if (_twistAngles == value)
				{
					return;
				}
				_twistAngles = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("IsStiff")] 
		public CBool IsStiff
		{
			get
			{
				if (_isStiff == null)
				{
					_isStiff = (CBool) CR2WTypeManager.Create("Bool", "IsStiff", cr2w, this);
				}
				return _isStiff;
			}
			set
			{
				if (_isStiff == value)
				{
					return;
				}
				_isStiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ExcludeFromEarlyCollision")] 
		public CBool ExcludeFromEarlyCollision
		{
			get
			{
				if (_excludeFromEarlyCollision == null)
				{
					_excludeFromEarlyCollision = (CBool) CR2WTypeManager.Create("Bool", "ExcludeFromEarlyCollision", cr2w, this);
				}
				return _excludeFromEarlyCollision;
			}
			set
			{
				if (_excludeFromEarlyCollision == value)
				{
					return;
				}
				_excludeFromEarlyCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("FilterDataOverride")] 
		public CName FilterDataOverride
		{
			get
			{
				if (_filterDataOverride == null)
				{
					_filterDataOverride = (CName) CR2WTypeManager.Create("CName", "FilterDataOverride", cr2w, this);
				}
				return _filterDataOverride;
			}
			set
			{
				if (_filterDataOverride == value)
				{
					return;
				}
				_filterDataOverride = value;
				PropertySet(this);
			}
		}

		public physicsRagdollBodyInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
