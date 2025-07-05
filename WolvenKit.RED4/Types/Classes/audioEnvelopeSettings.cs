using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEnvelopeSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("releaseTime")] 
		public CFloat ReleaseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("holdTime")] 
		public CFloat HoldTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioEnvelopeSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
