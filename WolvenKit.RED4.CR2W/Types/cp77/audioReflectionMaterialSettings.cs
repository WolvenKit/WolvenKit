using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReflectionMaterialSettings : audioAudioMetadata
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

		public audioReflectionMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
