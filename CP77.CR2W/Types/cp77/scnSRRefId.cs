using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSRRefId : CVariable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }

		public scnSRRefId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
