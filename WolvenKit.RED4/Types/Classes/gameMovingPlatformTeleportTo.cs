using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformTeleportTo : redEvent
	{
		[Ordinal(0)] 
		[RED("destinationNode")] 
		public NodeRef DestinationNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("rootEntityPosition")] 
		public Vector4 RootEntityPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameMovingPlatformTeleportTo()
		{
			RootEntityPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
