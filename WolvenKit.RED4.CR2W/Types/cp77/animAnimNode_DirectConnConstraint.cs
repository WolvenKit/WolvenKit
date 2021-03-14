using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		private CHandle<animIAnimNodeSourceChannel_QsTransform> _sourceTransform;
		private CBool _isSourceTransformResaved;
		private animTransformIndex _sourceTransformIndex;
		private animTransformIndex _transformIndex;
		private CBool _posX;
		private CBool _posY;
		private CBool _posZ;
		private CBool _rotX;
		private CBool _rotY;
		private CBool _rotZ;
		private CBool _scaleX;
		private CBool _scaleY;
		private CBool _scaleZ;
		private CFloat _weight;
		private animFloatLink _weightNode;

		[Ordinal(12)] 
		[RED("sourceTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform
		{
			get
			{
				if (_sourceTransform == null)
				{
					_sourceTransform = (CHandle<animIAnimNodeSourceChannel_QsTransform>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_QsTransform", "sourceTransform", cr2w, this);
				}
				return _sourceTransform;
			}
			set
			{
				if (_sourceTransform == value)
				{
					return;
				}
				_sourceTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isSourceTransformResaved")] 
		public CBool IsSourceTransformResaved
		{
			get
			{
				if (_isSourceTransformResaved == null)
				{
					_isSourceTransformResaved = (CBool) CR2WTypeManager.Create("Bool", "isSourceTransformResaved", cr2w, this);
				}
				return _isSourceTransformResaved;
			}
			set
			{
				if (_isSourceTransformResaved == value)
				{
					return;
				}
				_isSourceTransformResaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sourceTransformIndex")] 
		public animTransformIndex SourceTransformIndex
		{
			get
			{
				if (_sourceTransformIndex == null)
				{
					_sourceTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "sourceTransformIndex", cr2w, this);
				}
				return _sourceTransformIndex;
			}
			set
			{
				if (_sourceTransformIndex == value)
				{
					return;
				}
				_sourceTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get
			{
				if (_transformIndex == null)
				{
					_transformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformIndex", cr2w, this);
				}
				return _transformIndex;
			}
			set
			{
				if (_transformIndex == value)
				{
					return;
				}
				_transformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("posX")] 
		public CBool PosX
		{
			get
			{
				if (_posX == null)
				{
					_posX = (CBool) CR2WTypeManager.Create("Bool", "posX", cr2w, this);
				}
				return _posX;
			}
			set
			{
				if (_posX == value)
				{
					return;
				}
				_posX = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("posY")] 
		public CBool PosY
		{
			get
			{
				if (_posY == null)
				{
					_posY = (CBool) CR2WTypeManager.Create("Bool", "posY", cr2w, this);
				}
				return _posY;
			}
			set
			{
				if (_posY == value)
				{
					return;
				}
				_posY = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("posZ")] 
		public CBool PosZ
		{
			get
			{
				if (_posZ == null)
				{
					_posZ = (CBool) CR2WTypeManager.Create("Bool", "posZ", cr2w, this);
				}
				return _posZ;
			}
			set
			{
				if (_posZ == value)
				{
					return;
				}
				_posZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rotX")] 
		public CBool RotX
		{
			get
			{
				if (_rotX == null)
				{
					_rotX = (CBool) CR2WTypeManager.Create("Bool", "rotX", cr2w, this);
				}
				return _rotX;
			}
			set
			{
				if (_rotX == value)
				{
					return;
				}
				_rotX = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("rotY")] 
		public CBool RotY
		{
			get
			{
				if (_rotY == null)
				{
					_rotY = (CBool) CR2WTypeManager.Create("Bool", "rotY", cr2w, this);
				}
				return _rotY;
			}
			set
			{
				if (_rotY == value)
				{
					return;
				}
				_rotY = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rotZ")] 
		public CBool RotZ
		{
			get
			{
				if (_rotZ == null)
				{
					_rotZ = (CBool) CR2WTypeManager.Create("Bool", "rotZ", cr2w, this);
				}
				return _rotZ;
			}
			set
			{
				if (_rotZ == value)
				{
					return;
				}
				_rotZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get
			{
				if (_scaleX == null)
				{
					_scaleX = (CBool) CR2WTypeManager.Create("Bool", "scaleX", cr2w, this);
				}
				return _scaleX;
			}
			set
			{
				if (_scaleX == value)
				{
					return;
				}
				_scaleX = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("scaleY")] 
		public CBool ScaleY
		{
			get
			{
				if (_scaleY == null)
				{
					_scaleY = (CBool) CR2WTypeManager.Create("Bool", "scaleY", cr2w, this);
				}
				return _scaleY;
			}
			set
			{
				if (_scaleY == value)
				{
					return;
				}
				_scaleY = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("scaleZ")] 
		public CBool ScaleZ
		{
			get
			{
				if (_scaleZ == null)
				{
					_scaleZ = (CBool) CR2WTypeManager.Create("Bool", "scaleZ", cr2w, this);
				}
				return _scaleZ;
			}
			set
			{
				if (_scaleZ == value)
				{
					return;
				}
				_scaleZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
