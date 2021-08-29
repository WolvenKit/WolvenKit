using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedJournalUpdate : redEvent
	{
		private CBool _newMessageSpawned;

		[Ordinal(0)] 
		[RED("newMessageSpawned")] 
		public CBool NewMessageSpawned
		{
			get => GetProperty(ref _newMessageSpawned);
			set => SetProperty(ref _newMessageSpawned, value);
		}
	}
}
