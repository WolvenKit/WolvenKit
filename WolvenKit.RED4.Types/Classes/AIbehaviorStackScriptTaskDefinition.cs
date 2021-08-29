using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIbehaviortaskStackScript> _script;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskStackScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}
	}
}
