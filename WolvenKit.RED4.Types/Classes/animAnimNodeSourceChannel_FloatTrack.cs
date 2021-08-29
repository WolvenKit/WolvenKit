using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNodeSourceChannel_FloatTrack : animIAnimNodeSourceChannel_Float
	{
		private animNamedTrackIndex _floatTrack;
		private CBool _useComplementValue;

		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(1)] 
		[RED("useComplementValue")] 
		public CBool UseComplementValue
		{
			get => GetProperty(ref _useComplementValue);
			set => SetProperty(ref _useComplementValue, value);
		}
	}
}
