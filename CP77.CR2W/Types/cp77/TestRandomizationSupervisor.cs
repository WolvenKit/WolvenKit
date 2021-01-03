using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		[Ordinal(0)]  [RED("firstWasGenerated")] public CBool FirstWasGenerated { get; set; }

		public TestRandomizationSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
