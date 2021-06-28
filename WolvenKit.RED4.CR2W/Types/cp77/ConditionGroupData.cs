using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConditionGroupData : CVariable
	{
		private CArray<CHandle<GameplayConditionBase>> _conditions;
		private CEnum<ELogicOperator> _logicOperator;

		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<GameplayConditionBase>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetProperty(ref _logicOperator);
			set => SetProperty(ref _logicOperator, value);
		}

		public ConditionGroupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
