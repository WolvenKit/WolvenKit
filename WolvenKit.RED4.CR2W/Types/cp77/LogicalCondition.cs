using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LogicalCondition : workIScriptedCondition
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

		public LogicalCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
