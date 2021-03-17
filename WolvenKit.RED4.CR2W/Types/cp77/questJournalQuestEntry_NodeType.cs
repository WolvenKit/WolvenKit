using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestEntry_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _sendNotification;
		private CBool _trackQuest;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		[Ordinal(2)] 
		[RED("trackQuest")] 
		public CBool TrackQuest
		{
			get => GetProperty(ref _trackQuest);
			set => SetProperty(ref _trackQuest, value);
		}

		public questJournalQuestEntry_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
