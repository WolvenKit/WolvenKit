using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		private CArray<audioCombatVoTriggerVariationsMapItem> _voTriggerVariations;

		[Ordinal(1)] 
		[RED("voTriggerVariations")] 
		public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations
		{
			get => GetProperty(ref _voTriggerVariations);
			set => SetProperty(ref _voTriggerVariations, value);
		}
	}
}
