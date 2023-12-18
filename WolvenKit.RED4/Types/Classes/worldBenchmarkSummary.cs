using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBenchmarkSummary : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("benchmarkName")] 
		public CString BenchmarkName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("gpuName")] 
		public CString GpuName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("gpuMemory")] 
		public CUInt64 GpuMemory
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("gpuDriverVersion")] 
		public CString GpuDriverVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("cpuName")] 
		public CString CpuName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("systemMemory")] 
		public CUInt64 SystemMemory
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(7)] 
		[RED("osName")] 
		public CString OsName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("osVersion")] 
		public CString OsVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("presetName")] 
		public CString PresetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("presetLocalizedName")] 
		public CName PresetLocalizedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("textureQualityPresetLocalizedName")] 
		public CName TextureQualityPresetLocalizedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("renderWidth")] 
		public CUInt32 RenderWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("renderHeight")] 
		public CUInt32 RenderHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("windowMode")] 
		public CUInt8 WindowMode
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(15)] 
		[RED("verticalSync")] 
		public CBool VerticalSync
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("fpsClamp")] 
		public CInt32 FpsClamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("averageFps")] 
		public CFloat AverageFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("maxFps")] 
		public CFloat MaxFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("frameNumber")] 
		public CUInt32 FrameNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(22)] 
		[RED("upscalingType")] 
		public CUInt8 UpscalingType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(23)] 
		[RED("DLAAEnabled")] 
		public CBool DLAAEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("DLAASharpness")] 
		public CFloat DLAASharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("DLSSEnabled")] 
		public CBool DLSSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("DLSSDEnabled")] 
		public CBool DLSSDEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("DLSSQuality")] 
		public CInt32 DLSSQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("DLSSSharpness")] 
		public CFloat DLSSSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("DLSSFrameGenEnabled")] 
		public CBool DLSSFrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("FSR2Enabled")] 
		public CBool FSR2Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("FSR2Quality")] 
		public CInt32 FSR2Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("FSR2Sharpness")] 
		public CFloat FSR2Sharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("XeSSEnabled")] 
		public CBool XeSSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("XeSSQuality")] 
		public CInt32 XeSSQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("XeSSSharpness")] 
		public CFloat XeSSSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("DRSEnabled")] 
		public CBool DRSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("DRSTargetFPS")] 
		public CUInt32 DRSTargetFPS
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(38)] 
		[RED("DRSMinimalResolutionPercentage")] 
		public CUInt32 DRSMinimalResolutionPercentage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(39)] 
		[RED("DRSMaximalResolutionPercentage")] 
		public CUInt32 DRSMaximalResolutionPercentage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(40)] 
		[RED("CASSharpeningEnabled")] 
		public CBool CASSharpeningEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("FSREnabled")] 
		public CBool FSREnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("FSRQuality")] 
		public CInt32 FSRQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(43)] 
		[RED("rayTracingEnabled")] 
		public CBool RayTracingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("rayTracedReflections")] 
		public CBool RayTracedReflections
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("rayTracedSunShadows")] 
		public CBool RayTracedSunShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("rayTracedLocalShadows")] 
		public CBool RayTracedLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("rayTracedLightingQuality")] 
		public CInt32 RayTracedLightingQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("rayTracedPathTracingEnabled")] 
		public CBool RayTracedPathTracingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldBenchmarkSummary()
		{
			WindowMode = 1;
			FpsClamp = -1;
			DRSTargetFPS = 30;
			DRSMinimalResolutionPercentage = 100;
			DRSMaximalResolutionPercentage = 100;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
