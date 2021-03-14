using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		private animVectorLink _targetALink;
		private animFloatLink _weightALink;
		private animVectorLink _targetBLink;
		private animFloatLink _weightBLink;
		private animFloatLink _transitionWeightLink;
		private animTransformIndex _leftEye;
		private animTransformIndex _rightEye;
		private animTransformIndex _head;
		private CEnum<animAxis> _forwardDirection;

		[Ordinal(12)] 
		[RED("targetALink")] 
		public animVectorLink TargetALink
		{
			get
			{
				if (_targetALink == null)
				{
					_targetALink = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetALink", cr2w, this);
				}
				return _targetALink;
			}
			set
			{
				if (_targetALink == value)
				{
					return;
				}
				_targetALink = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("weightALink")] 
		public animFloatLink WeightALink
		{
			get
			{
				if (_weightALink == null)
				{
					_weightALink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightALink", cr2w, this);
				}
				return _weightALink;
			}
			set
			{
				if (_weightALink == value)
				{
					return;
				}
				_weightALink = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("targetBLink")] 
		public animVectorLink TargetBLink
		{
			get
			{
				if (_targetBLink == null)
				{
					_targetBLink = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetBLink", cr2w, this);
				}
				return _targetBLink;
			}
			set
			{
				if (_targetBLink == value)
				{
					return;
				}
				_targetBLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("weightBLink")] 
		public animFloatLink WeightBLink
		{
			get
			{
				if (_weightBLink == null)
				{
					_weightBLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightBLink", cr2w, this);
				}
				return _weightBLink;
			}
			set
			{
				if (_weightBLink == value)
				{
					return;
				}
				_weightBLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("transitionWeightLink")] 
		public animFloatLink TransitionWeightLink
		{
			get
			{
				if (_transitionWeightLink == null)
				{
					_transitionWeightLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "transitionWeightLink", cr2w, this);
				}
				return _transitionWeightLink;
			}
			set
			{
				if (_transitionWeightLink == value)
				{
					return;
				}
				_transitionWeightLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("leftEye")] 
		public animTransformIndex LeftEye
		{
			get
			{
				if (_leftEye == null)
				{
					_leftEye = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftEye", cr2w, this);
				}
				return _leftEye;
			}
			set
			{
				if (_leftEye == value)
				{
					return;
				}
				_leftEye = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rightEye")] 
		public animTransformIndex RightEye
		{
			get
			{
				if (_rightEye == null)
				{
					_rightEye = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightEye", cr2w, this);
				}
				return _rightEye;
			}
			set
			{
				if (_rightEye == value)
				{
					return;
				}
				_rightEye = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("head")] 
		public animTransformIndex Head
		{
			get
			{
				if (_head == null)
				{
					_head = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "head", cr2w, this);
				}
				return _head;
			}
			set
			{
				if (_head == value)
				{
					return;
				}
				_head = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("forwardDirection")] 
		public CEnum<animAxis> ForwardDirection
		{
			get
			{
				if (_forwardDirection == null)
				{
					_forwardDirection = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "forwardDirection", cr2w, this);
				}
				return _forwardDirection;
			}
			set
			{
				if (_forwardDirection == value)
				{
					return;
				}
				_forwardDirection = value;
				PropertySet(this);
			}
		}

		public animAnimNode_EyesLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
