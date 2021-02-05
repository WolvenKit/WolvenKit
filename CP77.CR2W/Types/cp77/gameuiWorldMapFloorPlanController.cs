using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapFloorPlanController : gameuiMinimapContainerController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("rootZoneSafety")] public CHandle<inkWidget> RootZoneSafety { get; set; }
		[Ordinal(8)]  [RED("locationTextWidget")] public inkTextWidgetReference LocationTextWidget { get; set; }
		[Ordinal(9)]  [RED("fluffText1")] public inkTextWidgetReference FluffText1 { get; set; }
		[Ordinal(10)]  [RED("securityAreaVignetteWidget")] public inkWidgetReference SecurityAreaVignetteWidget { get; set; }
		[Ordinal(11)]  [RED("securityAreaText")] public inkTextWidgetReference SecurityAreaText { get; set; }
		[Ordinal(12)]  [RED("messageCounter")] public inkWidgetReference MessageCounter { get; set; }
		[Ordinal(13)]  [RED("combatModeHighlight")] public inkWidgetReference CombatModeHighlight { get; set; }
		[Ordinal(14)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(15)]  [RED("zoneVignetteAnimProxy")] public CHandle<inkanimProxy> ZoneVignetteAnimProxy { get; set; }
		[Ordinal(16)]  [RED("inPublicOrRestrictedZone")] public CBool InPublicOrRestrictedZone { get; set; }
		[Ordinal(17)]  [RED("fluffTextCount")] public CInt32 FluffTextCount { get; set; }
		[Ordinal(18)]  [RED("mapBlackboard")] public CHandle<gameIBlackboard> MapBlackboard { get; set; }
		[Ordinal(19)]  [RED("mapDefinition")] public CHandle<UI_MapDef> MapDefinition { get; set; }
		[Ordinal(20)]  [RED("locationDataCallback")] public CUInt32 LocationDataCallback { get; set; }
		[Ordinal(21)]  [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }
		[Ordinal(22)]  [RED("combatAnimation")] public CHandle<inkanimProxy> CombatAnimation { get; set; }
		[Ordinal(23)]  [RED("playerInCombat")] public CBool PlayerInCombat { get; set; }
		[Ordinal(24)]  [RED("zoneNeedsUpdate")] public CBool ZoneNeedsUpdate { get; set; }
		[Ordinal(25)]  [RED("lastZoneType")] public CEnum<ESecurityAreaType> LastZoneType { get; set; }
		[Ordinal(26)]  [RED("messageCounterController")] public wCHandle<inkCompoundWidget> MessageCounterController { get; set; }

		public gameuiWorldMapFloorPlanController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
