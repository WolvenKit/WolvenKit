using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHudWidgetSpawnEntry : CVariable
	{
		[Ordinal(0)] [RED("hudEntryName")] public CName HudEntryName { get; set; }
		[Ordinal(1)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)] [RED("contextVisibility")] public CEnum<worlduiContextVisibility> ContextVisibility { get; set; }
		[Ordinal(3)] [RED("gameContextVisibility")] public CEnum<gameuiContext> GameContextVisibility { get; set; }
		[Ordinal(4)] [RED("spawnMode")] public CEnum<inkSpawnMode> SpawnMode { get; set; }
		[Ordinal(5)] [RED("widgetResource")] public rRef<inkWidgetLibraryResource> WidgetResource { get; set; }
		[Ordinal(6)] [RED("anchorPlace")] public CEnum<inkEAnchor> AnchorPlace { get; set; }
		[Ordinal(7)] [RED("anchorPoint")] public Vector2 AnchorPoint { get; set; }
		[Ordinal(8)] [RED("margins")] public inkMargin Margins { get; set; }
		[Ordinal(9)] [RED("attachToSlot")] public CBool AttachToSlot { get; set; }
		[Ordinal(10)] [RED("slotParams")] public inkWidgetSlotAttachmentParams SlotParams { get; set; }
		[Ordinal(11)] [RED("useSeparateWindow")] public CBool UseSeparateWindow { get; set; }
		[Ordinal(12)] [RED("affectedByGlitchEffect")] public CBool AffectedByGlitchEffect { get; set; }
		[Ordinal(13)] [RED("spawnBeforeSlots")] public CBool SpawnBeforeSlots { get; set; }

		public inkHudWidgetSpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
