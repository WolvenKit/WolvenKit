using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnim_ : animAnimNode_Base
	{
		[Ordinal(1)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(2)] [RED("applyMotion")] public CBool ApplyMotion { get; set; }
		[Ordinal(3)] [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(4)] [RED("resume")] public CBool Resume { get; set; }
		[Ordinal(5)] [RED("collectEvents")] public CBool CollectEvents { get; set; }
		[Ordinal(6)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
		[Ordinal(7)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
		[Ordinal(8)] [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(9)] [RED("clipEnd")] public CFloat ClipEnd { get; set; }
		[Ordinal(10)] [RED("clipFrontByEvent")] public CName ClipFrontByEvent { get; set; }
		[Ordinal(11)] [RED("clipEndByEvent")] public CName ClipEndByEvent { get; set; }
		[Ordinal(12)] [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
		[Ordinal(13)] [RED("popDataByTag")] public CName PopDataByTag { get; set; }
		[Ordinal(14)] [RED("pushSafeCutTag")] public CName PushSafeCutTag { get; set; }
		[Ordinal(15)] [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
		[Ordinal(16)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(17)] [RED("applyInertializationOnAnimSetSwap")] public CBool ApplyInertializationOnAnimSetSwap { get; set; }

		public animAnimNode_SkAnim_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
