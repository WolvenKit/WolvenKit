using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ContactData : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CString Id { get; set; }
		[Ordinal(1)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(2)] [RED("avatarID")] public TweakDBID AvatarID { get; set; }
		[Ordinal(3)] [RED("questRelated")] public CBool QuestRelated { get; set; }
		[Ordinal(4)] [RED("hasMessages")] public CBool HasMessages { get; set; }
		[Ordinal(5)] [RED("unreadMessegeCount")] public CInt32 UnreadMessegeCount { get; set; }
		[Ordinal(6)] [RED("unreadMessages")] public CArray<CInt32> UnreadMessages { get; set; }
		[Ordinal(7)] [RED("playerCanReply")] public CBool PlayerCanReply { get; set; }
		[Ordinal(8)] [RED("playerIsLastSender")] public CBool PlayerIsLastSender { get; set; }
		[Ordinal(9)] [RED("lastMesssagePreview")] public CString LastMesssagePreview { get; set; }
		[Ordinal(10)] [RED("activeDataSync")] public wCHandle<MessengerContactSyncData> ActiveDataSync { get; set; }
		[Ordinal(11)] [RED("threadsCount")] public CInt32 ThreadsCount { get; set; }
		[Ordinal(12)] [RED("timeStamp")] public GameTime TimeStamp { get; set; }
		[Ordinal(13)] [RED("hash")] public CInt32 Hash { get; set; }

		public ContactData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
