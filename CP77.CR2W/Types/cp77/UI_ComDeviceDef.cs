using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ComDeviceDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("comDeviceSetStatusText")] public gamebbScriptID_CName ComDeviceSetStatusText { get; set; }
		[Ordinal(1)]  [RED("openMessageRequest")] public gamebbScriptID_Uint32 OpenMessageRequest { get; set; }
		[Ordinal(2)]  [RED("closeMessageRequest")] public gamebbScriptID_Int32 CloseMessageRequest { get; set; }
		[Ordinal(3)]  [RED("showingMessage")] public gamebbScriptID_Int32 ShowingMessage { get; set; }
		[Ordinal(4)]  [RED("PhoneCallInformation")] public gamebbScriptID_Variant PhoneCallInformation { get; set; }
		[Ordinal(5)]  [RED("PhoneStyle_PlacidePhone")] public gamebbScriptID_Bool PhoneStyle_PlacidePhone { get; set; }
		[Ordinal(6)]  [RED("PhoneStyle_VideoCallInterupt")] public gamebbScriptID_Bool PhoneStyle_VideoCallInterupt { get; set; }
		[Ordinal(7)]  [RED("PhoneStyle_Minimized")] public gamebbScriptID_Bool PhoneStyle_Minimized { get; set; }
		[Ordinal(8)]  [RED("isDisplayingMessage")] public gamebbScriptID_Bool IsDisplayingMessage { get; set; }
		[Ordinal(9)]  [RED("ContactsActive")] public gamebbScriptID_Bool ContactsActive { get; set; }

		public UI_ComDeviceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
