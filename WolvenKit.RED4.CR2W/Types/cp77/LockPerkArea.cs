using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LockPerkArea : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("perkArea")] public CEnum<gamedataPerkArea> PerkArea { get; set; }

		public LockPerkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
