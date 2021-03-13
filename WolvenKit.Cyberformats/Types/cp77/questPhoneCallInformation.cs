using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallInformation : CVariable
	{
		[Ordinal(0)] [RED("callMode")] public CEnum<questPhoneCallMode> CallMode { get; set; }
		[Ordinal(1)] [RED("isAudioCall")] public CBool IsAudioCall { get; set; }
		[Ordinal(2)] [RED("contactName")] public CName ContactName { get; set; }
		[Ordinal(3)] [RED("isPlayerCalling")] public CBool IsPlayerCalling { get; set; }
		[Ordinal(4)] [RED("callPhase")] public CEnum<questPhoneCallPhase> CallPhase { get; set; }

		public questPhoneCallInformation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
