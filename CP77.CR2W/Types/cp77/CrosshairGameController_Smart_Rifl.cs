using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Smart_Rifl : gameuiCrosshairBaseGameController
	{
		[Ordinal(16)]  [RED("txtAccuracy")] public inkTextWidgetReference TxtAccuracy { get; set; }
		[Ordinal(17)]  [RED("txtTargetsCount")] public inkTextWidgetReference TxtTargetsCount { get; set; }
		[Ordinal(18)]  [RED("txtFluffStatus")] public inkTextWidgetReference TxtFluffStatus { get; set; }
		[Ordinal(19)]  [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(20)]  [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(21)]  [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(22)]  [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(23)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(24)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(25)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(26)]  [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(27)]  [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(28)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(29)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(30)]  [RED("targetWidgetLibraryName")] public CName TargetWidgetLibraryName { get; set; }
		[Ordinal(31)]  [RED("targetsPullSize")] public CInt32 TargetsPullSize { get; set; }
		[Ordinal(32)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(33)]  [RED("targetingFrame")] public inkWidgetReference TargetingFrame { get; set; }
		[Ordinal(34)]  [RED("reticleFrame")] public inkWidgetReference ReticleFrame { get; set; }
		[Ordinal(35)]  [RED("bufferFrame")] public inkWidgetReference BufferFrame { get; set; }
		[Ordinal(36)]  [RED("targetHolder")] public inkCompoundWidgetReference TargetHolder { get; set; }
		[Ordinal(37)]  [RED("lockHolder")] public inkCompoundWidgetReference LockHolder { get; set; }
		[Ordinal(38)]  [RED("reloadIndicator")] public inkCompoundWidgetReference ReloadIndicator { get; set; }
		[Ordinal(39)]  [RED("reloadIndicatorInv")] public inkCompoundWidgetReference ReloadIndicatorInv { get; set; }
		[Ordinal(40)]  [RED("smartLinkDot")] public inkCompoundWidgetReference SmartLinkDot { get; set; }
		[Ordinal(41)]  [RED("smartLinkFrame")] public inkCompoundWidgetReference SmartLinkFrame { get; set; }
		[Ordinal(42)]  [RED("smartLinkFluff")] public inkCompoundWidgetReference SmartLinkFluff { get; set; }
		[Ordinal(43)]  [RED("smartLinkFirmwareOnline")] public inkCompoundWidgetReference SmartLinkFirmwareOnline { get; set; }
		[Ordinal(44)]  [RED("smartLinkFirmwareOffline")] public inkCompoundWidgetReference SmartLinkFirmwareOffline { get; set; }
		[Ordinal(45)]  [RED("weaponBlackboard")] public wCHandle<gameIBlackboard> WeaponBlackboard { get; set; }
		[Ordinal(46)]  [RED("weaponParamsListenerId")] public CUInt32 WeaponParamsListenerId { get; set; }
		[Ordinal(47)]  [RED("targets")] public CArray<wCHandle<inkWidget>> Targets { get; set; }
		[Ordinal(48)]  [RED("targetsData")] public CArray<gamesmartGunUITargetParameters> TargetsData { get; set; }
		[Ordinal(49)]  [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(50)]  [RED("isAimDownSights")] public CBool IsAimDownSights { get; set; }
		[Ordinal(51)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(52)]  [RED("reloadAnimationProxy")] public CHandle<inkanimProxy> ReloadAnimationProxy { get; set; }
		[Ordinal(53)]  [RED("prevTargetedEntityIDs")] public CArray<entEntityID> PrevTargetedEntityIDs { get; set; }

		public CrosshairGameController_Smart_Rifl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
