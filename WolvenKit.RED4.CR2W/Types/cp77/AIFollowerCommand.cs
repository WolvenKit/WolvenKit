using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerCommand : AICommand
	{
		private CBool _combatCommand;

		[Ordinal(4)] 
		[RED("combatCommand")] 
		public CBool CombatCommand
		{
			get => GetProperty(ref _combatCommand);
			set => SetProperty(ref _combatCommand, value);
		}

		public AIFollowerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
