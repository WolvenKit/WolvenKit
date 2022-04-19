using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Portal : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(95)] 
		[RED("LinkedPortal")] 
		public NodeRef LinkedPortal
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(96)] 
		[RED("renderToTextureComponent")] 
		public CWeakHandle<entIPlacedComponent> RenderToTextureComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("virtualCameraComponent")] 
		public CWeakHandle<entIPlacedComponent> VirtualCameraComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("isInStreamRange")] 
		public CBool IsInStreamRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("isInTeleportRange")] 
		public CBool IsInTeleportRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("isOnOtherSide")] 
		public CBool IsOnOtherSide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("playerBlocker")] 
		public CWeakHandle<entIPlacedComponent> PlayerBlocker
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("screen")] 
		public CWeakHandle<entMeshComponent> Screen
		{
			get => GetPropertyValue<CWeakHandle<entMeshComponent>>();
			set => SetPropertyValue<CWeakHandle<entMeshComponent>>(value);
		}

		public Portal()
		{
			ControllerTypeName = "PortalController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
