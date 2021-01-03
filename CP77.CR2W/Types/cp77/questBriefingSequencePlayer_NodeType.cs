using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questBriefingSequencePlayer_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(2)]  [RED("briefingResource")] public raRef<inkWidgetLibraryResource> BriefingResource { get; set; }
		[Ordinal(3)]  [RED("briefingType")] public CEnum<questBriefingType> BriefingType { get; set; }
		[Ordinal(4)]  [RED("endMarkerName")] public CName EndMarkerName { get; set; }
		[Ordinal(5)]  [RED("function")] public CEnum<questBriefingSequencePlayerFunction> Function { get; set; }
		[Ordinal(6)]  [RED("loopType")] public CEnum<inkanimLoopType> LoopType { get; set; }
		[Ordinal(7)]  [RED("startMarkerName")] public CName StartMarkerName { get; set; }
		[Ordinal(8)]  [RED("userData")] public CHandle<inkUserData> UserData { get; set; }

		public questBriefingSequencePlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
