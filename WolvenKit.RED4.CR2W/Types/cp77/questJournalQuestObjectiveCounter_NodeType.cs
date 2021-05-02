using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestObjectiveCounter_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		public questJournalQuestObjectiveCounter_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
