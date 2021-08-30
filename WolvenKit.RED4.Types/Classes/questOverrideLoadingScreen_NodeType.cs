using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOverrideLoadingScreen_NodeType : questIUIManagerNodeType
	{
		private CResourceAsyncReference<Bink> _video;
		private CArray<CResourceAsyncReference<Bink>> _videos;
		private CUInt32 _minimumPlayCount;
		private CBool _forceVideoFrameRate;
		private CArray<CString> _tooltips;
		private CFloat _tooltipDuration;
		private CFloat _glitchEffectTime;
		private CBool _keepLoadingScreenWhileVideoIsPlaying;

		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(1)] 
		[RED("videos")] 
		public CArray<CResourceAsyncReference<Bink>> Videos
		{
			get => GetProperty(ref _videos);
			set => SetProperty(ref _videos, value);
		}

		[Ordinal(2)] 
		[RED("minimumPlayCount")] 
		public CUInt32 MinimumPlayCount
		{
			get => GetProperty(ref _minimumPlayCount);
			set => SetProperty(ref _minimumPlayCount, value);
		}

		[Ordinal(3)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetProperty(ref _forceVideoFrameRate);
			set => SetProperty(ref _forceVideoFrameRate, value);
		}

		[Ordinal(4)] 
		[RED("tooltips")] 
		public CArray<CString> Tooltips
		{
			get => GetProperty(ref _tooltips);
			set => SetProperty(ref _tooltips, value);
		}

		[Ordinal(5)] 
		[RED("tooltipDuration")] 
		public CFloat TooltipDuration
		{
			get => GetProperty(ref _tooltipDuration);
			set => SetProperty(ref _tooltipDuration, value);
		}

		[Ordinal(6)] 
		[RED("glitchEffectTime")] 
		public CFloat GlitchEffectTime
		{
			get => GetProperty(ref _glitchEffectTime);
			set => SetProperty(ref _glitchEffectTime, value);
		}

		[Ordinal(7)] 
		[RED("keepLoadingScreenWhileVideoIsPlaying")] 
		public CBool KeepLoadingScreenWhileVideoIsPlaying
		{
			get => GetProperty(ref _keepLoadingScreenWhileVideoIsPlaying);
			set => SetProperty(ref _keepLoadingScreenWhileVideoIsPlaying, value);
		}

		public questOverrideLoadingScreen_NodeType()
		{
			_minimumPlayCount = 3;
			_tooltipDuration = 1.500000F;
		}
	}
}
