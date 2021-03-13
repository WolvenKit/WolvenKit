using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialMainController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("instructionPanel")] public inkWidgetReference InstructionPanel { get; set; }
		[Ordinal(3)] [RED("instructionDesc")] public inkTextWidgetReference InstructionDesc { get; set; }
		[Ordinal(4)] [RED("pointer")] public inkWidgetReference Pointer { get; set; }
		[Ordinal(5)] [RED("tutorialActive")] public CBool TutorialActive { get; set; }
		[Ordinal(6)] [RED("currentTutorialStep")] public TutorialStep CurrentTutorialStep { get; set; }

		public TutorialMainController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
