using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIBackgroundCombatCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetPropertyValue<CArray<AIBackgroundCombatStep>>();
			set => SetPropertyValue<CArray<AIBackgroundCombatStep>>(value);
		}

		public AIBackgroundCombatCommand()
		{
			Steps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
