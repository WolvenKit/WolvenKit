using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartEndPhoneCallEvent : redEvent
	{
		[Ordinal(0)] [RED("callDuration")] public CFloat CallDuration { get; set; }
		[Ordinal(1)] [RED("startCall")] public CBool StartCall { get; set; }
		[Ordinal(2)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(3)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(4)] [RED("statPoolName")] public CString StatPoolName { get; set; }

		public StartEndPhoneCallEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
