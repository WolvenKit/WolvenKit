using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTierPrereq : gameIComparisonPrereq
	{
		[Ordinal(0)]  [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }

		public gameTierPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
