using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetArgumentName : SetArguments
	{
		[Ordinal(0)]  [RED("argumentVar")] public CName ArgumentVar { get; set; }
		[Ordinal(1)]  [RED("customVar")] public CName CustomVar { get; set; }

		public SetArgumentName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
