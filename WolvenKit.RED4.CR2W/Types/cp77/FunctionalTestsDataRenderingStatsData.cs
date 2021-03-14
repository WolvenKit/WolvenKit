using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataRenderingStatsData : ISerializable
	{
		private CUInt64 _engineTick;
		private CUInt64 _rawLocalTime;
		private CUInt32 _meshChunkCount;
		private CUInt32 _cameraTriangleCount;
		private CUInt32 _shadowTriangleCount;
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

		[Ordinal(2)] 
		[RED("meshChunkCount")] 
		public CUInt32 MeshChunkCount
		{
			get
			{
				if (_meshChunkCount == null)
				{
					_meshChunkCount = (CUInt32) CR2WTypeManager.Create("Uint32", "meshChunkCount", cr2w, this);
				}
				return _meshChunkCount;
			}
			set
			{
				if (_meshChunkCount == value)
				{
					return;
				}
				_meshChunkCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cameraTriangleCount")] 
		public CUInt32 CameraTriangleCount
		{
			get
			{
				if (_cameraTriangleCount == null)
				{
					_cameraTriangleCount = (CUInt32) CR2WTypeManager.Create("Uint32", "cameraTriangleCount", cr2w, this);
				}
				return _cameraTriangleCount;
			}
			set
			{
				if (_cameraTriangleCount == value)
				{
					return;
				}
				_cameraTriangleCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shadowTriangleCount")] 
		public CUInt32 ShadowTriangleCount
		{
			get
			{
				if (_shadowTriangleCount == null)
				{
					_shadowTriangleCount = (CUInt32) CR2WTypeManager.Create("Uint32", "shadowTriangleCount", cr2w, this);
				}
				return _shadowTriangleCount;
			}
			set
			{
				if (_shadowTriangleCount == value)
				{
					return;
				}
				_shadowTriangleCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		public FunctionalTestsDataRenderingStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
