using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IncomingCallGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("contactNameWidget")] public inkTextWidgetReference ContactNameWidget { get; set; }
		[Ordinal(2)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(3)]  [RED("phoneBBDefinition")] public CHandle<UI_ComDeviceDef> PhoneBBDefinition { get; set; }
		[Ordinal(4)]  [RED("phoneBlackboard")] public CHandle<gameIBlackboard> PhoneBlackboard { get; set; }
		[Ordinal(5)]  [RED("phoneCallInfoBBID")] public CUInt32 PhoneCallInfoBBID { get; set; }

		public IncomingCallGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
