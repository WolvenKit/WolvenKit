using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolRuntimeData : ISerializable
	{
		[Ordinal(0)] [RED("poolName")] public CString PoolName { get; set; }
		[Ordinal(1)] [RED("bytesAllocated")] public CInt64 BytesAllocated { get; set; }
		[Ordinal(2)] [RED("allocationCount")] public CInt64 AllocationCount { get; set; }

		public FunctionalTestsDataMemoryPoolRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
