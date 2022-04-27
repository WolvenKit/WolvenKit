using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientPaletteBrushDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioAmbientPaletteBrush Value
		{
			get => GetPropertyValue<audioAmbientPaletteBrush>();
			set => SetPropertyValue<audioAmbientPaletteBrush>(value);
		}

		public audioAmbientPaletteBrushDictionaryItem()
		{
			Value = new() { DistributionBucketSize = 10.000000F, VirtualHearingRadius = 10.000000F, HearingDistanceCooldown = 1.000000F, EventsPool = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
