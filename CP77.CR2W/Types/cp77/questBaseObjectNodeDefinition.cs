using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questBaseObjectNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("reference")] public NodeRef Reference { get; set; }

		public questBaseObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
