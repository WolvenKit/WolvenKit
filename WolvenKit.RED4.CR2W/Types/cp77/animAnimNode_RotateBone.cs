using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotateBone : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animFloatLink _angleNode;
		private animFloatLink _minValueNode;
		private animFloatLink _maxValueNode;
		private animTransformIndex _bone;
		private CEnum<animETransformAxis> _axis;
		private CFloat _scale;
		private CFloat _biasAngle;
		private CFloat _minAngle;
		private CFloat _maxAngle;
		private CBool _clampRotation;
		private CBool _useIncrementalMode;
		private CBool _resetOnActivation;
		private CBool _inModelSpace;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("angleNode")] 
		public animFloatLink AngleNode
		{
			get
			{
				if (_angleNode == null)
				{
					_angleNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "angleNode", cr2w, this);
				}
				return _angleNode;
			}
			set
			{
				if (_angleNode == value)
				{
					return;
				}
				_angleNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("minValueNode")] 
		public animFloatLink MinValueNode
		{
			get
			{
				if (_minValueNode == null)
				{
					_minValueNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "minValueNode", cr2w, this);
				}
				return _minValueNode;
			}
			set
			{
				if (_minValueNode == value)
				{
					return;
				}
				_minValueNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("maxValueNode")] 
		public animFloatLink MaxValueNode
		{
			get
			{
				if (_maxValueNode == null)
				{
					_maxValueNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "maxValueNode", cr2w, this);
				}
				return _maxValueNode;
			}
			set
			{
				if (_maxValueNode == value)
				{
					return;
				}
				_maxValueNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("axis")] 
		public CEnum<animETransformAxis> Axis
		{
			get
			{
				if (_axis == null)
				{
					_axis = (CEnum<animETransformAxis>) CR2WTypeManager.Create("animETransformAxis", "axis", cr2w, this);
				}
				return _axis;
			}
			set
			{
				if (_axis == value)
				{
					return;
				}
				_axis = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("biasAngle")] 
		public CFloat BiasAngle
		{
			get
			{
				if (_biasAngle == null)
				{
					_biasAngle = (CFloat) CR2WTypeManager.Create("Float", "biasAngle", cr2w, this);
				}
				return _biasAngle;
			}
			set
			{
				if (_biasAngle == value)
				{
					return;
				}
				_biasAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get
			{
				if (_minAngle == null)
				{
					_minAngle = (CFloat) CR2WTypeManager.Create("Float", "minAngle", cr2w, this);
				}
				return _minAngle;
			}
			set
			{
				if (_minAngle == value)
				{
					return;
				}
				_minAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get
			{
				if (_maxAngle == null)
				{
					_maxAngle = (CFloat) CR2WTypeManager.Create("Float", "maxAngle", cr2w, this);
				}
				return _maxAngle;
			}
			set
			{
				if (_maxAngle == value)
				{
					return;
				}
				_maxAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("clampRotation")] 
		public CBool ClampRotation
		{
			get
			{
				if (_clampRotation == null)
				{
					_clampRotation = (CBool) CR2WTypeManager.Create("Bool", "clampRotation", cr2w, this);
				}
				return _clampRotation;
			}
			set
			{
				if (_clampRotation == value)
				{
					return;
				}
				_clampRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get
			{
				if (_useIncrementalMode == null)
				{
					_useIncrementalMode = (CBool) CR2WTypeManager.Create("Bool", "useIncrementalMode", cr2w, this);
				}
				return _useIncrementalMode;
			}
			set
			{
				if (_useIncrementalMode == value)
				{
					return;
				}
				_useIncrementalMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get
			{
				if (_resetOnActivation == null)
				{
					_resetOnActivation = (CBool) CR2WTypeManager.Create("Bool", "resetOnActivation", cr2w, this);
				}
				return _resetOnActivation;
			}
			set
			{
				if (_resetOnActivation == value)
				{
					return;
				}
				_resetOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("inModelSpace")] 
		public CBool InModelSpace
		{
			get
			{
				if (_inModelSpace == null)
				{
					_inModelSpace = (CBool) CR2WTypeManager.Create("Bool", "inModelSpace", cr2w, this);
				}
				return _inModelSpace;
			}
			set
			{
				if (_inModelSpace == value)
				{
					return;
				}
				_inModelSpace = value;
				PropertySet(this);
			}
		}

		public animAnimNode_RotateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
