using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStreamingTestMovePlayerOnSpline_NodeType : questIWorldDataManagerNodeType
	{
		private NodeRef _splineRef;

		[Ordinal(0)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}
	}
}
