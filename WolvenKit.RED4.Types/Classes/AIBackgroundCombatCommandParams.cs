using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBackgroundCombatCommandParams : questScriptedAICommandParams
	{
		private CArray<AIBackgroundCombatStep> _steps;

		[Ordinal(0)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetProperty(ref _steps);
			set => SetProperty(ref _steps, value);
		}
	}
}
