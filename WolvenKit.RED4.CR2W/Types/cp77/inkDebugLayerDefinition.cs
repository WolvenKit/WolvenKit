using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDebugLayerDefinition : inkLayerDefinition
	{
		private CArray<inkDebugLayerEntry> _entries;

		[Ordinal(8)] 
		[RED("entries")] 
		public CArray<inkDebugLayerEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<inkDebugLayerEntry>) CR2WTypeManager.Create("array:inkDebugLayerEntry", "entries", cr2w, this);
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

		public inkDebugLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
