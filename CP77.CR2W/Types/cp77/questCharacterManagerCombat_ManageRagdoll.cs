using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ManageRagdoll : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("enableRagdoll")] public CBool EnableRagdoll { get; set; }

		public questCharacterManagerCombat_ManageRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
