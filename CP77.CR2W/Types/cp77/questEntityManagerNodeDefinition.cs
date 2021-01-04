using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("type")] public CHandle<questIEntityManager_NodeType> Type { get; set; }

		public questEntityManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
