using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformTeleportTo : redEvent
	{
		private NodeRef _destinationNode;
		private Vector4 _rootEntityPosition;

		[Ordinal(0)] 
		[RED("destinationNode")] 
		public NodeRef DestinationNode
		{
			get => GetProperty(ref _destinationNode);
			set => SetProperty(ref _destinationNode, value);
		}

		[Ordinal(1)] 
		[RED("rootEntityPosition")] 
		public Vector4 RootEntityPosition
		{
			get => GetProperty(ref _rootEntityPosition);
			set => SetProperty(ref _rootEntityPosition, value);
		}
	}
}
