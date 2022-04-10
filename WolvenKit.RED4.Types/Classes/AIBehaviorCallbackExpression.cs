using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIBehaviorCallbackExpression : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("callbackAction")] 
		public CEnum<ECallbackExpressionActions> CallbackAction
		{
			get => GetPropertyValue<CEnum<ECallbackExpressionActions>>();
			set => SetPropertyValue<CEnum<ECallbackExpressionActions>>(value);
		}

		[Ordinal(3)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIBehaviorCallbackExpression()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
