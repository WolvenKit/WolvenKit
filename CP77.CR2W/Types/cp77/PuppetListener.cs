using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetListener : IScriptable
	{
		[Ordinal(0)] [RED("prereqOwner")] public CHandle<gamePrereqState> PrereqOwner { get; set; }

		public PuppetListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
