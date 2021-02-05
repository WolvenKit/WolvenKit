using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("visionRadiusVehicle")] public CFloat VisionRadiusVehicle { get; set; }
		[Ordinal(8)]  [RED("visionRadiusCombat")] public CFloat VisionRadiusCombat { get; set; }
		[Ordinal(9)]  [RED("visionRadiusQuestArea")] public CFloat VisionRadiusQuestArea { get; set; }
		[Ordinal(10)]  [RED("visionRadiusSecurityArea")] public CFloat VisionRadiusSecurityArea { get; set; }
		[Ordinal(11)]  [RED("visionRadiusInterior")] public CFloat VisionRadiusInterior { get; set; }
		[Ordinal(12)]  [RED("visionRadiusExterior")] public CFloat VisionRadiusExterior { get; set; }
		[Ordinal(13)]  [RED("clampedMappinContainer")] public inkCompoundWidgetReference ClampedMappinContainer { get; set; }
		[Ordinal(14)]  [RED("unclampedMappinContainer")] public inkCompoundWidgetReference UnclampedMappinContainer { get; set; }
		[Ordinal(15)]  [RED("maskWidget")] public inkMaskWidgetReference MaskWidget { get; set; }
		[Ordinal(16)]  [RED("playerIconWidget")] public inkWidgetReference PlayerIconWidget { get; set; }
		[Ordinal(17)]  [RED("compassWidget")] public inkWidgetReference CompassWidget { get; set; }
		[Ordinal(18)]  [RED("worldGeometryContainer")] public inkCanvasWidgetReference WorldGeometryContainer { get; set; }
		[Ordinal(19)]  [RED("worldGeometryCache")] public inkCacheWidgetReference WorldGeometryCache { get; set; }
		[Ordinal(20)]  [RED("geometryLibraryID")] public CName GeometryLibraryID { get; set; }
		[Ordinal(21)]  [RED("timeDisplayWidget")] public inkCompoundWidgetReference TimeDisplayWidget { get; set; }
		[Ordinal(22)]  [RED("rootZoneSafety")] public CHandle<inkWidget> RootZoneSafety { get; set; }
		[Ordinal(23)]  [RED("locationTextWidget")] public inkTextWidgetReference LocationTextWidget { get; set; }
		[Ordinal(24)]  [RED("fluffText1")] public inkTextWidgetReference FluffText1 { get; set; }
		[Ordinal(25)]  [RED("securityAreaVignetteWidget")] public inkWidgetReference SecurityAreaVignetteWidget { get; set; }
		[Ordinal(26)]  [RED("securityAreaText")] public inkTextWidgetReference SecurityAreaText { get; set; }
		[Ordinal(27)]  [RED("messageCounter")] public inkWidgetReference MessageCounter { get; set; }
		[Ordinal(28)]  [RED("combatModeHighlight")] public inkWidgetReference CombatModeHighlight { get; set; }
		[Ordinal(29)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(30)]  [RED("zoneVignetteAnimProxy")] public CHandle<inkanimProxy> ZoneVignetteAnimProxy { get; set; }
		[Ordinal(31)]  [RED("inPublicOrRestrictedZone")] public CBool InPublicOrRestrictedZone { get; set; }
		[Ordinal(32)]  [RED("fluffTextCount")] public CInt32 FluffTextCount { get; set; }
		[Ordinal(33)]  [RED("mapBlackboard")] public CHandle<gameIBlackboard> MapBlackboard { get; set; }
		[Ordinal(34)]  [RED("mapDefinition")] public CHandle<UI_MapDef> MapDefinition { get; set; }
		[Ordinal(35)]  [RED("locationDataCallback")] public CUInt32 LocationDataCallback { get; set; }
		[Ordinal(36)]  [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }
		[Ordinal(37)]  [RED("combatAnimation")] public CHandle<inkanimProxy> CombatAnimation { get; set; }
		[Ordinal(38)]  [RED("playerInCombat")] public CBool PlayerInCombat { get; set; }
		[Ordinal(39)]  [RED("zoneNeedsUpdate")] public CBool ZoneNeedsUpdate { get; set; }
		[Ordinal(40)]  [RED("lastZoneType")] public CEnum<ESecurityAreaType> LastZoneType { get; set; }
		[Ordinal(41)]  [RED("messageCounterController")] public wCHandle<inkCompoundWidget> MessageCounterController { get; set; }

		public gameuiMinimapContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
