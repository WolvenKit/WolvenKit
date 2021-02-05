using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("readIndex")] public CInt32 ReadIndex { get; set; }
		[Ordinal(8)]  [RED("writeIndex")] public CInt32 WriteIndex { get; set; }
		[Ordinal(9)]  [RED("maxSize")] public CInt32 MaxSize { get; set; }
		[Ordinal(10)]  [RED("entries")] public CArray<CString> Entries { get; set; }
		[Ordinal(11)]  [RED("panel")] public inkVerticalPanelWidgetReference Panel { get; set; }
		[Ordinal(12)]  [RED("onNewEntries")] public CUInt32 OnNewEntries { get; set; }
		[Ordinal(13)]  [RED("onHide")] public CUInt32 OnHide { get; set; }

		public activityLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
