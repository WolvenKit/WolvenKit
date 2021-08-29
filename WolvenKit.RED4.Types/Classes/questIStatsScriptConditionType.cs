using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIStatsScriptConditionType : questIStatsConditionType
	{
		private CHandle<IScriptable> _scriptCondition;

		[Ordinal(0)] 
		[RED("scriptCondition")] 
		public CHandle<IScriptable> ScriptCondition
		{
			get => GetProperty(ref _scriptCondition);
			set => SetProperty(ref _scriptCondition, value);
		}
	}
}
