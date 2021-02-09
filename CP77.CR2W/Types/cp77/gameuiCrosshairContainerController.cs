using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairContainerController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("defaultCrosshair")] public TweakDBID DefaultCrosshair { get; set; }
		[Ordinal(8)]  [RED("sprintWidget")] public inkWidgetReference SprintWidget { get; set; }
		[Ordinal(9)]  [RED("bbUIData")] public CHandle<gameIBlackboard> BbUIData { get; set; }
		[Ordinal(10)]  [RED("bbWeaponInfo")] public wCHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(11)]  [RED("bbPlayerTierEventId")] public CUInt32 BbPlayerTierEventId { get; set; }
		[Ordinal(12)]  [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(13)]  [RED("interactionBlackboardId")] public CUInt32 InteractionBlackboardId { get; set; }
		[Ordinal(14)]  [RED("crosshairStateBlackboardId")] public CUInt32 CrosshairStateBlackboardId { get; set; }
		[Ordinal(15)]  [RED("isMountedBlackboardId")] public CUInt32 IsMountedBlackboardId { get; set; }
		[Ordinal(16)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(17)]  [RED("fadeOutAnimation")] public CHandle<inkanimDefinition> FadeOutAnimation { get; set; }
		[Ordinal(18)]  [RED("fadeInAnimation")] public CHandle<inkanimDefinition> FadeInAnimation { get; set; }
		[Ordinal(19)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(20)]  [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(21)]  [RED("isMounted")] public CBool IsMounted { get; set; }
		[Ordinal(22)]  [RED("fadeOutValue")] public CFloat FadeOutValue { get; set; }
		[Ordinal(23)]  [RED("wasLastInteractionWithDevice")] public CBool WasLastInteractionWithDevice { get; set; }
		[Ordinal(24)]  [RED("CombatStateBlackboardId")] public CUInt32 CombatStateBlackboardId { get; set; }
		[Ordinal(25)]  [RED("hiddenAnimProxy")] public CHandle<inkanimProxy> HiddenAnimProxy { get; set; }
		[Ordinal(26)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(27)]  [RED("HiddenTextCanvas")] public inkWidgetReference HiddenTextCanvas { get; set; }

		public gameuiCrosshairContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
