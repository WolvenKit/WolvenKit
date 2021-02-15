using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionUploadListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public ActionUploadListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
