using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsDataMemoryPoolRuntimeData : ISerializable
	{
		[Ordinal(0)] 
		[RED("poolName")] 
		public CString PoolName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("bytesAllocated")] 
		public CInt64 BytesAllocated
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(2)] 
		[RED("allocationCount")] 
		public CInt64 AllocationCount
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		public FunctionalTestsDataMemoryPoolRuntimeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
