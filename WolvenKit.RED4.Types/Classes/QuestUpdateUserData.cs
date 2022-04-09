using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestUpdateUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("data")] 
		public CWeakHandle<gameJournalQuest> Data
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		public QuestUpdateUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
