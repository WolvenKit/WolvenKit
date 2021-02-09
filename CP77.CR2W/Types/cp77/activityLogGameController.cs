using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
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
