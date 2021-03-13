using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("bountyCollectedUpdateAnimation")] public CName BountyCollectedUpdateAnimation { get; set; }

		public BountyCollectedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
