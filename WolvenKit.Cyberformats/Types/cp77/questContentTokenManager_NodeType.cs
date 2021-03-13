using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questContentTokenManager_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] [RED("subtype")] public CHandle<questIContentTokenManager_NodeSubType> Subtype { get; set; }

		public questContentTokenManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
