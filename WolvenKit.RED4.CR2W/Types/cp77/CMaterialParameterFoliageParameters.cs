using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterFoliageParameters : CMaterialParameter
	{
		[Ordinal(2)] [RED("foliageProfile")] public rRef<CFoliageProfile> FoliageProfile { get; set; }

		public CMaterialParameterFoliageParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
