using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalNotification_ConditionType : questIUIConditionType
	{
		private CHandle<gameJournalPath> _journalPath;

		[Ordinal(0)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get => GetProperty(ref _journalPath);
			set => SetProperty(ref _journalPath, value);
		}
	}
}
