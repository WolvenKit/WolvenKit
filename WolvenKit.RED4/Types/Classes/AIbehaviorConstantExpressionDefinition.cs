using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorConstantExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public AIbehaviorTypeRef Type
		{
			get => GetPropertyValue<AIbehaviorTypeRef>();
			set => SetPropertyValue<AIbehaviorTypeRef>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public AIbehaviorConstantExpressionDefinition()
		{
			Type = new AIbehaviorTypeRef { IsSet = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
