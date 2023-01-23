using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_ItemRebalancer : gameObject
	{
		[Ordinal(35)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public DEBUG_ItemRebalancer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
