using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStreamingTestMovePlayerOnSpline_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public questStreamingTestMovePlayerOnSpline_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
