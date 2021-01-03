using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(0)]  [RED("animationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(1)]  [RED("isShootable")] public CBool IsShootable { get; set; }

		public SlidingLadderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
