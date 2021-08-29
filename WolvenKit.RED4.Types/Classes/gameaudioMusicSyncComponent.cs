using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioMusicSyncComponent : entIComponent
	{
		private CBool _notifyBeats;
		private CBool _notifyBars;
		private CBool _notifyGrid;
		private CBool _notifyBarProgression;
		private CBool _notifyBeatProgression;
		private CName _syncTrack;

		[Ordinal(3)] 
		[RED("notifyBeats")] 
		public CBool NotifyBeats
		{
			get => GetProperty(ref _notifyBeats);
			set => SetProperty(ref _notifyBeats, value);
		}

		[Ordinal(4)] 
		[RED("notifyBars")] 
		public CBool NotifyBars
		{
			get => GetProperty(ref _notifyBars);
			set => SetProperty(ref _notifyBars, value);
		}

		[Ordinal(5)] 
		[RED("notifyGrid")] 
		public CBool NotifyGrid
		{
			get => GetProperty(ref _notifyGrid);
			set => SetProperty(ref _notifyGrid, value);
		}

		[Ordinal(6)] 
		[RED("notifyBarProgression")] 
		public CBool NotifyBarProgression
		{
			get => GetProperty(ref _notifyBarProgression);
			set => SetProperty(ref _notifyBarProgression, value);
		}

		[Ordinal(7)] 
		[RED("notifyBeatProgression")] 
		public CBool NotifyBeatProgression
		{
			get => GetProperty(ref _notifyBeatProgression);
			set => SetProperty(ref _notifyBeatProgression, value);
		}

		[Ordinal(8)] 
		[RED("syncTrack")] 
		public CName SyncTrack
		{
			get => GetProperty(ref _syncTrack);
			set => SetProperty(ref _syncTrack, value);
		}
	}
}
