using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationMorph : gameuiCensorshipInfo
	{
		[Ordinal(2)] [RED("regionName")] public CName RegionName { get; set; }
		[Ordinal(3)] [RED("targetName")] public CName TargetName { get; set; }

		public gameuiCustomizationMorph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
