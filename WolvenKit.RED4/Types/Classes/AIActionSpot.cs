using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionSpot : AISmartSpot
	{
		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<workWorkspotResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceAsyncReference<workWorkspotResource>>(value);
		}

		[Ordinal(1)] 
		[RED("ActorBodytypeE3")] 
		public CEnum<AISocketsForRig> ActorBodytypeE3
		{
			get => GetPropertyValue<CEnum<AISocketsForRig>>();
			set => SetPropertyValue<CEnum<AISocketsForRig>>(value);
		}

		[Ordinal(2)] 
		[RED("masterNodeRef")] 
		public NodeRef MasterNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("enabledWhenMasterOccupied")] 
		public CBool EnabledWhenMasterOccupied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("useClippingSpace")] 
		public CBool UseClippingSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("clippingSpaceOrientation")] 
		public CFloat ClippingSpaceOrientation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("clippingSpaceRange")] 
		public CFloat ClippingSpaceRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIActionSpot()
		{
			ClippingSpaceOrientation = 180.000000F;
			ClippingSpaceRange = 120.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
