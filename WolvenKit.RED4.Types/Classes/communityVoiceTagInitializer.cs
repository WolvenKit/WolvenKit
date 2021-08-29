using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityVoiceTagInitializer : communitySpawnInitializer
	{
		private CName _voiceTagName;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetProperty(ref _voiceTagName);
			set => SetProperty(ref _voiceTagName, value);
		}
	}
}
