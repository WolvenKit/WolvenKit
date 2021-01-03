using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhoneSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("Blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("BlackboardSystem")] public CHandle<gameBlackboardSystem> BlackboardSystem { get; set; }
		[Ordinal(2)]  [RED("ContactsOpen")] public CBool ContactsOpen { get; set; }
		[Ordinal(3)]  [RED("ContactsOpenBBId")] public CUInt32 ContactsOpenBBId { get; set; }
		[Ordinal(4)]  [RED("LastCallInformation")] public questPhoneCallInformation LastCallInformation { get; set; }

		public PhoneSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
