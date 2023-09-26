using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnFlowControlNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("opensAt")] 
		public CUInt32 OpensAt
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("closesAt")] 
		public CUInt32 ClosesAt
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnFlowControlNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();
			IsOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
