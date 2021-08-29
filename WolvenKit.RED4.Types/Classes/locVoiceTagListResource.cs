using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoiceTagListResource : CResource
	{
		private CArray<locVoiceTag> _voiceTags;

		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<locVoiceTag> VoiceTags
		{
			get => GetProperty(ref _voiceTags);
			set => SetProperty(ref _voiceTags, value);
		}
	}
}
