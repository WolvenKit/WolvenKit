using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestUpdateUserData : inkGameNotificationData
	{
		private wCHandle<gameJournalQuest> _data;

		[Ordinal(6)] 
		[RED("data")] 
		public wCHandle<gameJournalQuest> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public QuestUpdateUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
