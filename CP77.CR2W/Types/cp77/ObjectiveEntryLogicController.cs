using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ObjectiveEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("blinkInterval")] public CFloat BlinkInterval { get; set; }
		[Ordinal(1)]  [RED("blinkTotalTime")] public CFloat BlinkTotalTime { get; set; }
		[Ordinal(2)]  [RED("texturePart_Tracked")] public CName TexturePart_Tracked { get; set; }
		[Ordinal(3)]  [RED("texturePart_Untracked")] public CName TexturePart_Untracked { get; set; }
		[Ordinal(4)]  [RED("texturePart_Succeeded")] public CName TexturePart_Succeeded { get; set; }
		[Ordinal(5)]  [RED("texturePart_Failed")] public CName TexturePart_Failed { get; set; }
		[Ordinal(6)]  [RED("isLargeUpdateWidget")] public CBool IsLargeUpdateWidget { get; set; }
		[Ordinal(7)]  [RED("entryName")] public wCHandle<inkTextWidget> EntryName { get; set; }
		[Ordinal(8)]  [RED("entryOptional")] public wCHandle<inkTextWidget> EntryOptional { get; set; }
		[Ordinal(9)]  [RED("stateIcon")] public wCHandle<inkImageWidget> StateIcon { get; set; }
		[Ordinal(10)]  [RED("trackedIcon")] public wCHandle<inkImageWidget> TrackedIcon { get; set; }
		[Ordinal(11)]  [RED("blinkWidget")] public wCHandle<inkWidget> BlinkWidget { get; set; }
		[Ordinal(12)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(13)]  [RED("animBlinkDef")] public CHandle<inkanimDefinition> AnimBlinkDef { get; set; }
		[Ordinal(14)]  [RED("animBlink")] public CHandle<inkanimProxy> AnimBlink { get; set; }
		[Ordinal(15)]  [RED("animFadeDef")] public CHandle<inkanimDefinition> AnimFadeDef { get; set; }
		[Ordinal(16)]  [RED("animFade")] public CHandle<inkanimProxy> AnimFade { get; set; }
		[Ordinal(17)]  [RED("entryId")] public CInt32 EntryId { get; set; }
		[Ordinal(18)]  [RED("type")] public CEnum<UIObjectiveEntryType> Type { get; set; }
		[Ordinal(19)]  [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }
		[Ordinal(20)]  [RED("parentEntry")] public wCHandle<ObjectiveEntryLogicController> ParentEntry { get; set; }
		[Ordinal(21)]  [RED("childCount")] public CInt32 ChildCount { get; set; }
		[Ordinal(22)]  [RED("updated")] public CBool Updated { get; set; }
		[Ordinal(23)]  [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(24)]  [RED("isOptional")] public CBool IsOptional { get; set; }

		public ObjectiveEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
