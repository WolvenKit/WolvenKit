using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtHeadProperties : CVariable
	{
		[Ordinal(0)]  [RED("enableFactor")] public CFloat EnableFactor { get; set; }
		[Ordinal(1)]  [RED("mode")] public CInt32 Mode { get; set; }
		[Ordinal(2)]  [RED("override")] public CFloat Override { get; set; }

		public scnLookAtHeadProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
