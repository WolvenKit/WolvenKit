using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlock : InteractiveDevice
	{
		private CFloat _openingSpeed;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CHandle<AnimFeature_RoadBlock> _animFeature;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceEnableLink;

		[Ordinal(96)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetProperty(ref _openingSpeed);
			set => SetProperty(ref _openingSpeed, value);
		}

		[Ordinal(97)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(98)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetProperty(ref _offMeshConnection);
			set => SetProperty(ref _offMeshConnection, value);
		}

		[Ordinal(99)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(100)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(101)] 
		[RED("forceEnableLink")] 
		public CBool ForceEnableLink
		{
			get => GetProperty(ref _forceEnableLink);
			set => SetProperty(ref _forceEnableLink, value);
		}

		public RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
