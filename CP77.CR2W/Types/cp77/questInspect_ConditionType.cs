using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInspect_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] [RED("objectID")] public CString ObjectID { get; set; }
		[Ordinal(1)] [RED("inverted")] public CBool Inverted { get; set; }

		public questInspect_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
