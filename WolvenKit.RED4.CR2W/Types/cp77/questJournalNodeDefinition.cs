using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIJournal_NodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIJournal_NodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questJournalNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
