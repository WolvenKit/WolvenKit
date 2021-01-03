using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ChangeLevel : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("level")] public questInt32ValueWrapper Level { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)]  [RED("setExactLevel")] public CBool SetExactLevel { get; set; }

		public questCharacterManagerCombat_ChangeLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
