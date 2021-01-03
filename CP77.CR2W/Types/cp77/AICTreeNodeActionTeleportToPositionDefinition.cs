using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(0)]  [RED("doNavTest")] public CBool DoNavTest { get; set; }
		[Ordinal(1)]  [RED("positionName")] public CName PositionName { get; set; }

		public AICTreeNodeActionTeleportToPositionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
