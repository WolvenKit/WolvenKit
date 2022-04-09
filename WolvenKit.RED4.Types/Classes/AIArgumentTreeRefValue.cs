using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentTreeRefValue : AIArgumentDefinition
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
		public CHandle<AIbehaviorParameterizedBehavior> DefaultValue
		{
			get => GetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>();
			set => SetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>(value);
		}

		public AIArgumentTreeRefValue()
		{
			Type = Enums.AIArgumentType.TreeRef;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
