using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalNotification_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		public questJournalNotification_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
