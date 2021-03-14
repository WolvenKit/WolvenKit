using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyChangeInventoryCallback : gameInventoryScriptCallback
	{
		private CHandle<ItemsNotificationQueue> _notificationQueue;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CHandle<ItemsNotificationQueue> NotificationQueue
		{
			get
			{
				if (_notificationQueue == null)
				{
					_notificationQueue = (CHandle<ItemsNotificationQueue>) CR2WTypeManager.Create("handle:ItemsNotificationQueue", "notificationQueue", cr2w, this);
				}
				return _notificationQueue;
			}
			set
			{
				if (_notificationQueue == value)
				{
					return;
				}
				_notificationQueue = value;
				PropertySet(this);
			}
		}

		public CurrencyChangeInventoryCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
