using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CursorGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("bufferSize")] public CInt32 BufferSize { get; set; }
		[Ordinal(2)]  [RED("currentContext")] public CName CurrentContext { get; set; }
		[Ordinal(3)]  [RED("data")] public CHandle<MenuCursorUserData> Data { get; set; }
		[Ordinal(4)]  [RED("isCursorVisible")] public CBool IsCursorVisible { get; set; }
		[Ordinal(5)]  [RED("mainCursor")] public inkWidgetReference MainCursor { get; set; }
		[Ordinal(6)]  [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(7)]  [RED("postponedContexts")] public CArray<PostponedCursorContext> PostponedContexts { get; set; }
		[Ordinal(8)]  [RED("progressBar")] public inkWidgetReference ProgressBar { get; set; }
		[Ordinal(9)]  [RED("readIndex")] public CInt32 ReadIndex { get; set; }
		[Ordinal(10)]  [RED("writeIndex")] public CInt32 WriteIndex { get; set; }

		public CursorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
