using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animSmoothFloatClamp _limitOnX;
		private animSmoothFloatClamp _limitOnY;
		private animSmoothFloatClamp _limitOnZ;
		private CBool _useEyesLookAtBlendWeight;
		private animFloatLink _weightLink;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("limitOnX")] 
		public animSmoothFloatClamp LimitOnX
		{
			get
			{
				if (_limitOnX == null)
				{
					_limitOnX = (animSmoothFloatClamp) CR2WTypeManager.Create("animSmoothFloatClamp", "limitOnX", cr2w, this);
				}
				return _limitOnX;
			}
			set
			{
				if (_limitOnX == value)
				{
					return;
				}
				_limitOnX = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("limitOnY")] 
		public animSmoothFloatClamp LimitOnY
		{
			get
			{
				if (_limitOnY == null)
				{
					_limitOnY = (animSmoothFloatClamp) CR2WTypeManager.Create("animSmoothFloatClamp", "limitOnY", cr2w, this);
				}
				return _limitOnY;
			}
			set
			{
				if (_limitOnY == value)
				{
					return;
				}
				_limitOnY = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("limitOnZ")] 
		public animSmoothFloatClamp LimitOnZ
		{
			get
			{
				if (_limitOnZ == null)
				{
					_limitOnZ = (animSmoothFloatClamp) CR2WTypeManager.Create("animSmoothFloatClamp", "limitOnZ", cr2w, this);
				}
				return _limitOnZ;
			}
			set
			{
				if (_limitOnZ == value)
				{
					return;
				}
				_limitOnZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("useEyesLookAtBlendWeight")] 
		public CBool UseEyesLookAtBlendWeight
		{
			get
			{
				if (_useEyesLookAtBlendWeight == null)
				{
					_useEyesLookAtBlendWeight = (CBool) CR2WTypeManager.Create("Bool", "useEyesLookAtBlendWeight", cr2w, this);
				}
				return _useEyesLookAtBlendWeight;
			}
			set
			{
				if (_useEyesLookAtBlendWeight == value)
				{
					return;
				}
				_useEyesLookAtBlendWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get
			{
				if (_weightLink == null)
				{
					_weightLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightLink", cr2w, this);
				}
				return _weightLink;
			}
			set
			{
				if (_weightLink == value)
				{
					return;
				}
				_weightLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
