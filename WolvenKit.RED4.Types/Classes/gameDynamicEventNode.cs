using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDynamicEventNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("mappinRef")] 
		public NodeRef MappinRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		public gameDynamicEventNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
