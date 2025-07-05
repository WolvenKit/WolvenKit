using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LogicalCondition : workIScriptedCondition
	{
		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<WorkspotConditionOperators> Operation
		{
			get => GetPropertyValue<CEnum<WorkspotConditionOperators>>();
			set => SetPropertyValue<CEnum<WorkspotConditionOperators>>(value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<workIScriptedCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<workIScriptedCondition>>>();
			set => SetPropertyValue<CArray<CHandle<workIScriptedCondition>>>(value);
		}

		public LogicalCondition()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
