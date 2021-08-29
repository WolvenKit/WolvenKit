using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCollectedNotification : GenericNotificationController
	{
		private inkTextWidgetReference _shardTitle;

		[Ordinal(12)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetProperty(ref _shardTitle);
			set => SetProperty(ref _shardTitle, value);
		}
	}
}
