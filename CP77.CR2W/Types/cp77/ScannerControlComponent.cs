using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerControlComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(1)]  [RED("currentScanEffect")] public CHandle<gameEffectInstance> CurrentScanEffect { get; set; }
		[Ordinal(2)]  [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }
		[Ordinal(3)]  [RED("scannerTriggerComponentName")] public CName ScannerTriggerComponentName { get; set; }
		[Ordinal(4)]  [RED("scannerTriggerComponent")] public CHandle<entIComponent> ScannerTriggerComponent { get; set; }
		[Ordinal(5)]  [RED("a")] public CHandle<gameStaticTriggerAreaComponent> A { get; set; }
		[Ordinal(6)]  [RED("isScanningPlayer")] public CBool IsScanningPlayer { get; set; }

		public ScannerControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
