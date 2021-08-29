using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LogicalCondition : workIScriptedCondition
	{
		private CEnum<WorkspotConditionOperators> _operation;
		private CArray<CHandle<workIScriptedCondition>> _conditions;

		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<WorkspotConditionOperators> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<workIScriptedCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}
