using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerControllerPS : TerminalControllerPS
	{
		[Ordinal(113)] [RED("computerSetup")] public ComputerSetup ComputerSetup { get; set; }
		[Ordinal(114)] [RED("quickHackSetup")] public ComputerQuickHackData QuickHackSetup { get; set; }
		[Ordinal(115)] [RED("activatorActionSetup")] public CEnum<EToggleActivationTypeComputer> ActivatorActionSetup { get; set; }
		[Ordinal(116)] [RED("computerSkillChecks")] public CHandle<HackEngContainer> ComputerSkillChecks { get; set; }
		[Ordinal(117)] [RED("openedMailAdress")] public SDocumentAdress OpenedMailAdress { get; set; }
		[Ordinal(118)] [RED("openedFileAdress")] public SDocumentAdress OpenedFileAdress { get; set; }
		[Ordinal(119)] [RED("quickhackPerformed")] public CBool QuickhackPerformed { get; set; }
		[Ordinal(120)] [RED("isInSleepMode")] public CBool IsInSleepMode { get; set; }

		public ComputerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
