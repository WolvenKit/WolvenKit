using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentNodeRefValue : AIArgumentDefinition
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetPropertyValue<CEnum<AIArgumentType>>();
			set => SetPropertyValue<CEnum<AIArgumentType>>(value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public NodeRef DefaultValue
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public AIArgumentNodeRefValue()
		{
			Type = Enums.AIArgumentType.NodeRef;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
