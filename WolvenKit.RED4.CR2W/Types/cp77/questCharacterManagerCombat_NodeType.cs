using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)] [RED("subtype")] public CHandle<questICharacterManagerCombat_NodeSubType> Subtype { get; set; }

		public questCharacterManagerCombat_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
