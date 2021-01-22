using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardSerializableID : CVariable
	{
		[Ordinal(0)]  [RED("blackboardName")] public CName BlackboardName { get; set; }
		[Ordinal(1)]  [RED("fieldName")] public CName FieldName { get; set; }

		public gameBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
