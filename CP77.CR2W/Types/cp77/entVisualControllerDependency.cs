using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVisualControllerDependency : CVariable
	{
		[Ordinal(0)]  [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }

		public entVisualControllerDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
