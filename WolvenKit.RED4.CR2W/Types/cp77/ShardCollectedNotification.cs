using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("shardTitle")] public inkTextWidgetReference ShardTitle { get; set; }

		public ShardCollectedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
