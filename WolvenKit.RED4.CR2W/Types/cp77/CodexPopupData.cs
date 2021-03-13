using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("entry")] public wCHandle<gameJournalEntry> Entry { get; set; }

		public CodexPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
