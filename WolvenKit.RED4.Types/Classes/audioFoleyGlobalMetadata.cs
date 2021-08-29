using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		private CFloat _fadeoutTime;
		private CName _fadeoutRtpc;

		[Ordinal(1)] 
		[RED("fadeoutTime")] 
		public CFloat FadeoutTime
		{
			get => GetProperty(ref _fadeoutTime);
			set => SetProperty(ref _fadeoutTime, value);
		}

		[Ordinal(2)] 
		[RED("fadeoutRtpc")] 
		public CName FadeoutRtpc
		{
			get => GetProperty(ref _fadeoutRtpc);
			set => SetProperty(ref _fadeoutRtpc, value);
		}
	}
}
