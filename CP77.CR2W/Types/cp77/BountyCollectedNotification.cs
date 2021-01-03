using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("bountyCollectedUpdateAnimation")] public CName BountyCollectedUpdateAnimation { get; set; }

		public BountyCollectedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
