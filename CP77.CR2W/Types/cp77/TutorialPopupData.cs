using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TutorialPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("closeAtInput")] public CBool CloseAtInput { get; set; }
		[Ordinal(7)] [RED("pauseGame")] public CBool PauseGame { get; set; }
		[Ordinal(8)] [RED("isModal")] public CBool IsModal { get; set; }
		[Ordinal(9)] [RED("position")] public CEnum<gamePopupPosition> Position { get; set; }
		[Ordinal(10)] [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(11)] [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(12)] [RED("title")] public CString Title { get; set; }
		[Ordinal(13)] [RED("message")] public CString Message { get; set; }
		[Ordinal(14)] [RED("videoType")] public CEnum<gameVideoType> VideoType { get; set; }
		[Ordinal(15)] [RED("video")] public redResourceReferenceScriptToken Video { get; set; }

		public TutorialPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
