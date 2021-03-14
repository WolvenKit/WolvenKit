using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventStartStateMachine : redEvent
	{
		[Ordinal(0)] [RED("stateMachineIdentifier")] public gamestateMachineStateMachineIdentifier StateMachineIdentifier { get; set; }

		public gamestateMachineeventStartStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
