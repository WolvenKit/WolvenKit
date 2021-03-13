using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetDeathDirection : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("direction")] public CEnum<gameeventsDeathDirection> Direction { get; set; }

		public questCharacterManagerCombat_SetDeathDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
