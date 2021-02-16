using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerDeathAnimation : animAnimFeature
	{
		[Ordinal(0)] [RED("animation")] public CInt32 Animation { get; set; }

		public AnimFeature_PlayerDeathAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
