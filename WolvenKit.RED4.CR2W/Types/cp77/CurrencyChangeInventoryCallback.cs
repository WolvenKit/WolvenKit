using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyChangeInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] [RED("notificationQueue")] public CHandle<ItemsNotificationQueue> NotificationQueue { get; set; }

		public CurrencyChangeInventoryCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
