using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIntLink : CVariable
	{
		[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_IntValue> Node { get; set; }

		public animIntLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
