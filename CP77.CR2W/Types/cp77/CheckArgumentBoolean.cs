using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentBoolean : CheckArguments
	{
		[Ordinal(1)] [RED("customVar")] public CBool CustomVar { get; set; }

		public CheckArgumentBoolean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
