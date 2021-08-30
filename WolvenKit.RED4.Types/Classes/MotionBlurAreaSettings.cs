using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MotionBlurAreaSettings : IAreaSettings
	{
		private CFloat _strength;

		[Ordinal(2)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		public MotionBlurAreaSettings()
		{
			_strength = 0.200000F;
		}
	}
}
