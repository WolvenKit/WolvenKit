using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnim : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
		[Ordinal(1)]  [RED("animation")] public CName Animation { get; set; }
		[Ordinal(2)]  [RED("applyInertializationOnAnimSetSwap")] public CBool ApplyInertializationOnAnimSetSwap { get; set; }
		[Ordinal(3)]  [RED("applyMotion")] public CBool ApplyMotion { get; set; }
		[Ordinal(4)]  [RED("clipEnd")] public CFloat ClipEnd { get; set; }
		[Ordinal(5)]  [RED("clipEndByEvent")] public CName ClipEndByEvent { get; set; }
		[Ordinal(6)]  [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(7)]  [RED("clipFrontByEvent")] public CName ClipFrontByEvent { get; set; }
		[Ordinal(8)]  [RED("collectEvents")] public CBool CollectEvents { get; set; }
		[Ordinal(9)]  [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
		[Ordinal(10)]  [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
		[Ordinal(11)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(12)]  [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(13)]  [RED("popDataByTag")] public CName PopDataByTag { get; set; }
		[Ordinal(14)]  [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
		[Ordinal(15)]  [RED("pushSafeCutTag")] public CName PushSafeCutTag { get; set; }
		[Ordinal(16)]  [RED("resume")] public CBool Resume { get; set; }

		public animAnimNode_SkAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
