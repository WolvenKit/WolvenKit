using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterialDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioAudioFoliageMaterialDictionaryItem> _entries;
		private CHandle<audioAudioFoliageMaterialDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioFoliageMaterialDictionaryItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAudioFoliageMaterialDictionaryItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		public audioAudioFoliageMaterialDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
