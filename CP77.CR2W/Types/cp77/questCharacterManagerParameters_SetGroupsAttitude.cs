using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetGroupsAttitude : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] [RED("set")] public CBool Set { get; set; }
		[Ordinal(1)] [RED("group1Name")] public CName Group1Name { get; set; }
		[Ordinal(2)] [RED("group2Name")] public CName Group2Name { get; set; }
		[Ordinal(3)] [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public questCharacterManagerParameters_SetGroupsAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
