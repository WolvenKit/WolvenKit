using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_MarkerPosition : gameTransformAnimation_Position
	{
		private NodeRef _markerNode;
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("markerNode")] 
		public NodeRef MarkerNode
		{
			get
			{
				if (_markerNode == null)
				{
					_markerNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "markerNode", cr2w, this);
				}
				return _markerNode;
			}
			set
			{
				if (_markerNode == value)
				{
					return;
				}
				_markerNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_Position_MarkerPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
