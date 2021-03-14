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
			get
			{
				if (_poolName == null)
				{
					_poolName = (CString) CR2WTypeManager.Create("String", "poolName", cr2w, this);
				}
				return _poolName;
			}
			set
			{
				if (_poolName == value)
				{
					return;
				}
				_poolName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bytesAllocated")] 
		public CInt64 BytesAllocated
		{
			get
			{
				if (_bytesAllocated == null)
				{
					_bytesAllocated = (CInt64) CR2WTypeManager.Create("Int64", "bytesAllocated", cr2w, this);
				}
				return _bytesAllocated;
			}
			set
			{
				if (_bytesAllocated == value)
				{
					return;
				}
				_bytesAllocated = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("allocationCount")] 
		public CInt64 AllocationCount
		{
			get
			{
				if (_allocationCount == null)
				{
					_allocationCount = (CInt64) CR2WTypeManager.Create("Int64", "allocationCount", cr2w, this);
				}
				return _allocationCount;
			}
			set
			{
				if (_allocationCount == value)
				{
					return;
				}
				_allocationCount = value;
				PropertySet(this);
			}
		}

		public FunctionalTestsDataMemoryPoolRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
