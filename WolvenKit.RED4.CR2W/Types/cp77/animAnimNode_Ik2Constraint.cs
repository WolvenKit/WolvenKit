using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2Constraint : animAnimNode_OnePoseInput
	{
		private CHandle<animIAnimNodeSourceChannel_Vector> _inputTarget;
		private CHandle<animIAnimNodeSourceChannel_Vector> _inputPoleVector;
		private CHandle<animAnimNodeSourceChannel_WeightedQuat> _inputTargetOrientation;
		private animTransformIndex _firstBoneIndex;
		private animTransformIndex _secondBoneIndex;
		private animTransformIndex _endBoneIndex;
		private CEnum<animAxis> _hingeAxis;
		private CFloat _twistValue;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;
		private animFloatLink _weightNode;
		private animFloatLink _twistNode;
		private CFloat _maxHingeAngle;

		[Ordinal(12)] 
		[RED("inputTarget")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputTarget
		{
			get
			{
				if (_inputTarget == null)
				{
					_inputTarget = (CHandle<animIAnimNodeSourceChannel_Vector>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_Vector", "inputTarget", cr2w, this);
				}
				return _inputTarget;
			}
			set
			{
				if (_inputTarget == value)
				{
					return;
				}
				_inputTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputPoleVector")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputPoleVector
		{
			get
			{
				if (_inputPoleVector == null)
				{
					_inputPoleVector = (CHandle<animIAnimNodeSourceChannel_Vector>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_Vector", "inputPoleVector", cr2w, this);
				}
				return _inputPoleVector;
			}
			set
			{
				if (_inputPoleVector == value)
				{
					return;
				}
				_inputPoleVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inputTargetOrientation")] 
		public CHandle<animAnimNodeSourceChannel_WeightedQuat> InputTargetOrientation
		{
			get
			{
				if (_inputTargetOrientation == null)
				{
					_inputTargetOrientation = (CHandle<animAnimNodeSourceChannel_WeightedQuat>) CR2WTypeManager.Create("handle:animAnimNodeSourceChannel_WeightedQuat", "inputTargetOrientation", cr2w, this);
				}
				return _inputTargetOrientation;
			}
			set
			{
				if (_inputTargetOrientation == value)
				{
					return;
				}
				_inputTargetOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("firstBoneIndex")] 
		public animTransformIndex FirstBoneIndex
		{
			get
			{
				if (_firstBoneIndex == null)
				{
					_firstBoneIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "firstBoneIndex", cr2w, this);
				}
				return _firstBoneIndex;
			}
			set
			{
				if (_firstBoneIndex == value)
				{
					return;
				}
				_firstBoneIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("secondBoneIndex")] 
		public animTransformIndex SecondBoneIndex
		{
			get
			{
				if (_secondBoneIndex == null)
				{
					_secondBoneIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "secondBoneIndex", cr2w, this);
				}
				return _secondBoneIndex;
			}
			set
			{
				if (_secondBoneIndex == value)
				{
					return;
				}
				_secondBoneIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("endBoneIndex")] 
		public animTransformIndex EndBoneIndex
		{
			get
			{
				if (_endBoneIndex == null)
				{
					_endBoneIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "endBoneIndex", cr2w, this);
				}
				return _endBoneIndex;
			}
			set
			{
				if (_endBoneIndex == value)
				{
					return;
				}
				_endBoneIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("twistValue")] 
		public CFloat TwistValue
		{
			get
			{
				if (_twistValue == null)
				{
					_twistValue = (CFloat) CR2WTypeManager.Create("Float", "twistValue", cr2w, this);
				}
				return _twistValue;
			}
			set
			{
				if (_twistValue == value)
				{
					return;
				}
				_twistValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get
			{
				if (_weightFloatTrack == null)
				{
					_weightFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "weightFloatTrack", cr2w, this);
				}
				return _weightFloatTrack;
			}
			set
			{
				if (_weightFloatTrack == value)
				{
					return;
				}
				_weightFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("twistNode")] 
		public animFloatLink TwistNode
		{
			get
			{
				if (_twistNode == null)
				{
					_twistNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "twistNode", cr2w, this);
				}
				return _twistNode;
			}
			set
			{
				if (_twistNode == value)
				{
					return;
				}
				_twistNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("maxHingeAngle")] 
		public CFloat MaxHingeAngle
		{
			get
			{
				if (_maxHingeAngle == null)
				{
					_maxHingeAngle = (CFloat) CR2WTypeManager.Create("Float", "maxHingeAngle", cr2w, this);
				}
				return _maxHingeAngle;
			}
			set
			{
				if (_maxHingeAngle == value)
				{
					return;
				}
				_maxHingeAngle = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Ik2Constraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
