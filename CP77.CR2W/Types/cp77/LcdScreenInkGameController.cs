using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LcdScreenInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("backgroundWidget")] public wCHandle<inkLeafWidget> BackgroundWidget { get; set; }
		[Ordinal(1)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(2)]  [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(3)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(4)]  [RED("messegeRecord")] public wCHandle<gamedataScreenMessageData_Record> MessegeRecord { get; set; }
		[Ordinal(5)]  [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(6)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(7)]  [RED("onMessegeChangedListener")] public CUInt32 OnMessegeChangedListener { get; set; }
		[Ordinal(8)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public LcdScreenInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
