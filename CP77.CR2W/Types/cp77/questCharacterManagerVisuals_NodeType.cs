using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)] [RED("subtype")] public CHandle<questICharacterManagerVisuals_NodeSubType> Subtype { get; set; }

		public questCharacterManagerVisuals_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
