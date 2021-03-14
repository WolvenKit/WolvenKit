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
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<CHandle<audioAudioMetadata>>) CR2WTypeManager.Create("array:handle:audioAudioMetadata", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public audioCookedMetadataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
