using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTagAppearanceMapping : audioAudioMetadata
	{
		private CArray<audioVoiceTagAppearanceGroup> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<audioVoiceTagAppearanceGroup> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}
	}
}
