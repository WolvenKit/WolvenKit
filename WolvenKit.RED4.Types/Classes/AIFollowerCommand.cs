using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowerCommand : AICommand
	{
		private CBool _combatCommand;

		[Ordinal(4)] 
		[RED("combatCommand")] 
		public CBool CombatCommand
		{
			get => GetProperty(ref _combatCommand);
			set => SetProperty(ref _combatCommand, value);
		}
	}
}
