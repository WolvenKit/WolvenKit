using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraQuestProperties : CVariable
	{
		[Ordinal(0)] [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(1)] [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }
		[Ordinal(2)] [RED("isInFollowMode")] public CBool IsInFollowMode { get; set; }
		[Ordinal(3)] [RED("followedTargetID")] public entEntityID FollowedTargetID { get; set; }

		public CameraQuestProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
