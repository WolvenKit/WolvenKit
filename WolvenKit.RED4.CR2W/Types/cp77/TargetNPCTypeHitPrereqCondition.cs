using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("type")] public CEnum<gamedataNPCType> Type { get; set; }

		public TargetNPCTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
