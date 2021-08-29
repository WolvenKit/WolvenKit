using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDelegateExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private AIbehaviorDelegateAttrRef _delegateAttribute;
		private CArray<CName> _behaviorCallbackNames;

		[Ordinal(0)] 
		[RED("delegateAttribute")] 
		public AIbehaviorDelegateAttrRef DelegateAttribute
		{
			get => GetProperty(ref _delegateAttribute);
			set => SetProperty(ref _delegateAttribute, value);
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get => GetProperty(ref _behaviorCallbackNames);
			set => SetProperty(ref _behaviorCallbackNames, value);
		}
	}
}
