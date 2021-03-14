using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapper : CVariable
	{
		private CArray<entVertexAnimationMapperEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<entVertexAnimationMapperEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<entVertexAnimationMapperEntry>) CR2WTypeManager.Create("array:entVertexAnimationMapperEntry", "entries", cr2w, this);
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

		public entVertexAnimationMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
