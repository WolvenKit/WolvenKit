using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIAssignRoleCommand : AICommand
	{
		[Ordinal(4)] [RED("role")] public CHandle<AIRole> Role { get; set; }

		public AIAssignRoleCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
