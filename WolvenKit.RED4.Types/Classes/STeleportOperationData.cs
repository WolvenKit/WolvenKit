using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STeleportOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public STeleportOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
