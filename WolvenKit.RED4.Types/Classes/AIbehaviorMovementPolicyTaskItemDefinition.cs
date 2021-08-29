using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorMovementPolicyTaskItemDefinition : ISerializable
	{
		private CEnum<AIbehaviorMovementPolicyTaskFunctions> _function;
		private CStatic<CHandle<AIbehaviorExpressionSocket>> _params;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<AIbehaviorMovementPolicyTaskFunctions> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(1)] 
		[RED("params", 4)] 
		public CStatic<CHandle<AIbehaviorExpressionSocket>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
