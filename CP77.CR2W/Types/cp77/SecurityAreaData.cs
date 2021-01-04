using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaData : CVariable
	{
		[Ordinal(0)]  [RED("accessLevel")] public CEnum<ESecurityAccessLevel> AccessLevel { get; set; }
		[Ordinal(1)]  [RED("entered")] public CBool Entered { get; set; }
		[Ordinal(2)]  [RED("id")] public gamePersistentID Id { get; set; }
		[Ordinal(3)]  [RED("incomingFilters")] public CEnum<EFilterType> IncomingFilters { get; set; }
		[Ordinal(4)]  [RED("outgoingFilters")] public CEnum<EFilterType> OutgoingFilters { get; set; }
		[Ordinal(5)]  [RED("securityArea")] public wCHandle<SecurityAreaControllerPS> SecurityArea { get; set; }
		[Ordinal(6)]  [RED("securityAreaType")] public CEnum<ESecurityAreaType> SecurityAreaType { get; set; }
		[Ordinal(7)]  [RED("zoneName")] public CString ZoneName { get; set; }

		public SecurityAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
