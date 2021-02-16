using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animationPlayer : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("loopType")] public CEnum<inkanimLoopType> LoopType { get; set; }
		[Ordinal(3)] [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(4)] [RED("playInfinite")] public CBool PlayInfinite { get; set; }
		[Ordinal(5)] [RED("loopsAmount")] public CUInt32 LoopsAmount { get; set; }
		[Ordinal(6)] [RED("playReversed")] public CBool PlayReversed { get; set; }
		[Ordinal(7)] [RED("animTarget")] public inkWidgetReference AnimTarget { get; set; }
		[Ordinal(8)] [RED("autoPlay")] public CBool AutoPlay { get; set; }
		[Ordinal(9)] [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }

		public animationPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
