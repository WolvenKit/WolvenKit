using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_SubStructure : CVariable
	{
		[Ordinal(0)] [RED("exampleSubStructureVar")] public CBool ExampleSubStructureVar { get; set; }

		public Ref_6_ReplicatedVariables_SubStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
