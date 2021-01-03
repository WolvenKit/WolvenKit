using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetHitIndicatorLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("animationPriority")] public CInt32 AnimationPriority { get; set; }

		public TargetHitIndicatorLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
