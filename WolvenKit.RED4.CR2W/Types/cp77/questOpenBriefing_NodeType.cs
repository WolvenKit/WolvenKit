using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOpenBriefing_NodeType : questIUIManagerNodeType
	{
		private CHandle<gameJournalPath> _briefingPath;

		[Ordinal(0)] 
		[RED("briefingPath")] 
		public CHandle<gameJournalPath> BriefingPath
		{
			get
			{
				if (_briefingPath == null)
				{
					_briefingPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "briefingPath", cr2w, this);
				}
				return _briefingPath;
			}
			set
			{
				if (_briefingPath == value)
				{
					return;
				}
				_briefingPath = value;
				PropertySet(this);
			}
		}

		public questOpenBriefing_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
