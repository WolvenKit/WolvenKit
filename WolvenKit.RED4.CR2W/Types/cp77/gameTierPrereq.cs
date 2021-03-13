using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTierPrereq : gameIComparisonPrereq
	{
		[Ordinal(1)] [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }

		public gameTierPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
