using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTagGroup : audioAudioMetadata
	{
		private CArray<CName> _voiceTags;

		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<CName> VoiceTags
		{
			get => GetProperty(ref _voiceTags);
			set => SetProperty(ref _voiceTags, value);
		}
	}
}
