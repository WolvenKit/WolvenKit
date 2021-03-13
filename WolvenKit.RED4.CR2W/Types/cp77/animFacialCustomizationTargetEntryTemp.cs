using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationTargetEntryTemp : CVariable
	{
		[Ordinal(0)] [RED("setup")] public raRef<animFacialSetup> Setup { get; set; }
		[Ordinal(1)] [RED("targetNames")] public CArray<CName> TargetNames { get; set; }

		public animFacialCustomizationTargetEntryTemp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
