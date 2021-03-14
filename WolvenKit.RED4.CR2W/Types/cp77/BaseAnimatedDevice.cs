using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDevice : InteractiveDevice
	{
		private CFloat _openingSpeed;
		private CFloat _closingSpeed;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<AnimFeature_RoadBlock> _animFeature;
		private CEnum<EAnimationType> _animationType;

		[Ordinal(93)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get
			{
				if (_openingSpeed == null)
				{
					_openingSpeed = (CFloat) CR2WTypeManager.Create("Float", "openingSpeed", cr2w, this);
				}
				return _openingSpeed;
			}
			set
			{
				if (_openingSpeed == value)
				{
					return;
				}
				_openingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("closingSpeed")] 
		public CFloat ClosingSpeed
		{
			get
			{
				if (_closingSpeed == null)
				{
					_closingSpeed = (CFloat) CR2WTypeManager.Create("Float", "closingSpeed", cr2w, this);
				}
				return _closingSpeed;
			}
			set
			{
				if (_closingSpeed == value)
				{
					return;
				}
				_closingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationController", cr2w, this);
				}
				return _animationController;
			}
			set
			{
				if (_animationController == value)
				{
					return;
				}
				_animationController = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_RoadBlock>) CR2WTypeManager.Create("handle:AnimFeature_RoadBlock", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		public BaseAnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
