using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams_OperationData : CVariable
	{
		[Ordinal(0)] [RED("itemTDBID")] public TweakDBID ItemTDBID { get; set; }
		[Ordinal(1)] [RED("quantity")] public CInt32 Quantity { get; set; }

		public questTransferItems_NodeTypeParams_OperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
