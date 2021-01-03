using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ControlsActiveEvents : BraindanceControlsTransition
	{
		[Ordinal(0)]  [RED("BlockPerspectiveSwitchTimer")] public CFloat BlockPerspectiveSwitchTimer { get; set; }
		[Ordinal(1)]  [RED("BraindanceBB")] public CHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(2)]  [RED("activeDirection")] public CEnum<scnPlayDirection> ActiveDirection { get; set; }
		[Ordinal(3)]  [RED("backwardInput")] public CBool BackwardInput { get; set; }
		[Ordinal(4)]  [RED("backwardInputLocked")] public CBool BackwardInputLocked { get; set; }
		[Ordinal(5)]  [RED("cacheSet")] public CBool CacheSet { get; set; }
		[Ordinal(6)]  [RED("cachedState")] public CEnum<scnPlaySpeed> CachedState { get; set; }
		[Ordinal(7)]  [RED("contextsSetup")] public CBool ContextsSetup { get; set; }
		[Ordinal(8)]  [RED("endRecordingMessageSet")] public CBool EndRecordingMessageSet { get; set; }
		[Ordinal(9)]  [RED("forwardInput")] public CBool ForwardInput { get; set; }
		[Ordinal(10)]  [RED("forwardInputLocked")] public CBool ForwardInputLocked { get; set; }
		[Ordinal(11)]  [RED("fxActive")] public CBool FxActive { get; set; }
		[Ordinal(12)]  [RED("holdDuration")] public CFloat HoldDuration { get; set; }
		[Ordinal(13)]  [RED("pauseLock")] public CBool PauseLock { get; set; }
		[Ordinal(14)]  [RED("rewindFxActive")] public CBool RewindFxActive { get; set; }
		[Ordinal(15)]  [RED("rewindRunning")] public CBool RewindRunning { get; set; }

		public ControlsActiveEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
