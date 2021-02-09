using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnim : animAnimNode_Base
	{
        [Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
        [Ordinal(1)] [RED("applyMotion")] public CBool ApplyMotion { get; set; }
        [Ordinal(2)] [RED("isLooped")] public CBool IsLooped { get; set; }
        [Ordinal(3)] [RED("resume")] public CBool Resume { get; set; }
        [Ordinal(4)] [RED("collectEvents")] public CBool CollectEvents { get; set; }
        [Ordinal(5)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
        [Ordinal(6)]  [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
        [Ordinal(7)]  [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(8)]  [RED("clipEnd")] public CFloat ClipEnd { get; set; }
        [Ordinal(9)] [RED("clipFrontByEvent")] public CName ClipFrontByEvent { get; set; }
        [Ordinal(10)] [RED("clipEndByEvent")] public CName ClipEndByEvent { get; set; }
		[Ordinal(11)] [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
        [Ordinal(12)] [RED("popDataByTag")] public CName PopDataByTag { get; set; }
        [Ordinal(13)] [RED("pushSafeCutTag")] public CName PushSafeCutTag { get; set; }
        [Ordinal(14)]  [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
		[Ordinal(15)]  [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
        [Ordinal(16)] [RED("applyInertializationOnAnimSetSwap")] public CBool ApplyInertializationOnAnimSetSwap { get; set; }

        [Ordinal(998)] [RED("debug")] public CBool debug { get; set; }
        [Ordinal(999)] [RED("debugFootsteps")] public CBool debugFootsteps { get; set; }

		public animAnimNode_SkAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
