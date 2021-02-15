using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("perk")] public CEnum<gamedataPerkType> Perk { get; set; }

		public PerkPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
