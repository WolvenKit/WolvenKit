using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePopupData : CVariable
	{
		[Ordinal(0)] [RED("title")] public CString Title { get; set; }
		[Ordinal(1)] [RED("message")] public CString Message { get; set; }
		[Ordinal(2)] [RED("iconID")] public TweakDBID IconID { get; set; }
		[Ordinal(3)] [RED("isModal")] public CBool IsModal { get; set; }
		[Ordinal(4)] [RED("videoType")] public CEnum<gameVideoType> VideoType { get; set; }
		[Ordinal(5)] [RED("video")] public raRef<Bink> Video { get; set; }

		public gamePopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
