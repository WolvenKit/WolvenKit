using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(1)]  [RED("isDecriptionEnabled")] public CBool IsDecriptionEnabled { get; set; }
		[Ordinal(2)]  [RED("isScanningDisabled")] public CBool IsScanningDisabled { get; set; }
		[Ordinal(3)]  [RED("objectDescriptionOverride")] public CHandle<ObjectScanningDescription> ObjectDescriptionOverride { get; set; }
		[Ordinal(4)]  [RED("pctScanned")] public CFloat PctScanned { get; set; }
		[Ordinal(5)]  [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(6)]  [RED("storedClues")] public CArray<CHandle<CluePSData>> StoredClues { get; set; }

		public gameScanningComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
