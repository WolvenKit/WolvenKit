using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCookedMetadataResource : CResource
	{
		private CArray<CHandle<audioAudioMetadata>> _entries;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<CHandle<audioAudioMetadata>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
