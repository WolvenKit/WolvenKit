using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestUpdateUserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("data")] public wCHandle<gameJournalQuest> Data { get; set; }

		public QuestUpdateUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
