using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameGodModeEntityData : CVariable
	{
		[Ordinal(0)]  [RED("overrides")] public CArray<gameGodModeData> Overrides { get; set; }
		[Ordinal(1)]  [RED("base")] public CArray<gameGodModeData> Base { get; set; }

		public gameGodModeEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
