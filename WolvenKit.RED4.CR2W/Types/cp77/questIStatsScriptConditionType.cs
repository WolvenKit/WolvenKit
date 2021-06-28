using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIStatsScriptConditionType : questIStatsConditionType
	{
		private CHandle<IScriptable> _scriptCondition;

		[Ordinal(0)] 
		[RED("scriptCondition")] 
		public CHandle<IScriptable> ScriptCondition
		{
			get => GetProperty(ref _scriptCondition);
			set => SetProperty(ref _scriptCondition, value);
		}

		public questIStatsScriptConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
