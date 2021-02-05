using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressBarAnimationChunkController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("rootCanvas")] public inkWidgetReference RootCanvas { get; set; }
		[Ordinal(1)]  [RED("barCanvas")] public inkWidgetReference BarCanvas { get; set; }
		[Ordinal(2)]  [RED("hitAnim")] public CHandle<inkanimProxy> HitAnim { get; set; }
		[Ordinal(3)]  [RED("fullbarSize")] public CFloat FullbarSize { get; set; }
		[Ordinal(4)]  [RED("isNegative")] public CBool IsNegative { get; set; }

		public ProgressBarAnimationChunkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
