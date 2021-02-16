using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConfessionalInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(17)] [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(18)] [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(19)] [RED("defaultTextWidget")] public wCHandle<inkTextWidget> DefaultTextWidget { get; set; }
		[Ordinal(20)] [RED("actionsList")] public wCHandle<inkWidget> ActionsList { get; set; }
		[Ordinal(21)] [RED("RunningAnimation")] public CHandle<inkanimProxy> RunningAnimation { get; set; }
		[Ordinal(22)] [RED("isConfessing")] public CBool IsConfessing { get; set; }
		[Ordinal(23)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(24)] [RED("onConfessListener")] public CUInt32 OnConfessListener { get; set; }

		public ConfessionalInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
