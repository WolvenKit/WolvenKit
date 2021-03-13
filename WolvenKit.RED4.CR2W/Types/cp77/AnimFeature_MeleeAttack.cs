using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MeleeAttack : animAnimFeature
	{
		[Ordinal(0)] [RED("hit")] public CBool Hit { get; set; }

		public AnimFeature_MeleeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
