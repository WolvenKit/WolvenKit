using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCookedMetadataResource : CResource
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<CHandle<audioAudioMetadata>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<audioAudioMetadata>>>();
			set => SetPropertyValue<CArray<CHandle<audioAudioMetadata>>>(value);
		}

		public audioCookedMetadataResource()
		{
			Entries = new();
		}
	}
}
