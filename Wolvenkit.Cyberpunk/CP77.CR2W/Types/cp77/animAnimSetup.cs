using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimSetup : CVariable
	{
		[Ordinal(0)]  [RED("cinematics")] public CArray<animAnimSetupEntry> Cinematics { get; set; }
		[Ordinal(1)]  [RED("gameplay")] public CArray<animAnimSetupEntry> Gameplay { get; set; }

		public animAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
