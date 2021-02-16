using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSpawnerParams : CVariable
	{
		[Ordinal(0)] [RED("reference")] public NodeRef Reference { get; set; }
		[Ordinal(1)] [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }

		public scnSpawnerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
