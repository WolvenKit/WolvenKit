using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionRevealExpiredEvent : redEvent
	{
		private gameVisionModeSystemRevealIdentifier _revealId;

		[Ordinal(0)] 
		[RED("revealId")] 
		public gameVisionModeSystemRevealIdentifier RevealId
		{
			get => GetProperty(ref _revealId);
			set => SetProperty(ref _revealId, value);
		}
	}
}
