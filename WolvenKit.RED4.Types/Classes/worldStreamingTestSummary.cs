using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingTestSummary : ISerializable
	{
		[Ordinal(0)] 
		[RED("gameDefinition")] 
		public CString GameDefinition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("noCrowds")] 
		public CBool NoCrowds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("testDurationSeconds")] 
		public CFloat TestDurationSeconds
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("initialBytesRead")] 
		public CUInt64 InitialBytesRead
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("bytesReadDuringTest")] 
		public CUInt64 BytesReadDuringTest
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(5)] 
		[RED("bytesReadDuringDriving")] 
		public CUInt64 BytesReadDuringDriving
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(6)] 
		[RED("bytesReadDuringCooldown")] 
		public CUInt64 BytesReadDuringCooldown
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(7)] 
		[RED("totalSeeksBytes")] 
		public CUInt64 TotalSeeksBytes
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(8)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("maxFps")] 
		public CFloat MaxFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("averageFps")] 
		public CFloat AverageFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStreamingTestSummary()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
