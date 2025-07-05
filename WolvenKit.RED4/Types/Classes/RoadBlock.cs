using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoadBlock : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("coverObjectRefs")] 
		public CArray<NodeRef> CoverObjectRefs
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(100)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RoadBlock>>();
			set => SetPropertyValue<CHandle<AnimFeature_RoadBlock>>(value);
		}

		[Ordinal(103)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(104)] 
		[RED("forceEnableLink")] 
		public CBool ForceEnableLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("globalCoverObjectRefs")] 
		public CArray<worldGlobalNodeRef> GlobalCoverObjectRefs
		{
			get => GetPropertyValue<CArray<worldGlobalNodeRef>>();
			set => SetPropertyValue<CArray<worldGlobalNodeRef>>(value);
		}

		[Ordinal(106)] 
		[RED("areGlobalCoverRefsInitialized")] 
		public CBool AreGlobalCoverRefsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RoadBlock()
		{
			ControllerTypeName = "RoadBlockController";
			OpeningSpeed = 2.000000F;
			CoverObjectRefs = new();
			GlobalCoverObjectRefs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
