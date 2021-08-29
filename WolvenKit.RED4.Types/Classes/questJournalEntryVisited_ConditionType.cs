using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalEntryVisited_ConditionType : questIJournalConditionType
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
	}
}
