using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		[Ordinal(1)] [RED("callPhase")] public CEnum<questPhoneCallPhase> CallPhase { get; set; }

		public questPhoneCallPhase_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
