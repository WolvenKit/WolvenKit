using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalCodexGroup : gameJournalContainerEntry
	{
		private LocalizationString _groupName;

		[Ordinal(2)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get => GetProperty(ref _groupName);
			set => SetProperty(ref _groupName, value);
		}
	}
}
