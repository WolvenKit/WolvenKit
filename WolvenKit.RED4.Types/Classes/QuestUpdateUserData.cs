using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestUpdateUserData : inkGameNotificationData
	{
		private CWeakHandle<gameJournalQuest> _data;

		[Ordinal(6)] 
		[RED("data")] 
		public CWeakHandle<gameJournalQuest> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
