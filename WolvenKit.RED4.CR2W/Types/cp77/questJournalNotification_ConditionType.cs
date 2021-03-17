using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalNotification_ConditionType : questIUIConditionType
	{
		private CHandle<gameJournalPath> _journalPath;

		[Ordinal(0)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get => GetProperty(ref _journalPath);
			set => SetProperty(ref _journalPath, value);
		}

		public questJournalNotification_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
