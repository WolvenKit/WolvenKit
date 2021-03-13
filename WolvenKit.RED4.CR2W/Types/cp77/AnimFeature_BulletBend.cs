using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_BulletBend : animAnimFeature
	{
		[Ordinal(0)] [RED("animProgression")] public CFloat AnimProgression { get; set; }
		[Ordinal(1)] [RED("randomAdditive")] public CFloat RandomAdditive { get; set; }
		[Ordinal(2)] [RED("isResetting")] public CBool IsResetting { get; set; }

		public AnimFeature_BulletBend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
