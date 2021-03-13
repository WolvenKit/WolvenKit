using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemovePerk : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("perkType")] public CEnum<gamedataPerkType> PerkType { get; set; }

		public RemovePerk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
