using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(1)] [RED("pctScanned")] public CFloat PctScanned { get; set; }
		[Ordinal(2)] [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(3)] [RED("storedClues")] public CArray<CHandle<CluePSData>> StoredClues { get; set; }
		[Ordinal(4)] [RED("isScanningDisabled")] public CBool IsScanningDisabled { get; set; }
		[Ordinal(5)] [RED("isDecriptionEnabled")] public CBool IsDecriptionEnabled { get; set; }
		[Ordinal(6)] [RED("objectDescriptionOverride")] public CHandle<ObjectScanningDescription> ObjectDescriptionOverride { get; set; }

		public gameScanningComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
