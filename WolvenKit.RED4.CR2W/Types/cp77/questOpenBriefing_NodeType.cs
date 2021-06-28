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
			get => GetProperty(ref _briefingPath);
			set => SetProperty(ref _briefingPath, value);
		}

		public questOpenBriefing_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
