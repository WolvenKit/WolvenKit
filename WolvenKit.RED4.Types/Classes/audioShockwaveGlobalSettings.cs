using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("explosionPropagationSpeed")] 
		public CFloat ExplosionPropagationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("thumpPropagationSpeed")] 
		public CFloat ThumpPropagationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("electroshockPropagationSpeed")] 
		public CFloat ElectroshockPropagationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("revealPropagationSpeed")] 
		public CFloat RevealPropagationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioShockwaveGlobalSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
