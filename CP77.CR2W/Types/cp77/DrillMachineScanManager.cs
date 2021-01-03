using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DrillMachineScanManager : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("idleToScanTime")] public CFloat IdleToScanTime { get; set; }
		[Ordinal(1)]  [RED("ppCurrentEndFrame")] public CInt32 PpCurrentEndFrame { get; set; }
		[Ordinal(2)]  [RED("ppCurrentStartTime")] public CFloat PpCurrentStartTime { get; set; }
		[Ordinal(3)]  [RED("ppEnding")] public CBool PpEnding { get; set; }
		[Ordinal(4)]  [RED("ppOffFrameDelay")] public CInt32 PpOffFrameDelay { get; set; }
		[Ordinal(5)]  [RED("ppStarting")] public CBool PpStarting { get; set; }

		public DrillMachineScanManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
