using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCRevealedPrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("listener")] public CHandle<PuppetListener> Listener { get; set; }

		public NPCRevealedPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
