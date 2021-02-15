using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		[Ordinal(0)] [RED("firstWasGenerated")] public CBool FirstWasGenerated { get; set; }

		public TestRandomizationSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
