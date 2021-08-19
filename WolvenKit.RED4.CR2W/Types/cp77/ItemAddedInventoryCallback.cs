using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemAddedInventoryCallback : gameInventoryScriptCallback
	{
		private wCHandle<ItemsNotificationQueue> _notificationQueue;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public wCHandle<ItemsNotificationQueue> NotificationQueue
		{
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}

		public ItemAddedInventoryCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
