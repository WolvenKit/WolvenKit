using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("BlackboardSystem")] public CHandle<gameBlackboardSystem> BlackboardSystem { get; set; }
		[Ordinal(1)] [RED("Blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(2)] [RED("LastCallInformation")] public questPhoneCallInformation LastCallInformation { get; set; }
		[Ordinal(3)] [RED("ContactsOpen")] public CBool ContactsOpen { get; set; }
		[Ordinal(4)] [RED("ContactsOpenBBId")] public CUInt32 ContactsOpenBBId { get; set; }

		public PhoneSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
