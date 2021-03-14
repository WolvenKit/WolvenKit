using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupEvent : redEvent
	{
		private CHandle<JournalNotificationData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<JournalNotificationData>) CR2WTypeManager.Create("handle:JournalNotificationData", "data", cr2w, this);
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

		public PhoneMessagePopupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
