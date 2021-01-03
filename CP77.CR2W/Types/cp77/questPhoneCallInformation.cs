using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallInformation : CVariable
	{
		[Ordinal(0)]  [RED("callMode")] public CEnum<questPhoneCallMode> CallMode { get; set; }
		[Ordinal(1)]  [RED("callPhase")] public CEnum<questPhoneCallPhase> CallPhase { get; set; }
		[Ordinal(2)]  [RED("contactName")] public CName ContactName { get; set; }
		[Ordinal(3)]  [RED("isAudioCall")] public CBool IsAudioCall { get; set; }
		[Ordinal(4)]  [RED("isPlayerCalling")] public CBool IsPlayerCalling { get; set; }

		public questPhoneCallInformation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
