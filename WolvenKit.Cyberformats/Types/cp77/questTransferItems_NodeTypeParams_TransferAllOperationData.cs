using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams_TransferAllOperationData : ISerializable
	{
		[Ordinal(0)] [RED("itemIDsToIgnore")] public CArray<TweakDBID> ItemIDsToIgnore { get; set; }
		[Ordinal(1)] [RED("tagsToIgnore")] public CArray<CName> TagsToIgnore { get; set; }

		public questTransferItems_NodeTypeParams_TransferAllOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
