using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams_OperationData : CVariable
	{
		[Ordinal(0)] [RED("operationType")] public CEnum<questInjectLootOperationType> OperationType { get; set; }
		[Ordinal(1)] [RED("itemTDBID")] public TweakDBID ItemTDBID { get; set; }
		[Ordinal(2)] [RED("quantity")] public CInt32 Quantity { get; set; }

		public questInjectLoot_NodeTypeParams_OperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
