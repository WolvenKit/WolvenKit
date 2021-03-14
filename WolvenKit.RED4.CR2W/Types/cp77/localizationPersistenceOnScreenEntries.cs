using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceOnScreenEntries : ISerializable
	{
		private CArray<localizationPersistenceOnScreenEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<localizationPersistenceOnScreenEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<localizationPersistenceOnScreenEntry>) CR2WTypeManager.Create("array:localizationPersistenceOnScreenEntry", "entries", cr2w, this);
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

		public localizationPersistenceOnScreenEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
