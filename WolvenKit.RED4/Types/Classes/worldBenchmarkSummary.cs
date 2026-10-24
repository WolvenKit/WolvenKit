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
		[RED("macProductName")] 
		public CString MacProductName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("osName")] 
		public CString OsName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("osVersion")] 
		public CString OsVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("presetName")] 
		public CString PresetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("presetLocalizedName")] 
		public CName PresetLocalizedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("textureQualityPresetLocalizedName")] 
		public CName TextureQualityPresetLocalizedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("renderWidth")] 
		public CUInt32 RenderWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("renderHeight")] 
		public CUInt32 RenderHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("windowMode")] 
		public CUInt8 WindowMode
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(16)] 
		[RED("verticalSync")] 
		public CBool VerticalSync
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("fpsClamp")] 
		public CInt32 FpsClamp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("averageFps")] 
		public CFloat AverageFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("maxFps")] 
		public CFloat MaxFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("frameNumber")] 
		public CUInt32 FrameNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("upscalingType")] 
		public CUInt8 UpscalingType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(24)] 
		[RED("frameGenerationType")] 
		public CUInt8 FrameGenerationType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(25)] 
		[RED("DLAAEnabled")] 
		public CBool DLAAEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("DLAASharpness")] 
		public CFloat DLAASharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("DLSSEnabled")] 
		public CBool DLSSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("DLSSPreset")] 
		public CInt32 DLSSPreset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("DLSSDEnabled")] 
		public CBool DLSSDEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("DLSSQuality")] 
		public CInt32 DLSSQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("DLSSSharpness")] 
		public CFloat DLSSSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("DLSSFrameGenEnabled")] 
		public CBool DLSSFrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("DLSSMultiFrameGenEnabled")] 
		public CBool DLSSMultiFrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("DLSSMultiFrameGenFrameToGenerate")] 
		public CInt32 DLSSMultiFrameGenFrameToGenerate
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("FSR2Enabled")] 
		public CBool FSR2Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("FSR2Quality")] 
		public CInt32 FSR2Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("FSR2Sharpness")] 
		public CFloat FSR2Sharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("FSR3Enabled")] 
		public CBool FSR3Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("FSR3Quality")] 
		public CInt32 FSR3Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(40)] 
		[RED("FSR3Sharpness")] 
		public CFloat FSR3Sharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("FSR3FrameGenEnabled")] 
		public CBool FSR3FrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("FSR4Enabled")] 
		public CBool FSR4Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("FSR4Quality")] 
		public CInt32 FSR4Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("FSR4Sharpness")] 
		public CFloat FSR4Sharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("XeSSEnabled")] 
		public CBool XeSSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("XeSSQuality")] 
		public CInt32 XeSSQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(47)] 
		[RED("XeSSSharpness")] 
		public CFloat XeSSSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("XeSSFrameGenEnabled")] 
		public CBool XeSSFrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("MFXEnabled")] 
		public CBool MFXEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("MFXQuality")] 
		public CInt32 MFXQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(51)] 
		[RED("MFXSharpness")] 
		public CFloat MFXSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("MFXFrameGenEnabled")] 
		public CBool MFXFrameGenEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("DRSEnabled")] 
		public CBool DRSEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("DRSTargetFPS")] 
		public CUInt32 DRSTargetFPS
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(55)] 
		[RED("DRSMinimalResolutionPercentage")] 
		public CUInt32 DRSMinimalResolutionPercentage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(56)] 
		[RED("DRSMaximalResolutionPercentage")] 
		public CUInt32 DRSMaximalResolutionPercentage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(57)] 
		[RED("CASSharpeningEnabled")] 
		public CBool CASSharpeningEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("FSREnabled")] 
		public CBool FSREnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("FSRQuality")] 
		public CInt32 FSRQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(60)] 
		[RED("rayTracingEnabled")] 
		public CBool RayTracingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("rayTracedReflections")] 
		public CBool RayTracedReflections
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("rayTracedSunShadows")] 
		public CBool RayTracedSunShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("rayTracedLocalShadows")] 
		public CBool RayTracedLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("rayTracedLightingQuality")] 
		public CInt32 RayTracedLightingQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(65)] 
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
			DLSSMultiFrameGenFrameToGenerate = 1;
			DRSTargetFPS = 30;
			DRSMinimalResolutionPercentage = 100;
			DRSMaximalResolutionPercentage = 100;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
