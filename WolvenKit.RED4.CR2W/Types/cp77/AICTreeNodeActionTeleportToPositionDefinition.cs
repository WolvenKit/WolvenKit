using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] [RED("positionName")] public CName PositionName { get; set; }
		[Ordinal(2)] [RED("doNavTest")] public CBool DoNavTest { get; set; }

		public AICTreeNodeActionTeleportToPositionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
