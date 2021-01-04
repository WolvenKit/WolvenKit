using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
		[Ordinal(1)]  [RED("operations")] public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations { get; set; }

		public questInjectLoot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
