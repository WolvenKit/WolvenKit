using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class textScrollingAnimController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("scannerDetailsHackLog")] public inkTextWidgetReference ScannerDetailsHackLog { get; set; }
		[Ordinal(2)] [RED("defaultScrollSpeed")] public CFloat DefaultScrollSpeed { get; set; }
		[Ordinal(3)] [RED("playOnInit")] public CBool PlayOnInit { get; set; }
		[Ordinal(4)] [RED("numOfLines")] public CInt32 NumOfLines { get; set; }
		[Ordinal(5)] [RED("numOfStartingLines")] public CInt32 NumOfStartingLines { get; set; }
		[Ordinal(6)] [RED("transparency")] public CFloat Transparency { get; set; }
		[Ordinal(7)] [RED("gapIndex")] public CInt32 GapIndex { get; set; }
		[Ordinal(8)] [RED("binaryOnly")] public CBool BinaryOnly { get; set; }
		[Ordinal(9)] [RED("binaryClusterCount")] public CInt32 BinaryClusterCount { get; set; }
		[Ordinal(10)] [RED("scrollingText")] public ScrollingText ScrollingText { get; set; }
		[Ordinal(11)] [RED("logArray")] public CArray<CString> LogArray { get; set; }
		[Ordinal(12)] [RED("upload_counter")] public CFloat Upload_counter { get; set; }
		[Ordinal(13)] [RED("scrollSpeed")] public CFloat ScrollSpeed { get; set; }
		[Ordinal(14)] [RED("fastScrollSpeed")] public CFloat FastScrollSpeed { get; set; }
		[Ordinal(15)] [RED("panel")] public wCHandle<inkCompoundWidget> Panel { get; set; }
		[Ordinal(16)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(17)] [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(18)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(19)] [RED("lineCount")] public CInt32 LineCount { get; set; }

		public textScrollingAnimController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
