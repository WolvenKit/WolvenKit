using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsDataRenderingStatsData : ISerializable
	{
		[Ordinal(0)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("meshChunkCount")] 
		public CUInt32 MeshChunkCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("cameraTriangleCount")] 
		public CUInt32 CameraTriangleCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("shadowTriangleCount")] 
		public CUInt32 ShadowTriangleCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public FunctionalTestsDataRenderingStatsData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
