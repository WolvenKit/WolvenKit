using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProgressBarAnimationChunkController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("barCanvas")] public inkWidgetReference BarCanvas { get; set; }
		[Ordinal(1)]  [RED("fullbarSize")] public CFloat FullbarSize { get; set; }
		[Ordinal(2)]  [RED("hitAnim")] public CHandle<inkanimProxy> HitAnim { get; set; }
		[Ordinal(3)]  [RED("isNegative")] public CBool IsNegative { get; set; }
		[Ordinal(4)]  [RED("rootCanvas")] public inkWidgetReference RootCanvas { get; set; }

		public ProgressBarAnimationChunkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
