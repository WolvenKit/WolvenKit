using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsApperanceMaterial : CVariable
	{
		[Ordinal(0)] [RED("apperanceName")] public CName ApperanceName { get; set; }
		[Ordinal(1)] [RED("materialFrom")] public CName MaterialFrom { get; set; }
		[Ordinal(2)] [RED("material")] public CName Material { get; set; }

		public physicsApperanceMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
