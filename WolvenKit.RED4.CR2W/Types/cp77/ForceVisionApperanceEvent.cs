using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceVisionApperanceEvent : redEvent
	{
		[Ordinal(0)] [RED("forcedHighlight")] public CHandle<FocusForcedHighlightData> ForcedHighlight { get; set; }
		[Ordinal(1)] [RED("apply")] public CBool Apply { get; set; }
		[Ordinal(2)] [RED("forceCancel")] public CBool ForceCancel { get; set; }
		[Ordinal(3)] [RED("ignoreStackEvaluation")] public CBool IgnoreStackEvaluation { get; set; }
		[Ordinal(4)] [RED("responseData")] public CHandle<IScriptable> ResponseData { get; set; }

		public ForceVisionApperanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
