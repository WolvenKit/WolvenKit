using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AccessPointControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("accessPointSkillChecks")] public CHandle<HackingContainer> AccessPointSkillChecks { get; set; }
		[Ordinal(1)]  [RED("isBreached")] public CBool IsBreached { get; set; }
		[Ordinal(2)]  [RED("isVirtual")] public CBool IsVirtual { get; set; }
		[Ordinal(3)]  [RED("rewardNotificationIcons")] public CArray<CString> RewardNotificationIcons { get; set; }
		[Ordinal(4)]  [RED("rewardNotificationString")] public CString RewardNotificationString { get; set; }

		public AccessPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
