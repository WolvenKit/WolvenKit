using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotHub : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("additionalLinkIds")] public CArray<workWorkEntryId> AdditionalLinkIds { get; set; }
		[Ordinal(1)]  [RED("additionalLinks")] public CArray<animPoseLink> AdditionalLinks { get; set; }
		[Ordinal(2)]  [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
		[Ordinal(3)]  [RED("isCoverHubHack")] public CBool IsCoverHubHack { get; set; }
		[Ordinal(4)]  [RED("eventFilterType")] public CEnum<animEventFilterType> EventFilterType { get; set; }
		[Ordinal(5)]  [RED("mainEmotionalState")] public CName MainEmotionalState { get; set; }
		[Ordinal(6)]  [RED("emotionalExpression")] public CName EmotionalExpression { get; set; }
		[Ordinal(7)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(8)]  [RED("facialIdleMaleAnimation")] public CName FacialIdleMaleAnimation { get; set; }
		[Ordinal(9)]  [RED("facialIdleKey_MaleAnimation")] public CName FacialIdleKey_MaleAnimation { get; set; }
		[Ordinal(10)]  [RED("facialIdleFemaleAnimation")] public CName FacialIdleFemaleAnimation { get; set; }
		[Ordinal(11)]  [RED("facialIdleKey_FemaleAnimation")] public CName FacialIdleKey_FemaleAnimation { get; set; }

		public animAnimNode_WorkspotHub(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
