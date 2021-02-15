using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("giver")] public CHandle<questUniversalRef> Giver { get; set; }
		[Ordinal(1)] [RED("receiver")] public CHandle<questUniversalRef> Receiver { get; set; }
		[Ordinal(2)] [RED("transferAllOperation")] public CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData> TransferAllOperation { get; set; }
		[Ordinal(3)] [RED("itemOperations")] public CArray<questTransferItems_NodeTypeParams_OperationData> ItemOperations { get; set; }
		[Ordinal(4)] [RED("tagOperations")] public CArray<questTransferItems_NodeTypeParams_TagOperationData> TagOperations { get; set; }

		public questTransferItems_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
