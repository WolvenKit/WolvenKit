using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CameraQuestProperties : CVariable
	{
		[Ordinal(0)]  [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(1)]  [RED("followedTargetID")] public entEntityID FollowedTargetID { get; set; }
		[Ordinal(2)]  [RED("isInFollowMode")] public CBool IsInFollowMode { get; set; }
		[Ordinal(3)]  [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }

		public CameraQuestProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
