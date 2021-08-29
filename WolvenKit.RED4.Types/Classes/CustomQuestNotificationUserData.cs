using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomQuestNotificationUserData : inkGameNotificationData
	{
		private questCustomQuestNotificationData _data;

		[Ordinal(6)] 
		[RED("data")] 
		public questCustomQuestNotificationData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
