using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CompareArgumentsBooleans : CompareArguments
	{
		[Ordinal(0)]  [RED("var1")] public CName Var1 { get; set; }
		[Ordinal(1)]  [RED("var2")] public CName Var2 { get; set; }

		public CompareArgumentsBooleans(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
