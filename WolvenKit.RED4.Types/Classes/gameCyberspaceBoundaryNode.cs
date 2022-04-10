using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCyberspaceBoundaryNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("marker1Ref")] 
		public NodeRef Marker1Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("marker2Ref")] 
		public NodeRef Marker2Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameCyberspaceBoundaryNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
