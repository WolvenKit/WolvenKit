using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STransformAnimationPlayEventData : RedBaseClass
	{
		private CFloat _timeScale;
		private CBool _looping;
		private CUInt32 _timesPlayed;

		[Ordinal(0)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(1)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetProperty(ref _looping);
			set => SetProperty(ref _looping, value);
		}

		[Ordinal(2)] 
		[RED("timesPlayed")] 
		public CUInt32 TimesPlayed
		{
			get => GetProperty(ref _timesPlayed);
			set => SetProperty(ref _timesPlayed, value);
		}
	}
}
