using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallMode_ConditionType : questIPhoneConditionType
	{
		[Ordinal(0)]  [RED("callMode")] public CEnum<questPhoneCallMode> CallMode { get; set; }

		public questPhoneCallMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
