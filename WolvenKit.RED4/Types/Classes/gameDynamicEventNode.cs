using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDynamicEventNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("mappinRef")] 
		public NodeRef MappinRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		public gameDynamicEventNode()
		{
			Color = new CColor { Red = 255, Green = 237, Alpha = 170 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
