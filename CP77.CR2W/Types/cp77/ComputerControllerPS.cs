using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ComputerControllerPS : TerminalControllerPS
	{
		[Ordinal(0)]  [RED("activatorActionSetup")] public CEnum<EToggleActivationTypeComputer> ActivatorActionSetup { get; set; }
		[Ordinal(1)]  [RED("computerSetup")] public ComputerSetup ComputerSetup { get; set; }
		[Ordinal(2)]  [RED("computerSkillChecks")] public CHandle<HackEngContainer> ComputerSkillChecks { get; set; }
		[Ordinal(3)]  [RED("isInSleepMode")] public CBool IsInSleepMode { get; set; }
		[Ordinal(4)]  [RED("openedFileAdress")] public SDocumentAdress OpenedFileAdress { get; set; }
		[Ordinal(5)]  [RED("openedMailAdress")] public SDocumentAdress OpenedMailAdress { get; set; }
		[Ordinal(6)]  [RED("quickHackSetup")] public ComputerQuickHackData QuickHackSetup { get; set; }
		[Ordinal(7)]  [RED("quickhackPerformed")] public CBool QuickhackPerformed { get; set; }

		public ComputerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
