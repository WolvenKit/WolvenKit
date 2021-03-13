using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveRoleCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] [RED("role")] public CEnum<EAIRole> Role { get; set; }
		[Ordinal(1)] [RED("roleCbId")] public CUInt32 RoleCbId { get; set; }

		public PassiveRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
