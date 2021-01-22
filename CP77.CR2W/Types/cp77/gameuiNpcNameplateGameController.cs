using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("VisionStateBlackboardId")] public CUInt32 VisionStateBlackboardId { get; set; }
		[Ordinal(1)]  [RED("ZoomStateBlackboardId")] public CUInt32 ZoomStateBlackboardId { get; set; }
		[Ordinal(2)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }
		[Ordinal(3)]  [RED("bbBuffsList")] public CUInt32 BbBuffsList { get; set; }
		[Ordinal(4)]  [RED("bbDebuffsList")] public CUInt32 BbDebuffsList { get; set; }
		[Ordinal(5)]  [RED("bbHighLevelStateID")] public CUInt32 BbHighLevelStateID { get; set; }
		[Ordinal(6)]  [RED("bbNameplateData")] public CUInt32 BbNameplateData { get; set; }
		[Ordinal(7)]  [RED("bufferedCharacterRecord")] public CHandle<gamedataCharacter_Record> BufferedCharacterRecord { get; set; }
		[Ordinal(8)]  [RED("bufferedNPC")] public wCHandle<gameObject> BufferedNPC { get; set; }
		[Ordinal(9)]  [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(10)]  [RED("c_DisplayRangeNotAggressive")] public CFloat C_DisplayRangeNotAggressive { get; set; }
		[Ordinal(11)]  [RED("c_MaxDisplayRange")] public CFloat C_MaxDisplayRange { get; set; }
		[Ordinal(12)]  [RED("c_MaxDisplayRangeNotAggressive")] public CFloat C_MaxDisplayRangeNotAggressive { get; set; }
		[Ordinal(13)]  [RED("cachedMappinControllers")] public CArray<wCHandle<gameuiMappinBaseController>> CachedMappinControllers { get; set; }
		[Ordinal(14)]  [RED("chattersSlot")] public inkWidgetReference ChattersSlot { get; set; }
		[Ordinal(15)]  [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(16)]  [RED("damagePreviewBlackboardID")] public CUInt32 DamagePreviewBlackboardID { get; set; }
		[Ordinal(17)]  [RED("displayName")] public inkWidgetReference DisplayName { get; set; }
		[Ordinal(18)]  [RED("iconHolder")] public inkWidgetReference IconHolder { get; set; }
		[Ordinal(19)]  [RED("isNewNPC")] public CBool IsNewNPC { get; set; }
		[Ordinal(20)]  [RED("isScanning")] public CBool IsScanning { get; set; }
		[Ordinal(21)]  [RED("mappinSlot")] public inkWidgetReference MappinSlot { get; set; }
		[Ordinal(22)]  [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(23)]  [RED("nameplateProjection")] public CHandle<inkScreenProjection> NameplateProjection { get; set; }
		[Ordinal(24)]  [RED("nameplateProjectionCloseOffset")] public CHandle<inkScreenProjection> NameplateProjectionCloseOffset { get; set; }
		[Ordinal(25)]  [RED("playerAimStatusBlackboardID")] public CUInt32 PlayerAimStatusBlackboardID { get; set; }
		[Ordinal(26)]  [RED("playerCombatBlackboardID")] public CUInt32 PlayerCombatBlackboardID { get; set; }
		[Ordinal(27)]  [RED("playerZonesBlackboardID")] public CUInt32 PlayerZonesBlackboardID { get; set; }
		[Ordinal(28)]  [RED("projection")] public inkWidgetReference Projection { get; set; }
		[Ordinal(29)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(30)]  [RED("uiBlackboardInteractions")] public CHandle<gameIBlackboard> UiBlackboardInteractions { get; set; }
		[Ordinal(31)]  [RED("uiBlackboardTargetNPC")] public CHandle<gameIBlackboard> UiBlackboardTargetNPC { get; set; }
		[Ordinal(32)]  [RED("visualController")] public wCHandle<NameplateVisualsLogicController> VisualController { get; set; }
		[Ordinal(33)]  [RED("visualControllerNeedsMappinsUpdate")] public CBool VisualControllerNeedsMappinsUpdate { get; set; }
		[Ordinal(34)]  [RED("zoom")] public CFloat Zoom { get; set; }

		public gameuiNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
