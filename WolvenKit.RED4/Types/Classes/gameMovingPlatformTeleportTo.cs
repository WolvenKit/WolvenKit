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

		public gameMovingPlatformTeleportTo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
