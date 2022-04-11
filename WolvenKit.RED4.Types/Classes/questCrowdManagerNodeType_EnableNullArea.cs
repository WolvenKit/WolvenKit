using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCrowdManagerNodeType_EnableNullArea : questICrowdManager_NodeType
	{
		[Ordinal(0)] 
		[RED("areaReference")] 
		public NodeRef AreaReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCrowdManagerNodeType_EnableNullArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
