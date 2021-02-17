using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams_TagOperationData : CVariable
	{
		[Ordinal(0)] [RED("tagToTransfer")] public CName TagToTransfer { get; set; }
		[Ordinal(1)] [RED("itemIDsToIgnore")] public CArray<TweakDBID> ItemIDsToIgnore { get; set; }
		[Ordinal(2)] [RED("tagsToIgnore")] public CArray<CName> TagsToIgnore { get; set; }

		public questTransferItems_NodeTypeParams_TagOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
