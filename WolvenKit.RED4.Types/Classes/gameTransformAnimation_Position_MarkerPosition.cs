using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Position_MarkerPosition : gameTransformAnimation_Position
	{
		private NodeRef _markerNode;
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("markerNode")] 
		public NodeRef MarkerNode
		{
			get => GetProperty(ref _markerNode);
			set => SetProperty(ref _markerNode, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
