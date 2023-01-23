using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("voTriggerVariations")] 
		public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations
		{
			get => GetPropertyValue<CArray<audioCombatVoTriggerVariationsMapItem>>();
			set => SetPropertyValue<CArray<audioCombatVoTriggerVariationsMapItem>>(value);
		}

		public audioCombatVoTriggerVariationsMap()
		{
			VoTriggerVariations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
