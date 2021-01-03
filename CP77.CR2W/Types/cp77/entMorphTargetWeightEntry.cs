using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetWeightEntry : CVariable
	{
		[Ordinal(0)]  [RED("regionName")] public CName RegionName { get; set; }
		[Ordinal(1)]  [RED("targetName")] public CName TargetName { get; set; }
		[Ordinal(2)]  [RED("weight")] public CFloat Weight { get; set; }

		public entMorphTargetWeightEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
