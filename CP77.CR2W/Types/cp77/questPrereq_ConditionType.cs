using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPrereq_ConditionType : questISystemConditionType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("isObjectPlayer")] public CBool IsObjectPlayer { get; set; }
		[Ordinal(2)]  [RED("prereq")] public CHandle<gameIPrereq> Prereq { get; set; }

		public questPrereq_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
