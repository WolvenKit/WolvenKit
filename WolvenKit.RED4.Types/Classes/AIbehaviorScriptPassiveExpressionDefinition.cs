using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorScriptPassiveExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorexpressionScript> _script;

		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehaviorexpressionScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}
	}
}
