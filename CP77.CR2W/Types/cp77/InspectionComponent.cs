using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InspectionComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("activeClue")] public CString ActiveClue { get; set; }
		[Ordinal(1)]  [RED("animFeature")] public CHandle<AnimFeature_Inspection> AnimFeature { get; set; }
		[Ordinal(2)]  [RED("cumulatedObjRotationX")] public CFloat CumulatedObjRotationX { get; set; }
		[Ordinal(3)]  [RED("cumulatedObjRotationY")] public CFloat CumulatedObjRotationY { get; set; }
		[Ordinal(4)]  [RED("isPlayerInspecting")] public CBool IsPlayerInspecting { get; set; }
		[Ordinal(5)]  [RED("isScanAvailable")] public CBool IsScanAvailable { get; set; }
		[Ordinal(6)]  [RED("lastInspectedObjID")] public entEntityID LastInspectedObjID { get; set; }
		[Ordinal(7)]  [RED("listener")] public CHandle<IScriptable> Listener { get; set; }
		[Ordinal(8)]  [RED("maxObjOffset")] public CFloat MaxObjOffset { get; set; }
		[Ordinal(9)]  [RED("minObjOffset")] public CFloat MinObjOffset { get; set; }
		[Ordinal(10)]  [RED("objectScanned")] public CBool ObjectScanned { get; set; }
		[Ordinal(11)]  [RED("scanningInProgress")] public CBool ScanningInProgress { get; set; }
		[Ordinal(12)]  [RED("slot")] public CString Slot { get; set; }
		[Ordinal(13)]  [RED("timeToScan")] public CFloat TimeToScan { get; set; }
		[Ordinal(14)]  [RED("zoomSpeed")] public CFloat ZoomSpeed { get; set; }

		public InspectionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
