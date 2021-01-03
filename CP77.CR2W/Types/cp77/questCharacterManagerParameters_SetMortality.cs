using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetMortality : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)]  [RED("resetToDefault")] public CBool ResetToDefault { get; set; }
		[Ordinal(3)]  [RED("source")] public CName Source { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<gameGodModeType> State { get; set; }

		public questCharacterManagerParameters_SetMortality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
