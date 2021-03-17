using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformTeleportTo : redEvent
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

		public gameMovingPlatformTeleportTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
