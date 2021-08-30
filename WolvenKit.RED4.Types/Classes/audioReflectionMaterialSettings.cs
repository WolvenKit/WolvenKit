using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioReflectionMaterialSettings : audioAudioMetadata
	{
		private CFloat _lowPass;
		private CFloat _highPass;
		private CFloat _gain;

		[Ordinal(1)] 
		[RED("lowPass")] 
		public CFloat LowPass
		{
			get => GetProperty(ref _lowPass);
			set => SetProperty(ref _lowPass, value);
		}

		[Ordinal(2)] 
		[RED("highPass")] 
		public CFloat HighPass
		{
			get => GetProperty(ref _highPass);
			set => SetProperty(ref _highPass, value);
		}

		[Ordinal(3)] 
		[RED("gain")] 
		public CFloat Gain
		{
			get => GetProperty(ref _gain);
			set => SetProperty(ref _gain, value);
		}

		public audioReflectionMaterialSettings()
		{
			_gain = 1.000000F;
		}
	}
}
