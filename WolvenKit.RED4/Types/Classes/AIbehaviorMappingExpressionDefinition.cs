using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMappingExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("mapping")] 
		public CHandle<AIArgumentMapping> Mapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("update")] 
		public CBool Update
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AIbehaviorMappingExpressionDefinition()
		{
			BehaviorCallbackNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
