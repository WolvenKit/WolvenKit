using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyNames : CVariable
	{
		[Ordinal(0)]  [RED("ParentAnimName")] public CName ParentAnimName { get; set; }
		[Ordinal(1)]  [RED("ChildAnimName")] public CName ChildAnimName { get; set; }

		public physicsRagdollBodyNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
