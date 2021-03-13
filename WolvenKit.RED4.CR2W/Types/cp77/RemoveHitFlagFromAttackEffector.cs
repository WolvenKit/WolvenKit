using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveHitFlagFromAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] [RED("hitFlag")] public CEnum<hitFlag> HitFlag { get; set; }
		[Ordinal(1)] [RED("reason")] public CName Reason { get; set; }

		public RemoveHitFlagFromAttackEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
