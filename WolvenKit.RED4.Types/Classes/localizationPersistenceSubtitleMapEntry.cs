using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class localizationPersistenceSubtitleMapEntry : RedBaseClass
	{
		private CName _subtitleGroup;
		private CResourceAsyncReference<JsonResource> _subtitleFile;

		[Ordinal(0)] 
		[RED("subtitleGroup")] 
		public CName SubtitleGroup
		{
			get => GetProperty(ref _subtitleGroup);
			set => SetProperty(ref _subtitleGroup, value);
		}

		[Ordinal(1)] 
		[RED("subtitleFile")] 
		public CResourceAsyncReference<JsonResource> SubtitleFile
		{
			get => GetProperty(ref _subtitleFile);
			set => SetProperty(ref _subtitleFile, value);
		}
	}
}
