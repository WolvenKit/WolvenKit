using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestIllegalActionAreaNotification : redEvent
	{
		private RevealPlayerSettings _revealPlayerSettings;

		[Ordinal(0)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetProperty(ref _revealPlayerSettings);
			set => SetProperty(ref _revealPlayerSettings, value);
		}
	}
}
