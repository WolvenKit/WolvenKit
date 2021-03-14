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
			get
			{
				if (_destinationNode == null)
				{
					_destinationNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "destinationNode", cr2w, this);
				}
				return _destinationNode;
			}
			set
			{
				if (_destinationNode == value)
				{
					return;
				}
				_destinationNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rootEntityPosition")] 
		public Vector4 RootEntityPosition
		{
			get
			{
				if (_rootEntityPosition == null)
				{
					_rootEntityPosition = (Vector4) CR2WTypeManager.Create("Vector4", "rootEntityPosition", cr2w, this);
				}
				return _rootEntityPosition;
			}
			set
			{
				if (_rootEntityPosition == value)
				{
					return;
				}
				_rootEntityPosition = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatformTeleportTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
