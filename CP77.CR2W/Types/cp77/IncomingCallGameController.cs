using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IncomingCallGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("contactNameWidget")] public inkTextWidgetReference ContactNameWidget { get; set; }
		[Ordinal(8)]  [RED("phoneBlackboard")] public wCHandle<gameIBlackboard> PhoneBlackboard { get; set; }
		[Ordinal(9)]  [RED("phoneBBDefinition")] public CHandle<UI_ComDeviceDef> PhoneBBDefinition { get; set; }
		[Ordinal(10)]  [RED("phoneCallInfoBBID")] public CUInt32 PhoneCallInfoBBID { get; set; }
		[Ordinal(11)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(12)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public IncomingCallGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
