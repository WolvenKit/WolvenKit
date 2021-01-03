using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetDeathDirection : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("direction")] public CEnum<gameeventsDeathDirection> Direction { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterManagerCombat_SetDeathDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
