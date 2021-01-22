using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCReference : CVariable
	{
		[Ordinal(0)]  [RED("communitySpawner")] public NodeRef CommunitySpawner { get; set; }
		[Ordinal(1)]  [RED("entryName")] public CName EntryName { get; set; }

		public NPCReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
