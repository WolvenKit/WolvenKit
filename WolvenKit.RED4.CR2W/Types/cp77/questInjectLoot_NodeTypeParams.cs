using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
		[Ordinal(1)] [RED("operations")] public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations { get; set; }

		public questInjectLoot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
