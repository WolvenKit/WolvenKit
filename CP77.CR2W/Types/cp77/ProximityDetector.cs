using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProximityDetector : Device
	{
		[Ordinal(0)]  [RED("notifiactionType")] public CEnum<ESecurityNotificationType> NotifiactionType { get; set; }
		[Ordinal(1)]  [RED("scanningArea")] public CHandle<gameStaticTriggerAreaComponent> ScanningArea { get; set; }
		[Ordinal(2)]  [RED("scanningAreaName")] public CName ScanningAreaName { get; set; }
		[Ordinal(3)]  [RED("securityAreaType")] public CEnum<ESecurityAreaType> SecurityAreaType { get; set; }
		[Ordinal(4)]  [RED("surroundingArea")] public CHandle<gameStaticTriggerAreaComponent> SurroundingArea { get; set; }
		[Ordinal(5)]  [RED("surroundingAreaName")] public CName SurroundingAreaName { get; set; }

		public ProximityDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
