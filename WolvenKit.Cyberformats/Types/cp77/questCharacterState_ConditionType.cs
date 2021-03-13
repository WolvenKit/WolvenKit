using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("subType")] public CHandle<questICharacterConditionSubType> SubType { get; set; }

		public questCharacterState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
