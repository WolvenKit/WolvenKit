using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorRepeatNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("limit")] 
		public CHandle<AIArgumentMapping> Limit
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("repeatChildOnFailure")] 
		public CBool RepeatChildOnFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorRepeatNodeDefinition()
		{
			Limit = new AIArgumentMapping { Type = Enums.AIArgumentType.Int, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Int32" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
