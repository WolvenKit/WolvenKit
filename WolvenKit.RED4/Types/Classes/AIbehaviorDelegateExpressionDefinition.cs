using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDelegateExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("delegateAttribute")] 
		public AIbehaviorDelegateAttrRef DelegateAttribute
		{
			get => GetPropertyValue<AIbehaviorDelegateAttrRef>();
			set => SetPropertyValue<AIbehaviorDelegateAttrRef>(value);
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AIbehaviorDelegateExpressionDefinition()
		{
			DelegateAttribute = new();
			BehaviorCallbackNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
