using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LcdScreenSignInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(14)]  [RED("messegeRecord")] public wCHandle<gamedataScreenMessageData_Record> MessegeRecord { get; set; }
		[Ordinal(15)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }
		[Ordinal(16)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(17)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(18)]  [RED("onMessegeChangedListener")] public CUInt32 OnMessegeChangedListener { get; set; }

		public LcdScreenSignInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
