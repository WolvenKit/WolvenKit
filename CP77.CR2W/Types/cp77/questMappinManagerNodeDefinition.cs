using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMappinManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(3)] [RED("disablePreviousMappins")] public CBool DisablePreviousMappins { get; set; }

		public questMappinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
