using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqDefinition : CVariable
	{
		[Ordinal(0)] [RED("prereqName")] public CName PrereqName { get; set; }
		[Ordinal(1)] [RED("prereq")] public CHandle<gameIPrereq> Prereq { get; set; }

		public gamePrereqDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
