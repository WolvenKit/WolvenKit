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
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}

		public CurrencyChangeInventoryCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
