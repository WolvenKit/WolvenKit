using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(0)]  [RED("bountyNotification")] public CName BountyNotification { get; set; }
		[Ordinal(1)]  [RED("duration")] public CFloat Duration { get; set; }

		public BountyCollectedNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
