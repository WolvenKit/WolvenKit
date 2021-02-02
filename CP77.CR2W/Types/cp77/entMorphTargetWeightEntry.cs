using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetWeightEntry : CVariable
	{
		[Ordinal(0)]  [RED("targetName")] public CName TargetName { get; set; }
		[Ordinal(1)]  [RED("regionName")] public CName RegionName { get; set; }
		[Ordinal(2)]  [RED("weight")] public CFloat Weight { get; set; }

		public entMorphTargetWeightEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
