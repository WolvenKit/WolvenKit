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
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visited")] 
		public CBool Visited
		{
			get
			{
				if (_visited == null)
				{
					_visited = (CBool) CR2WTypeManager.Create("Bool", "visited", cr2w, this);
				}
				return _visited;
			}
			set
			{
				if (_visited == value)
				{
					return;
				}
				_visited = value;
				PropertySet(this);
			}
		}

		public questJournalEntryVisited_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
