using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowCustomQuestNotification_NodeType : questIUIManagerNodeType
	{
		private questCustomQuestNotificationData _customQuestNotificationData;

		[Ordinal(0)] 
		[RED("customQuestNotificationData")] 
		public questCustomQuestNotificationData CustomQuestNotificationData
		{
			get => GetProperty(ref _customQuestNotificationData);
			set => SetProperty(ref _customQuestNotificationData, value);
		}

		public questShowCustomQuestNotification_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
