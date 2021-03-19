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
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public questPuppetAIManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
