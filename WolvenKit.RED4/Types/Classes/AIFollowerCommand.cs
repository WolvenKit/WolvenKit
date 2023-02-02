using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("combatCommand")] 
		public CBool CombatCommand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIFollowerCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
