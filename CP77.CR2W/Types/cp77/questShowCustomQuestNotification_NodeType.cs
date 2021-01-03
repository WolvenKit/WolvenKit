using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questShowCustomQuestNotification_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("customQuestNotificationData")] public questCustomQuestNotificationData CustomQuestNotificationData { get; set; }

		public questShowCustomQuestNotification_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
