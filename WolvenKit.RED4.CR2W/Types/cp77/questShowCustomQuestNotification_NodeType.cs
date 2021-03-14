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
			get
			{
				if (_customQuestNotificationData == null)
				{
					_customQuestNotificationData = (questCustomQuestNotificationData) CR2WTypeManager.Create("questCustomQuestNotificationData", "customQuestNotificationData", cr2w, this);
				}
				return _customQuestNotificationData;
			}
			set
			{
				if (_customQuestNotificationData == value)
				{
					return;
				}
				_customQuestNotificationData = value;
				PropertySet(this);
			}
		}

		public questShowCustomQuestNotification_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
