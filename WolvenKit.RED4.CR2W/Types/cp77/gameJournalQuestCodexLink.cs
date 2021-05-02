using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestCodexLink : gameJournalEntry
	{
		private CHandle<gameJournalPath> _path;

		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		public gameJournalQuestCodexLink(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
