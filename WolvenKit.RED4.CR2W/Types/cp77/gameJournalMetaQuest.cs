using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuest : gameJournalFileEntry
	{
		private LocalizationString _title;

		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		public gameJournalMetaQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
