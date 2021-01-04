using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("entries")] public CArray<CString> Entries { get; set; }
		[Ordinal(1)]  [RED("maxSize")] public CInt32 MaxSize { get; set; }
		[Ordinal(2)]  [RED("onHide")] public CUInt32 OnHide { get; set; }
		[Ordinal(3)]  [RED("onNewEntries")] public CUInt32 OnNewEntries { get; set; }
		[Ordinal(4)]  [RED("panel")] public inkVerticalPanelWidgetReference Panel { get; set; }
		[Ordinal(5)]  [RED("readIndex")] public CInt32 ReadIndex { get; set; }
		[Ordinal(6)]  [RED("writeIndex")] public CInt32 WriteIndex { get; set; }

		public activityLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
