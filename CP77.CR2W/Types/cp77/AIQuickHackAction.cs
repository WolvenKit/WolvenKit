using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIQuickHackAction : PuppetAction
	{
		[Ordinal(25)] [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public AIQuickHackAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
