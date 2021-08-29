using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SequencerLock : redEvent
	{
		private CBool _shouldLock;

		[Ordinal(0)] 
		[RED("shouldLock")] 
		public CBool ShouldLock
		{
			get => GetProperty(ref _shouldLock);
			set => SetProperty(ref _shouldLock, value);
		}
	}
}
