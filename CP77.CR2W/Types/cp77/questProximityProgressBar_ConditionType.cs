using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		[Ordinal(0)]  [RED("action")] public CEnum<questProximityProgressBarAction> Action { get; set; }

		public questProximityProgressBar_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
