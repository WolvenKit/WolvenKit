using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Portal : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(99)] 
		[RED("LinkedPortal")] 
		public NodeRef LinkedPortal
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(100)] 
		[RED("renderToTextureComponent")] 
		public CWeakHandle<entIPlacedComponent> RenderToTextureComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("virtualCameraComponent")] 
		public CWeakHandle<entIPlacedComponent> VirtualCameraComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("isInStreamRange")] 
		public CBool IsInStreamRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(103)] 
		[RED("isInTeleportRange")] 
		public CBool IsInTeleportRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("isOnOtherSide")] 
		public CBool IsOnOtherSide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("playerBlocker")] 
		public CWeakHandle<entIPlacedComponent> PlayerBlocker
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(106)] 
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
