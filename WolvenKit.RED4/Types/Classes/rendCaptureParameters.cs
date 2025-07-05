using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendCaptureParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<rendScreenshotMode> Mode
		{
			get => GetPropertyValue<CEnum<rendScreenshotMode>>();
			set => SetPropertyValue<CEnum<rendScreenshotMode>>(value);
		}

		[Ordinal(2)] 
		[RED("videoRecordingMode")] 
		public CBool VideoRecordingMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("audioRecordingMode")] 
		public CBool AudioRecordingMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("emmModes")] 
		public CArray<CEnum<EEnvManagerModifier>> EmmModes
		{
			get => GetPropertyValue<CArray<CEnum<EEnvManagerModifier>>>();
			set => SetPropertyValue<CArray<CEnum<EEnvManagerModifier>>>(value);
		}

		[Ordinal(5)] 
		[RED("initialFrameNumber")] 
		public CUInt32 InitialFrameNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("outputDirectoryIndex")] 
		public CUInt32 OutputDirectoryIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("outputDirectoryName")] 
		public CString OutputDirectoryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("outputDirectoryNameSuffix")] 
		public CString OutputDirectoryNameSuffix
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("recordingFPS")] 
		public CUInt32 RecordingFPS
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("customResolution")] 
		public Point CustomResolution
		{
			get => GetPropertyValue<Point>();
			set => SetPropertyValue<Point>(value);
		}

		[Ordinal(11)] 
		[RED("resolutionMultiplier")] 
		public CEnum<rendResolutionMultiplier> ResolutionMultiplier
		{
			get => GetPropertyValue<CEnum<rendResolutionMultiplier>>();
			set => SetPropertyValue<CEnum<rendResolutionMultiplier>>(value);
		}

		[Ordinal(12)] 
		[RED("outputPath")] 
		public AbsolutePathSerializable OutputPath
		{
			get => GetPropertyValue<AbsolutePathSerializable>();
			set => SetPropertyValue<AbsolutePathSerializable>(value);
		}

		[Ordinal(13)] 
		[RED("fovMultiplier")] 
		public CFloat FovMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("captureContextType")] 
		public CEnum<rendCaptureContextType> CaptureContextType
		{
			get => GetPropertyValue<CEnum<rendCaptureContextType>>();
			set => SetPropertyValue<CEnum<rendCaptureContextType>>(value);
		}

		[Ordinal(15)] 
		[RED("saveFormat")] 
		public CEnum<ESaveFormat> SaveFormat
		{
			get => GetPropertyValue<CEnum<ESaveFormat>>();
			set => SetPropertyValue<CEnum<ESaveFormat>>(value);
		}

		public rendCaptureParameters()
		{
			Enable = true;
			EmmModes = new();
			OutputDirectoryName = "Scene";
			RecordingFPS = 30;
			CustomResolution = new Point();
			ResolutionMultiplier = Enums.rendResolutionMultiplier.X2;
			OutputPath = new();
			FovMultiplier = 1.000000F;
			SaveFormat = Enums.ESaveFormat.SF_PNG;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
