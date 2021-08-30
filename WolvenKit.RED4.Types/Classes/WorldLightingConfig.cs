using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldLightingConfig : RedBaseClass
	{
		private CFloat _lightAttenuationClamp;

		[Ordinal(0)] 
		[RED("lightAttenuationClamp")] 
		public CFloat LightAttenuationClamp
		{
			get => GetProperty(ref _lightAttenuationClamp);
			set => SetProperty(ref _lightAttenuationClamp, value);
		}

		public WorldLightingConfig()
		{
			_lightAttenuationClamp = 96.000000F;
		}
	}
}
