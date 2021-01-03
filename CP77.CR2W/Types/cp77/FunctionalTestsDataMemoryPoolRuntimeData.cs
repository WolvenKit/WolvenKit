using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolRuntimeData : ISerializable
	{
		[Ordinal(0)]  [RED("allocationCount")] public CInt64 AllocationCount { get; set; }
		[Ordinal(1)]  [RED("bytesAllocated")] public CInt64 BytesAllocated { get; set; }
		[Ordinal(2)]  [RED("poolName")] public CString PoolName { get; set; }

		public FunctionalTestsDataMemoryPoolRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
