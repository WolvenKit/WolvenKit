using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorExpressionSocket : ISerializable
	{
		[Ordinal(0)] 
		[RED("typeHint")] 
		public AIbehaviorTypeRef TypeHint
		{
			get => GetPropertyValue<AIbehaviorTypeRef>();
			set => SetPropertyValue<AIbehaviorTypeRef>(value);
		}

		[Ordinal(1)] 
		[RED("expression")] 
		public CHandle<AIbehaviorPassiveExpressionDefinition> Expression
		{
			get => GetPropertyValue<CHandle<AIbehaviorPassiveExpressionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorPassiveExpressionDefinition>>(value);
		}

		public AIbehaviorExpressionSocket()
		{
			TypeHint = new();
		}
	}
}
