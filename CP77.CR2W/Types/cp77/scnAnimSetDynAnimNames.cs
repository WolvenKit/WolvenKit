using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetDynAnimNames : CVariable
	{
		[Ordinal(0)]  [RED("animNames")] public CArray<CName> AnimNames { get; set; }
		[Ordinal(1)]  [RED("animVariable")] public CStatic<1,CName> AnimVariable { get; set; }

		public scnAnimSetDynAnimNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
