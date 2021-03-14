using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2 : animAnimNode_Base
	{
		private animTransformIndex _firstBone;
		private animTransformIndex _secondBone;
		private animTransformIndex _endBone;
		private CEnum<animAxis> _hingeAxis;
		private CFloat _minHingeAngleDegrees;
		private CFloat _maxHingeAngleDegrees;
		private CFloat _firstBoneIkGain;
		private CFloat _secondBoneIkGain;
		private CFloat _endBoneIkGain;
		private CBool _enforceEndPosition;
		private CBool _enforceEndOrientation;
		private Vector4 _endBoneOffsetPositionLS;
		private animTransformIndex _bone;
		private animNamedTrackIndex _floatTrack;
		private animPoseLink _inputPoseNode;
		private animFloatLink _weightNode;
		private animVectorLink _endTargetPositionNode;
		private animQuaternionLink _endTargetOrientationNode;

		[Ordinal(11)] 
		[RED("firstBone")] 
		public animTransformIndex FirstBone
		{
			get
			{
				if (_firstBone == null)
				{
					_firstBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "firstBone", cr2w, this);
				}
				return _firstBone;
			}
			set
			{
				if (_firstBone == value)
				{
					return;
				}
				_firstBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("secondBone")] 
		public animTransformIndex SecondBone
		{
			get
			{
				if (_secondBone == null)
				{
					_secondBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "secondBone", cr2w, this);
				}
				return _secondBone;
			}
			set
			{
				if (_secondBone == value)
				{
					return;
				}
				_secondBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("endBone")] 
		public animTransformIndex EndBone
		{
			get
			{
				if (_endBone == null)
				{
					_endBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "endBone", cr2w, this);
				}
				return _endBone;
			}
			set
			{
				if (_endBone == value)
				{
					return;
				}
				_endBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get
			{
				if (_hingeAxis == null)
				{
					_hingeAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "hingeAxis", cr2w, this);
				}
				return _hingeAxis;
			}
			set
			{
				if (_hingeAxis == value)
				{
					return;
				}
				_hingeAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("minHingeAngleDegrees")] 
		public CFloat MinHingeAngleDegrees
		{
			get
			{
				if (_minHingeAngleDegrees == null)
				{
					_minHingeAngleDegrees = (CFloat) CR2WTypeManager.Create("Float", "minHingeAngleDegrees", cr2w, this);
				}
				return _minHingeAngleDegrees;
			}
			set
			{
				if (_minHingeAngleDegrees == value)
				{
					return;
				}
				_minHingeAngleDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("maxHingeAngleDegrees")] 
		public CFloat MaxHingeAngleDegrees
		{
			get
			{
				if (_maxHingeAngleDegrees == null)
				{
					_maxHingeAngleDegrees = (CFloat) CR2WTypeManager.Create("Float", "maxHingeAngleDegrees", cr2w, this);
				}
				return _maxHingeAngleDegrees;
			}
			set
			{
				if (_maxHingeAngleDegrees == value)
				{
					return;
				}
				_maxHingeAngleDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("firstBoneIkGain")] 
		public CFloat FirstBoneIkGain
		{
			get
			{
				if (_firstBoneIkGain == null)
				{
					_firstBoneIkGain = (CFloat) CR2WTypeManager.Create("Float", "firstBoneIkGain", cr2w, this);
				}
				return _firstBoneIkGain;
			}
			set
			{
				if (_firstBoneIkGain == value)
				{
					return;
				}
				_firstBoneIkGain = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("secondBoneIkGain")] 
		public CFloat SecondBoneIkGain
		{
			get
			{
				if (_secondBoneIkGain == null)
				{
					_secondBoneIkGain = (CFloat) CR2WTypeManager.Create("Float", "secondBoneIkGain", cr2w, this);
				}
				return _secondBoneIkGain;
			}
			set
			{
				if (_secondBoneIkGain == value)
				{
					return;
				}
				_secondBoneIkGain = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("endBoneIkGain")] 
		public CFloat EndBoneIkGain
		{
			get
			{
				if (_endBoneIkGain == null)
				{
					_endBoneIkGain = (CFloat) CR2WTypeManager.Create("Float", "endBoneIkGain", cr2w, this);
				}
				return _endBoneIkGain;
			}
			set
			{
				if (_endBoneIkGain == value)
				{
					return;
				}
				_endBoneIkGain = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("enforceEndPosition")] 
		public CBool EnforceEndPosition
		{
			get
			{
				if (_enforceEndPosition == null)
				{
					_enforceEndPosition = (CBool) CR2WTypeManager.Create("Bool", "enforceEndPosition", cr2w, this);
				}
				return _enforceEndPosition;
			}
			set
			{
				if (_enforceEndPosition == value)
				{
					return;
				}
				_enforceEndPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("enforceEndOrientation")] 
		public CBool EnforceEndOrientation
		{
			get
			{
				if (_enforceEndOrientation == null)
				{
					_enforceEndOrientation = (CBool) CR2WTypeManager.Create("Bool", "enforceEndOrientation", cr2w, this);
				}
				return _enforceEndOrientation;
			}
			set
			{
				if (_enforceEndOrientation == value)
				{
					return;
				}
				_enforceEndOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("endBoneOffsetPositionLS")] 
		public Vector4 EndBoneOffsetPositionLS
		{
			get
			{
				if (_endBoneOffsetPositionLS == null)
				{
					_endBoneOffsetPositionLS = (Vector4) CR2WTypeManager.Create("Vector4", "endBoneOffsetPositionLS", cr2w, this);
				}
				return _endBoneOffsetPositionLS;
			}
			set
			{
				if (_endBoneOffsetPositionLS == value)
				{
					return;
				}
				_endBoneOffsetPositionLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get
			{
				if (_floatTrack == null)
				{
					_floatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "floatTrack", cr2w, this);
				}
				return _floatTrack;
			}
			set
			{
				if (_floatTrack == value)
				{
					return;
				}
				_floatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get
			{
				if (_inputPoseNode == null)
				{
					_inputPoseNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputPoseNode", cr2w, this);
				}
				return _inputPoseNode;
			}
			set
			{
				if (_inputPoseNode == value)
				{
					return;
				}
				_inputPoseNode = value;
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

		[Ordinal(27)] 
		[RED("endTargetPositionNode")] 
		public animVectorLink EndTargetPositionNode
		{
			get
			{
				if (_endTargetPositionNode == null)
				{
					_endTargetPositionNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "endTargetPositionNode", cr2w, this);
				}
				return _endTargetPositionNode;
			}
			set
			{
				if (_endTargetPositionNode == value)
				{
					return;
				}
				_endTargetPositionNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("endTargetOrientationNode")] 
		public animQuaternionLink EndTargetOrientationNode
		{
			get
			{
				if (_endTargetOrientationNode == null)
				{
					_endTargetOrientationNode = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "endTargetOrientationNode", cr2w, this);
				}
				return _endTargetOrientationNode;
			}
			set
			{
				if (_endTargetOrientationNode == value)
				{
					return;
				}
				_endTargetOrientationNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Ik2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
