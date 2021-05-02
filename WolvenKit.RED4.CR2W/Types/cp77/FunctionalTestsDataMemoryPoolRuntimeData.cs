using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolRuntimeData : ISerializable
	{
		private CString _poolName;
		private CInt64 _bytesAllocated;
		private CInt64 _allocationCount;

		[Ordinal(0)] 
		[RED("poolName")] 
		public CString PoolName
		{
			get => GetProperty(ref _poolName);
			set => SetProperty(ref _poolName, value);
		}

		[Ordinal(1)] 
		[RED("bytesAllocated")] 
		public CInt64 BytesAllocated
		{
			get => GetProperty(ref _bytesAllocated);
			set => SetProperty(ref _bytesAllocated, value);
		}

		[Ordinal(2)] 
		[RED("allocationCount")] 
		public CInt64 AllocationCount
		{
			get => GetProperty(ref _allocationCount);
			set => SetProperty(ref _allocationCount, value);
		}

		public FunctionalTestsDataMemoryPoolRuntimeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
