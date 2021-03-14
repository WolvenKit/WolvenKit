using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetAIManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CArray<questPuppetAIManagerNodeDefinitionEntry> _entries;

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<questPuppetAIManagerNodeDefinitionEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<questPuppetAIManagerNodeDefinitionEntry>) CR2WTypeManager.Create("array:questPuppetAIManagerNodeDefinitionEntry", "entries", cr2w, this);
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

		public questPuppetAIManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
