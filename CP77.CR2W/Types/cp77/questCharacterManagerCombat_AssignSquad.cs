using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_AssignSquad : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("presetID")] public TweakDBID PresetID { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)]  [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public questCharacterManagerCombat_AssignSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
