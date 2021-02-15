using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetMortality : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<gameGodModeType> State { get; set; }
		[Ordinal(3)] [RED("resetToDefault")] public CBool ResetToDefault { get; set; }
		[Ordinal(4)] [RED("source")] public CName Source { get; set; }

		public questCharacterManagerParameters_SetMortality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
