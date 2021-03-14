using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		private animTransformIndex _leftToeName;
		private animTransformIndex _rightToeName;
		private animTransformIndex _leftFootName;
		private animTransformIndex _rightFootName;
		private animTransformIndex _leftCalfName;
		private animTransformIndex _rightCalfName;
		private animTransformIndex _leftThighName;
		private animTransformIndex _rightThighName;
		private animTransformIndex _pelvisBoneName;
		private Vector4 _calfHingeAxis;
		private CFloat _iKBlendTime;
		private CFloat _pelvisAdjustmentBlendSpeed;
		private CBool _adjustPelvisVertically;
		private CFloat _stepAdjustmentInterval;
		private animFloatLink _controlValueNode;
		private animVectorLink _controlVectorNode;

		[Ordinal(12)] 
		[RED("leftToeName")] 
		public animTransformIndex LeftToeName
		{
			get
			{
				if (_leftToeName == null)
				{
					_leftToeName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftToeName", cr2w, this);
				}
				return _leftToeName;
			}
			set
			{
				if (_leftToeName == value)
				{
					return;
				}
				_leftToeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rightToeName")] 
		public animTransformIndex RightToeName
		{
			get
			{
				if (_rightToeName == null)
				{
					_rightToeName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightToeName", cr2w, this);
				}
				return _rightToeName;
			}
			set
			{
				if (_rightToeName == value)
				{
					return;
				}
				_rightToeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("leftFootName")] 
		public animTransformIndex LeftFootName
		{
			get
			{
				if (_leftFootName == null)
				{
					_leftFootName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftFootName", cr2w, this);
				}
				return _leftFootName;
			}
			set
			{
				if (_leftFootName == value)
				{
					return;
				}
				_leftFootName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rightFootName")] 
		public animTransformIndex RightFootName
		{
			get
			{
				if (_rightFootName == null)
				{
					_rightFootName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightFootName", cr2w, this);
				}
				return _rightFootName;
			}
			set
			{
				if (_rightFootName == value)
				{
					return;
				}
				_rightFootName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("leftCalfName")] 
		public animTransformIndex LeftCalfName
		{
			get
			{
				if (_leftCalfName == null)
				{
					_leftCalfName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftCalfName", cr2w, this);
				}
				return _leftCalfName;
			}
			set
			{
				if (_leftCalfName == value)
				{
					return;
				}
				_leftCalfName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("rightCalfName")] 
		public animTransformIndex RightCalfName
		{
			get
			{
				if (_rightCalfName == null)
				{
					_rightCalfName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightCalfName", cr2w, this);
				}
				return _rightCalfName;
			}
			set
			{
				if (_rightCalfName == value)
				{
					return;
				}
				_rightCalfName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("leftThighName")] 
		public animTransformIndex LeftThighName
		{
			get
			{
				if (_leftThighName == null)
				{
					_leftThighName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftThighName", cr2w, this);
				}
				return _leftThighName;
			}
			set
			{
				if (_leftThighName == value)
				{
					return;
				}
				_leftThighName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rightThighName")] 
		public animTransformIndex RightThighName
		{
			get
			{
				if (_rightThighName == null)
				{
					_rightThighName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightThighName", cr2w, this);
				}
				return _rightThighName;
			}
			set
			{
				if (_rightThighName == value)
				{
					return;
				}
				_rightThighName = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("pelvisBoneName")] 
		public animTransformIndex PelvisBoneName
		{
			get
			{
				if (_pelvisBoneName == null)
				{
					_pelvisBoneName = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "pelvisBoneName", cr2w, this);
				}
				return _pelvisBoneName;
			}
			set
			{
				if (_pelvisBoneName == value)
				{
					return;
				}
				_pelvisBoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("calfHingeAxis")] 
		public Vector4 CalfHingeAxis
		{
			get
			{
				if (_calfHingeAxis == null)
				{
					_calfHingeAxis = (Vector4) CR2WTypeManager.Create("Vector4", "calfHingeAxis", cr2w, this);
				}
				return _calfHingeAxis;
			}
			set
			{
				if (_calfHingeAxis == value)
				{
					return;
				}
				_calfHingeAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("IKBlendTime")] 
		public CFloat IKBlendTime
		{
			get
			{
				if (_iKBlendTime == null)
				{
					_iKBlendTime = (CFloat) CR2WTypeManager.Create("Float", "IKBlendTime", cr2w, this);
				}
				return _iKBlendTime;
			}
			set
			{
				if (_iKBlendTime == value)
				{
					return;
				}
				_iKBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("pelvisAdjustmentBlendSpeed")] 
		public CFloat PelvisAdjustmentBlendSpeed
		{
			get
			{
				if (_pelvisAdjustmentBlendSpeed == null)
				{
					_pelvisAdjustmentBlendSpeed = (CFloat) CR2WTypeManager.Create("Float", "pelvisAdjustmentBlendSpeed", cr2w, this);
				}
				return _pelvisAdjustmentBlendSpeed;
			}
			set
			{
				if (_pelvisAdjustmentBlendSpeed == value)
				{
					return;
				}
				_pelvisAdjustmentBlendSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("adjustPelvisVertically")] 
		public CBool AdjustPelvisVertically
		{
			get
			{
				if (_adjustPelvisVertically == null)
				{
					_adjustPelvisVertically = (CBool) CR2WTypeManager.Create("Bool", "adjustPelvisVertically", cr2w, this);
				}
				return _adjustPelvisVertically;
			}
			set
			{
				if (_adjustPelvisVertically == value)
				{
					return;
				}
				_adjustPelvisVertically = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("stepAdjustmentInterval")] 
		public CFloat StepAdjustmentInterval
		{
			get
			{
				if (_stepAdjustmentInterval == null)
				{
					_stepAdjustmentInterval = (CFloat) CR2WTypeManager.Create("Float", "stepAdjustmentInterval", cr2w, this);
				}
				return _stepAdjustmentInterval;
			}
			set
			{
				if (_stepAdjustmentInterval == value)
				{
					return;
				}
				_stepAdjustmentInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("controlValueNode")] 
		public animFloatLink ControlValueNode
		{
			get
			{
				if (_controlValueNode == null)
				{
					_controlValueNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "controlValueNode", cr2w, this);
				}
				return _controlValueNode;
			}
			set
			{
				if (_controlValueNode == value)
				{
					return;
				}
				_controlValueNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("controlVectorNode")] 
		public animVectorLink ControlVectorNode
		{
			get
			{
				if (_controlVectorNode == null)
				{
					_controlVectorNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "controlVectorNode", cr2w, this);
				}
				return _controlVectorNode;
			}
			set
			{
				if (_controlVectorNode == value)
				{
					return;
				}
				_controlVectorNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FootStepAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
