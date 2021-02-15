using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] [RED("areaType")] public CEnum<ESecurityAreaType> AreaType { get; set; }

		public ZoneAlertNotificationRemoveRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
