using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StoreMiniGameProgramEvent : redEvent
	{
		[Ordinal(0)] [RED("program")] public gameuiMinigameProgramData Program { get; set; }
		[Ordinal(1)] [RED("add")] public CBool Add { get; set; }

		public StoreMiniGameProgramEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
