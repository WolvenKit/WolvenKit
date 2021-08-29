using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplAnimTransformSyncElem : RedBaseClass
	{
		private CInt32 _definitionId;
		private CFloat _currentTime;
		private CFloat _timeScale;
		private CFloat _duration;
		private CInt32 _timesToPlay;
		private CBool _playing;

		[Ordinal(0)] 
		[RED("definitionId")] 
		public CInt32 DefinitionId
		{
			get => GetProperty(ref _definitionId);
			set => SetProperty(ref _definitionId, value);
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(2)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get => GetProperty(ref _timesToPlay);
			set => SetProperty(ref _timesToPlay, value);
		}

		[Ordinal(5)] 
		[RED("playing")] 
		public CBool Playing
		{
			get => GetProperty(ref _playing);
			set => SetProperty(ref _playing, value);
		}
	}
}
