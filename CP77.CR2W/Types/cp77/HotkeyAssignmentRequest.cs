using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HotkeyAssignmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(2)]  [RED("requestType")] public CEnum<EHotkeyRequestType> RequestType { get; set; }

		public HotkeyAssignmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
