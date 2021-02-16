using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaTypeChangedNotification : redEvent
	{
		[Ordinal(0)] [RED("previousType")] public CEnum<ESecurityAreaType> PreviousType { get; set; }
		[Ordinal(1)] [RED("currentType")] public CEnum<ESecurityAreaType> CurrentType { get; set; }
		[Ordinal(2)] [RED("area")] public wCHandle<SecurityAreaControllerPS> Area { get; set; }

		public SecurityAreaTypeChangedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
