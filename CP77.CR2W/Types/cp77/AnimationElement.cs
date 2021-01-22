using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationElement : CVariable
	{
		[Ordinal(0)]  [RED("animOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(1)]  [RED("animation")] public CName Animation { get; set; }

		public AnimationElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
