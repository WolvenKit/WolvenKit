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
			get => GetProperty(ref _engineTick);
			set => SetProperty(ref _engineTick, value);
		}

		[Ordinal(1)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetProperty(ref _rawLocalTime);
			set => SetProperty(ref _rawLocalTime, value);
		}

		[Ordinal(2)] 
		[RED("meshChunkCount")] 
		public CUInt32 MeshChunkCount
		{
			get => GetProperty(ref _meshChunkCount);
			set => SetProperty(ref _meshChunkCount, value);
		}

		[Ordinal(3)] 
		[RED("cameraTriangleCount")] 
		public CUInt32 CameraTriangleCount
		{
			get => GetProperty(ref _cameraTriangleCount);
			set => SetProperty(ref _cameraTriangleCount, value);
		}

		[Ordinal(4)] 
		[RED("shadowTriangleCount")] 
		public CUInt32 ShadowTriangleCount
		{
			get => GetProperty(ref _shadowTriangleCount);
			set => SetProperty(ref _shadowTriangleCount, value);
		}

		[Ordinal(5)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetProperty(ref _playerPosition);
			set => SetProperty(ref _playerPosition, value);
		}

		[Ordinal(6)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetProperty(ref _playerOrientation);
			set => SetProperty(ref _playerOrientation, value);
		}

		public FunctionalTestsDataRenderingStatsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
