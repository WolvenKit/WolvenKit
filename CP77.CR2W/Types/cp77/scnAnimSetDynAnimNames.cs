using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetDynAnimNames : CVariable
	{
		[Ordinal(0)]  [RED("animVariable", lignas(8) StaticArray<CNam, 1)] public alignas(8) StaticArray<CName> AnimVariable { get; set; }
		[Ordinal(1)]  [RED("animNames")] public CArray<CName> AnimNames { get; set; }

		public scnAnimSetDynAnimNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
