using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_Simulation_ : ISerializable
	{
		private CArray<animCollisionRoundedShape> _collisionRoundedShapes;
		private rRef<JsonResource> _jsonCollisionShapes;
		private CBool _jsonCollisionShapesLoadedSuccessfully;
		private CFloat _alpha;
		private CBool _rotateParentToLookAtDangle;
		private CBool _parentRotationAltersTransformsOfDangleAndItsChildren;
		private CBool _parentRotationAltersTransformsOfNonDanglesAndItsChildren;
		private CBool _dangleAltersTransformsOfItsChildren;

		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get
			{
				if (_collisionRoundedShapes == null)
				{
					_collisionRoundedShapes = (CArray<animCollisionRoundedShape>) CR2WTypeManager.Create("array:animCollisionRoundedShape", "collisionRoundedShapes", cr2w, this);
				}
				return _collisionRoundedShapes;
			}
			set
			{
				if (_collisionRoundedShapes == value)
				{
					return;
				}
				_collisionRoundedShapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("jsonCollisionShapes")] 
		public rRef<JsonResource> JsonCollisionShapes
		{
			get
			{
				if (_jsonCollisionShapes == null)
				{
					_jsonCollisionShapes = (rRef<JsonResource>) CR2WTypeManager.Create("rRef:JsonResource", "jsonCollisionShapes", cr2w, this);
				}
				return _jsonCollisionShapes;
			}
			set
			{
				if (_jsonCollisionShapes == value)
				{
					return;
				}
				_jsonCollisionShapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jsonCollisionShapesLoadedSuccessfully")] 
		public CBool JsonCollisionShapesLoadedSuccessfully
		{
			get
			{
				if (_jsonCollisionShapesLoadedSuccessfully == null)
				{
					_jsonCollisionShapesLoadedSuccessfully = (CBool) CR2WTypeManager.Create("Bool", "jsonCollisionShapesLoadedSuccessfully", cr2w, this);
				}
				return _jsonCollisionShapesLoadedSuccessfully;
			}
			set
			{
				if (_jsonCollisionShapesLoadedSuccessfully == value)
				{
					return;
				}
				_jsonCollisionShapesLoadedSuccessfully = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CFloat) CR2WTypeManager.Create("Float", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rotateParentToLookAtDangle")] 
		public CBool RotateParentToLookAtDangle
		{
			get
			{
				if (_rotateParentToLookAtDangle == null)
				{
					_rotateParentToLookAtDangle = (CBool) CR2WTypeManager.Create("Bool", "rotateParentToLookAtDangle", cr2w, this);
				}
				return _rotateParentToLookAtDangle;
			}
			set
			{
				if (_rotateParentToLookAtDangle == value)
				{
					return;
				}
				_rotateParentToLookAtDangle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("parentRotationAltersTransformsOfDangleAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfDangleAndItsChildren
		{
			get
			{
				if (_parentRotationAltersTransformsOfDangleAndItsChildren == null)
				{
					_parentRotationAltersTransformsOfDangleAndItsChildren = (CBool) CR2WTypeManager.Create("Bool", "parentRotationAltersTransformsOfDangleAndItsChildren", cr2w, this);
				}
				return _parentRotationAltersTransformsOfDangleAndItsChildren;
			}
			set
			{
				if (_parentRotationAltersTransformsOfDangleAndItsChildren == value)
				{
					return;
				}
				_parentRotationAltersTransformsOfDangleAndItsChildren = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("parentRotationAltersTransformsOfNonDanglesAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfNonDanglesAndItsChildren
		{
			get
			{
				if (_parentRotationAltersTransformsOfNonDanglesAndItsChildren == null)
				{
					_parentRotationAltersTransformsOfNonDanglesAndItsChildren = (CBool) CR2WTypeManager.Create("Bool", "parentRotationAltersTransformsOfNonDanglesAndItsChildren", cr2w, this);
				}
				return _parentRotationAltersTransformsOfNonDanglesAndItsChildren;
			}
			set
			{
				if (_parentRotationAltersTransformsOfNonDanglesAndItsChildren == value)
				{
					return;
				}
				_parentRotationAltersTransformsOfNonDanglesAndItsChildren = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dangleAltersTransformsOfItsChildren")] 
		public CBool DangleAltersTransformsOfItsChildren
		{
			get
			{
				if (_dangleAltersTransformsOfItsChildren == null)
				{
					_dangleAltersTransformsOfItsChildren = (CBool) CR2WTypeManager.Create("Bool", "dangleAltersTransformsOfItsChildren", cr2w, this);
				}
				return _dangleAltersTransformsOfItsChildren;
			}
			set
			{
				if (_dangleAltersTransformsOfItsChildren == value)
				{
					return;
				}
				_dangleAltersTransformsOfItsChildren = value;
				PropertySet(this);
			}
		}

		public animDangleConstraint_Simulation_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
