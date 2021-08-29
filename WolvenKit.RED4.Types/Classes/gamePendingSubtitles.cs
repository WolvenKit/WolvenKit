using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePendingSubtitles : RedBaseClass
	{
		private CArray<scnDialogLineData> _pendingSubtitles;

		[Ordinal(0)] 
		[RED("pendingSubtitles")] 
		public CArray<scnDialogLineData> PendingSubtitles
		{
			get => GetProperty(ref _pendingSubtitles);
			set => SetProperty(ref _pendingSubtitles, value);
		}
	}
}
