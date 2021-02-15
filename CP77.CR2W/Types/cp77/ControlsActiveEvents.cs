using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ControlsActiveEvents : BraindanceControlsTransition
	{
		[Ordinal(0)] [RED("BraindanceBB")] public CHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(1)] [RED("BlockPerspectiveSwitchTimer")] public CFloat BlockPerspectiveSwitchTimer { get; set; }
		[Ordinal(2)] [RED("fxActive")] public CBool FxActive { get; set; }
		[Ordinal(3)] [RED("rewindFxActive")] public CBool RewindFxActive { get; set; }
		[Ordinal(4)] [RED("holdDuration")] public CFloat HoldDuration { get; set; }
		[Ordinal(5)] [RED("cachedState")] public CEnum<scnPlaySpeed> CachedState { get; set; }
		[Ordinal(6)] [RED("cacheSet")] public CBool CacheSet { get; set; }
		[Ordinal(7)] [RED("forwardInput")] public CBool ForwardInput { get; set; }
		[Ordinal(8)] [RED("backwardInput")] public CBool BackwardInput { get; set; }
		[Ordinal(9)] [RED("forwardInputLocked")] public CBool ForwardInputLocked { get; set; }
		[Ordinal(10)] [RED("backwardInputLocked")] public CBool BackwardInputLocked { get; set; }
		[Ordinal(11)] [RED("activeDirection")] public CEnum<scnPlayDirection> ActiveDirection { get; set; }
		[Ordinal(12)] [RED("rewindRunning")] public CBool RewindRunning { get; set; }
		[Ordinal(13)] [RED("contextsSetup")] public CBool ContextsSetup { get; set; }
		[Ordinal(14)] [RED("pauseLock")] public CBool PauseLock { get; set; }
		[Ordinal(15)] [RED("endRecordingMessageSet")] public CBool EndRecordingMessageSet { get; set; }

		public ControlsActiveEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
