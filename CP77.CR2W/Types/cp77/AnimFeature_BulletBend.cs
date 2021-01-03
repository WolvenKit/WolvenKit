using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_BulletBend : animAnimFeature
	{
		[Ordinal(0)]  [RED("animProgression")] public CFloat AnimProgression { get; set; }
		[Ordinal(1)]  [RED("isResetting")] public CBool IsResetting { get; set; }
		[Ordinal(2)]  [RED("randomAdditive")] public CFloat RandomAdditive { get; set; }

		public AnimFeature_BulletBend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
