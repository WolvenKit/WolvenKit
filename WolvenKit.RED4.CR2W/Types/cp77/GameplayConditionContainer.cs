using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayConditionContainer : IScriptable
	{
		private CEnum<ELogicOperator> _logicOperator;
		private CArray<ConditionGroupData> _conditionGroups;

		[Ordinal(0)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetProperty(ref _logicOperator);
			set => SetProperty(ref _logicOperator, value);
		}

		[Ordinal(1)] 
		[RED("conditionGroups")] 
		public CArray<ConditionGroupData> ConditionGroups
		{
			get => GetProperty(ref _conditionGroups);
			set => SetProperty(ref _conditionGroups, value);
		}

		public GameplayConditionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
