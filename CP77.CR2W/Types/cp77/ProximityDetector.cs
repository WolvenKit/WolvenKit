using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProximityDetector : Device
	{
		[Ordinal(77)]  [RED("scanningAreaName")] public CName ScanningAreaName { get; set; }
		[Ordinal(78)]  [RED("surroundingAreaName")] public CName SurroundingAreaName { get; set; }
		[Ordinal(79)]  [RED("scanningArea")] public CHandle<gameStaticTriggerAreaComponent> ScanningArea { get; set; }
		[Ordinal(80)]  [RED("surroundingArea")] public CHandle<gameStaticTriggerAreaComponent> SurroundingArea { get; set; }
		[Ordinal(81)]  [RED("securityAreaType")] public CEnum<ESecurityAreaType> SecurityAreaType { get; set; }
		[Ordinal(82)]  [RED("notifiactionType")] public CEnum<ESecurityNotificationType> NotifiactionType { get; set; }

		public ProximityDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
