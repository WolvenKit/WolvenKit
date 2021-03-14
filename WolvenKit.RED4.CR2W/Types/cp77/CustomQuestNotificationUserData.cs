using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationUserData : inkGameNotificationData
	{
		private questCustomQuestNotificationData _data;

		[Ordinal(6)] 
		[RED("data")] 
		public questCustomQuestNotificationData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (questCustomQuestNotificationData) CR2WTypeManager.Create("questCustomQuestNotificationData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public CustomQuestNotificationUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
