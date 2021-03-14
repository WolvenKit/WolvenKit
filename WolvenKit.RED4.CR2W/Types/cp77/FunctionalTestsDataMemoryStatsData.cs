using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryStatsData : ISerializable
	{
		private CUInt64 _totalPhysicalMemory;
		private CUInt64 _availablePhysicalMemory;
		private CUInt64 _runtimeTotalBytesAllocated;
		private CUInt64 _cpuBytesAllocated;
		private CUInt64 _gpuBytesAllocated;
		private CUInt32 _totalAllocationCount;
		private CUInt32 _cpuAllocationCount;
		private CUInt32 _gpuAllocationCount;
		private CUInt64 _engineTick;
		private CFloat _lastTimeDelta;
		private CDouble _engineTime;
		private CUInt64 _rawLocalTime;
		private CString _playerPosition;
		private CString _playerOrientation;
		private CArray<FunctionalTestsDataMemoryPoolRuntimeData> _poolsRuntimeInfo;
		private CArray<FunctionalTestsDataMemoryPoolStaticData> _poolsCurrentInfo;

		[Ordinal(0)] 
		[RED("totalPhysicalMemory")] 
		public CUInt64 TotalPhysicalMemory
		{
			get
			{
				if (_totalPhysicalMemory == null)
				{
					_totalPhysicalMemory = (CUInt64) CR2WTypeManager.Create("Uint64", "totalPhysicalMemory", cr2w, this);
				}
				return _totalPhysicalMemory;
			}
			set
			{
				if (_totalPhysicalMemory == value)
				{
					return;
				}
				_totalPhysicalMemory = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("availablePhysicalMemory")] 
		public CUInt64 AvailablePhysicalMemory
		{
			get
			{
				if (_availablePhysicalMemory == null)
				{
					_availablePhysicalMemory = (CUInt64) CR2WTypeManager.Create("Uint64", "availablePhysicalMemory", cr2w, this);
				}
				return _availablePhysicalMemory;
			}
			set
			{
				if (_availablePhysicalMemory == value)
				{
					return;
				}
				_availablePhysicalMemory = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("runtimeTotalBytesAllocated")] 
		public CUInt64 RuntimeTotalBytesAllocated
		{
			get
			{
				if (_runtimeTotalBytesAllocated == null)
				{
					_runtimeTotalBytesAllocated = (CUInt64) CR2WTypeManager.Create("Uint64", "runtimeTotalBytesAllocated", cr2w, this);
				}
				return _runtimeTotalBytesAllocated;
			}
			set
			{
				if (_runtimeTotalBytesAllocated == value)
				{
					return;
				}
				_runtimeTotalBytesAllocated = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cpuBytesAllocated")] 
		public CUInt64 CpuBytesAllocated
		{
			get
			{
				if (_cpuBytesAllocated == null)
				{
					_cpuBytesAllocated = (CUInt64) CR2WTypeManager.Create("Uint64", "cpuBytesAllocated", cr2w, this);
				}
				return _cpuBytesAllocated;
			}
			set
			{
				if (_cpuBytesAllocated == value)
				{
					return;
				}
				_cpuBytesAllocated = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gpuBytesAllocated")] 
		public CUInt64 GpuBytesAllocated
		{
			get
			{
				if (_gpuBytesAllocated == null)
				{
					_gpuBytesAllocated = (CUInt64) CR2WTypeManager.Create("Uint64", "gpuBytesAllocated", cr2w, this);
				}
				return _gpuBytesAllocated;
			}
			set
			{
				if (_gpuBytesAllocated == value)
				{
					return;
				}
				_gpuBytesAllocated = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("totalAllocationCount")] 
		public CUInt32 TotalAllocationCount
		{
			get
			{
				if (_totalAllocationCount == null)
				{
					_totalAllocationCount = (CUInt32) CR2WTypeManager.Create("Uint32", "totalAllocationCount", cr2w, this);
				}
				return _totalAllocationCount;
			}
			set
			{
				if (_totalAllocationCount == value)
				{
					return;
				}
				_totalAllocationCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cpuAllocationCount")] 
		public CUInt32 CpuAllocationCount
		{
			get
			{
				if (_cpuAllocationCount == null)
				{
					_cpuAllocationCount = (CUInt32) CR2WTypeManager.Create("Uint32", "cpuAllocationCount", cr2w, this);
				}
				return _cpuAllocationCount;
			}
			set
			{
				if (_cpuAllocationCount == value)
				{
					return;
				}
				_cpuAllocationCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gpuAllocationCount")] 
		public CUInt32 GpuAllocationCount
		{
			get
			{
				if (_gpuAllocationCount == null)
				{
					_gpuAllocationCount = (CUInt32) CR2WTypeManager.Create("Uint32", "gpuAllocationCount", cr2w, this);
				}
				return _gpuAllocationCount;
			}
			set
			{
				if (_gpuAllocationCount == value)
				{
					return;
				}
				_gpuAllocationCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get
			{
				if (_engineTick == null)
				{
					_engineTick = (CUInt64) CR2WTypeManager.Create("Uint64", "engineTick", cr2w, this);
				}
				return _engineTick;
			}
			set
			{
				if (_engineTick == value)
				{
					return;
				}
				_engineTick = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastTimeDelta")] 
		public CFloat LastTimeDelta
		{
			get
			{
				if (_lastTimeDelta == null)
				{
					_lastTimeDelta = (CFloat) CR2WTypeManager.Create("Float", "lastTimeDelta", cr2w, this);
				}
				return _lastTimeDelta;
			}
			set
			{
				if (_lastTimeDelta == value)
				{
					return;
				}
				_lastTimeDelta = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("engineTime")] 
		public CDouble EngineTime
		{
			get
			{
				if (_engineTime == null)
				{
					_engineTime = (CDouble) CR2WTypeManager.Create("Double", "engineTime", cr2w, this);
				}
				return _engineTime;
			}
			set
			{
				if (_engineTime == value)
				{
					return;
				}
				_engineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get
			{
				if (_rawLocalTime == null)
				{
					_rawLocalTime = (CUInt64) CR2WTypeManager.Create("Uint64", "rawLocalTime", cr2w, this);
				}
				return _rawLocalTime;
			}
			set
			{
				if (_rawLocalTime == value)
				{
					return;
				}
				_rawLocalTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get
			{
				if (_playerPosition == null)
				{
					_playerPosition = (CString) CR2WTypeManager.Create("String", "playerPosition", cr2w, this);
				}
				return _playerPosition;
			}
			set
			{
				if (_playerPosition == value)
				{
					return;
				}
				_playerPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get
			{
				if (_playerOrientation == null)
				{
					_playerOrientation = (CString) CR2WTypeManager.Create("String", "playerOrientation", cr2w, this);
				}
				return _playerOrientation;
			}
			set
			{
				if (_playerOrientation == value)
				{
					return;
				}
				_playerOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("poolsRuntimeInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolRuntimeData> PoolsRuntimeInfo
		{
			get
			{
				if (_poolsRuntimeInfo == null)
				{
					_poolsRuntimeInfo = (CArray<FunctionalTestsDataMemoryPoolRuntimeData>) CR2WTypeManager.Create("array:FunctionalTestsDataMemoryPoolRuntimeData", "poolsRuntimeInfo", cr2w, this);
				}
				return _poolsRuntimeInfo;
			}
			set
			{
				if (_poolsRuntimeInfo == value)
				{
					return;
				}
				_poolsRuntimeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("poolsCurrentInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolStaticData> PoolsCurrentInfo
		{
			get
			{
				if (_poolsCurrentInfo == null)
				{
					_poolsCurrentInfo = (CArray<FunctionalTestsDataMemoryPoolStaticData>) CR2WTypeManager.Create("array:FunctionalTestsDataMemoryPoolStaticData", "poolsCurrentInfo", cr2w, this);
				}
				return _poolsCurrentInfo;
			}
			set
			{
				if (_poolsCurrentInfo == value)
				{
					return;
				}
				_poolsCurrentInfo = value;
				PropertySet(this);
			}
		}

		public FunctionalTestsDataMemoryStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
