using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DrillMachineScanManager : gameScriptableComponent
	{
		[Ordinal(5)] [RED("ppStarting")] public CBool PpStarting { get; set; }
		[Ordinal(6)] [RED("ppEnding")] public CBool PpEnding { get; set; }
		[Ordinal(7)] [RED("ppCurrentStartTime")] public CFloat PpCurrentStartTime { get; set; }
		[Ordinal(8)] [RED("ppCurrentEndFrame")] public CInt32 PpCurrentEndFrame { get; set; }
		[Ordinal(9)] [RED("idleToScanTime")] public CFloat IdleToScanTime { get; set; }
		[Ordinal(10)] [RED("ppOffFrameDelay")] public CInt32 PpOffFrameDelay { get; set; }

		public DrillMachineScanManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
