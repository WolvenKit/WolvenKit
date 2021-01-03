using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		[Ordinal(0)]  [RED("forcePlay")] public CBool ForcePlay { get; set; }
		[Ordinal(1)]  [RED("skipToEnd")] public CBool SkipToEnd { get; set; }
		[Ordinal(2)]  [RED("time")] public CFloat Time { get; set; }

		public gameTransformAnimationSkipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
