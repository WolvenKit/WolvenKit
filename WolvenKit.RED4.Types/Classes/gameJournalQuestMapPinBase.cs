using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestMapPinBase : gameJournalContainerEntry
	{
		private CBool _enableGPS;

		[Ordinal(2)] 
		[RED("enableGPS")] 
		public CBool EnableGPS
		{
			get => GetProperty(ref _enableGPS);
			set => SetProperty(ref _enableGPS, value);
		}
	}
}
