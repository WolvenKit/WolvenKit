using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalEntryVisited_ConditionType : questIJournalConditionType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _visited;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("visited")] 
		public CBool Visited
		{
			get => GetProperty(ref _visited);
			set => SetProperty(ref _visited, value);
		}

		public questJournalEntryVisited_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
