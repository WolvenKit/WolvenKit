using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TutorialMainController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("currentTutorialStep")] public TutorialStep CurrentTutorialStep { get; set; }
		[Ordinal(1)]  [RED("instructionDesc")] public inkTextWidgetReference InstructionDesc { get; set; }
		[Ordinal(2)]  [RED("instructionPanel")] public inkWidgetReference InstructionPanel { get; set; }
		[Ordinal(3)]  [RED("pointer")] public inkWidgetReference Pointer { get; set; }
		[Ordinal(4)]  [RED("tutorialActive")] public CBool TutorialActive { get; set; }

		public TutorialMainController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
