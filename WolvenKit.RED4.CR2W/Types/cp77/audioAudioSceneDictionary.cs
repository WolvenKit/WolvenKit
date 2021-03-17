using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioAudioSceneDictionaryItem> _entries;
		private CHandle<audioAudioSceneDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioSceneDictionaryItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAudioSceneDictionaryItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		public audioAudioSceneDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
