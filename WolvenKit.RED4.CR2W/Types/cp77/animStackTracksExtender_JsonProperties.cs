using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTracksExtender_JsonProperties : ISerializable
	{
		private CArray<animStackTracksExtender_JsonEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animStackTracksExtender_JsonEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<animStackTracksExtender_JsonEntry>) CR2WTypeManager.Create("array:animStackTracksExtender_JsonEntry", "entries", cr2w, this);
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

		public animStackTracksExtender_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
