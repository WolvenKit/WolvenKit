using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetWeightEntry : CVariable
	{
		[Ordinal(0)] [RED("targetName")] public CName TargetName { get; set; }
		[Ordinal(1)] [RED("regionName")] public CName RegionName { get; set; }
		[Ordinal(2)] [RED("weight")] public CFloat Weight { get; set; }

		public entMorphTargetWeightEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
