using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlitchData : RedBaseClass
	{
		private CFloat _intensity;
		private CEnum<EGlitchState> _state;

		[Ordinal(0)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EGlitchState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
