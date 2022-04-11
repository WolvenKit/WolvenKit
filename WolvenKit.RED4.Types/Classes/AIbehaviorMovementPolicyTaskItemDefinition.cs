using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMovementPolicyTaskItemDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<AIbehaviorMovementPolicyTaskFunctions> Function
		{
			get => GetPropertyValue<CEnum<AIbehaviorMovementPolicyTaskFunctions>>();
			set => SetPropertyValue<CEnum<AIbehaviorMovementPolicyTaskFunctions>>(value);
		}

		[Ordinal(1)] 
		[RED("params", 4)] 
		public CStatic<CHandle<AIbehaviorExpressionSocket>> Params
		{
			get => GetPropertyValue<CStatic<CHandle<AIbehaviorExpressionSocket>>>();
			set => SetPropertyValue<CStatic<CHandle<AIbehaviorExpressionSocket>>>(value);
		}

		public AIbehaviorMovementPolicyTaskItemDefinition()
		{
			Params = new(1);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
