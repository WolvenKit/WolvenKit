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
			get => GetProperty(ref _openingSpeed);
			set => SetProperty(ref _openingSpeed, value);
		}

		[Ordinal(94)] 
		[RED("closingSpeed")] 
		public CFloat ClosingSpeed
		{
			get => GetProperty(ref _closingSpeed);
			set => SetProperty(ref _closingSpeed, value);
		}

		[Ordinal(95)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(96)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(97)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		public BaseAnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
