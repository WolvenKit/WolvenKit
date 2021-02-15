using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFloatLink : CVariable
	{
		[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_FloatValue> Node { get; set; }

		public animFloatLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
