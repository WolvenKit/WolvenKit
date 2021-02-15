using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		[Ordinal(2)] [RED("setup")] public rRef<CTerrainSetup> Setup { get; set; }

		public CMaterialParameterTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
