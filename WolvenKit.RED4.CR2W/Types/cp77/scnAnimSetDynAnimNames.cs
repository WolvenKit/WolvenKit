using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetDynAnimNames : CVariable
	{
		[Ordinal(0)] [RED("animVariable", 1)] public CStatic<CName> AnimVariable { get; set; }
		[Ordinal(1)] [RED("animNames")] public CArray<CName> AnimNames { get; set; }

		public scnAnimSetDynAnimNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
