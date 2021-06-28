using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCookedMetadataResource : CResource
	{
		private CArray<CHandle<audioAudioMetadata>> _entries;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<CHandle<audioAudioMetadata>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public audioCookedMetadataResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
