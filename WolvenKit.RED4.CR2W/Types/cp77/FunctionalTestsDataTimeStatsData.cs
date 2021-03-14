using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataTimeStatsData : ISerializable
	{
		private CUInt64 _engineTick;
		private CFloat _lastFps;
		private CFloat _minFps;
		private CFloat _lastTimeDelta;
		private CDouble _engineTime;
		private CFloat _cpuTime;
		private CFloat _gpuTime;
		private CUInt64 _rawLocalTime;
		private CString _playerPosition;
		private CString _playerOrientation;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("lastFps")] 
		public CFloat LastFps
		{
			get
			{
				if (_lastFps == null)
				{
					_lastFps = (CFloat) CR2WTypeManager.Create("Float", "lastFps", cr2w, this);
				}
				return _lastFps;
			}
			set
			{
				if (_lastFps == value)
				{
					return;
				}
				_lastFps = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get
			{
				if (_minFps == null)
				{
					_minFps = (CFloat) CR2WTypeManager.Create("Float", "minFps", cr2w, this);
				}
				return _minFps;
			}
			set
			{
				if (_minFps == value)
				{
					return;
				}
				_minFps = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("cpuTime")] 
		public CFloat CpuTime
		{
			get
			{
				if (_cpuTime == null)
				{
					_cpuTime = (CFloat) CR2WTypeManager.Create("Float", "cpuTime", cr2w, this);
				}
				return _cpuTime;
			}
			set
			{
				if (_cpuTime == value)
				{
					return;
				}
				_cpuTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gpuTime")] 
		public CFloat GpuTime
		{
			get
			{
				if (_gpuTime == null)
				{
					_gpuTime = (CFloat) CR2WTypeManager.Create("Float", "gpuTime", cr2w, this);
				}
				return _gpuTime;
			}
			set
			{
				if (_gpuTime == value)
				{
					return;
				}
				_gpuTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		public FunctionalTestsDataTimeStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
